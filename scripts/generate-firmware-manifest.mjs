// @ts-check
/**
 * TinyCLR firmware manifest generator.
 *
 * Parses the **Firmware** section of `docs/tinyclr/downloads.mdx` and emits a
 * small, machine-readable `static/bin/fw/tinyclr_firmware.json`. The Visual Studio
 * extension fetches that file at startup to learn the latest firmware per board
 * family, then compares it against the version it reads from a connected device
 * during deploy and offers an update when the device is behind.
 *
 * `downloads.mdx` stays the single source of truth — humans keep editing one
 * Markdown table — and this script derives the JSON, so the human page and the
 * machine manifest can never drift. There is no HTML scraping in the extension.
 *
 * Version convention (load-bearing):
 *   The firmware DEVICE_VERSION is a 64-bit value split into FOUR 16-bit fields:
 *     (major << 48) | (minor << 32) | (build << 16) | revision      each 0-65535.
 *   The device reports this exact version over the wire (e.g. 3.0.0.2000 with the
 *   full 2000 in the revision field), and the website label is the same string. So
 *   `version` ("3.0.0.2000") is BOTH the display string AND the compare key: the
 *   extension parses it into a System.Version and compares field-by-field against
 *   the device's reported version. No scaling — do NOT divide/multiply by 100.
 *   (The ÷100 form, e.g. 0x03000014 = ...0x14 = 20, only appears in the 32-bit
 *    ImageGenParameters inside a board's BuildConfiguration.txt — a build artifact,
 *    not what the device reports and not what we compare.)
 *
 * Usage:
 *   node scripts/generate-firmware-manifest.mjs
 *   node scripts/generate-firmware-manifest.mjs --check         # verify only, write nothing (CI/build gate)
 *   node scripts/generate-firmware-manifest.mjs --mdx <path> --out <path>   # override inputs (testing)
 */
import { promises as fs } from 'node:fs';
import path from 'node:path';
import { fileURLToPath } from 'node:url';

const __dirname = path.dirname(fileURLToPath(import.meta.url));
const WEBSITE_ROOT = path.resolve(__dirname, '..');
const SCHEMA_VERSION = 1;

function parseArgs(argv) {
  const args = { check: false, mdx: null, out: null };
  for (let i = 0; i < argv.length; i++) {
    if (argv[i] === '--check') args.check = true;
    else if (argv[i] === '--mdx') args.mdx = argv[++i];
    else if (argv[i] === '--out') args.out = argv[++i];
  }
  args.mdx = args.mdx ? path.resolve(args.mdx) : path.join(WEBSITE_ROOT, 'docs', 'tinyclr', 'downloads.mdx');
  // Product-specific name: the GHI site hosts multiple product lines (TinyCLR, Endpoint, DueLink),
  // so each gets its own manifest (e.g. a future endpoint_firmware.json / duelink_firmware.json).
  args.out = args.out ? path.resolve(args.out) : path.join(WEBSITE_ROOT, 'static', 'bin', 'fw', 'tinyclr_firmware.json');
  return args;
}

// ---------------------------------------------------------------------------
// Parsing helpers
// ---------------------------------------------------------------------------

/** Isolate the "## Firmware" section (from its heading to the next "## " heading). */
function firmwareSection(mdx) {
  const start = mdx.search(/^##\s+Firmware\b/m);
  if (start === -1) throw new Error('No "## Firmware" heading found in downloads.mdx');
  const rest = mdx.slice(start);
  // Skip the Firmware heading's own line, then find the next H2.
  const nextRel = rest.slice(1).search(/^##\s+/m);
  return nextRel === -1 ? rest : rest.slice(0, nextRel + 1);
}

/**
 * The current-release table row is the FIRST data row after a "### SITCore SCxx"
 * heading and BEFORE the collapsed "<details> v2 Downloads" block. A row is:
 *   [<label>](<url>) | <date> | <status> | <md5>
 * The heading capture yields both the display name ("SITCore SC20xxx") and the
 * family code ("SC20") used to look up the USB VID/PID below.
 */
const FAMILY_HEADING = /^###\s+(SITCore\s+(SC\d+)\w*)/gim;
const TABLE_ROW =
  /^\s*\[([^\]]+)\]\(([^)]+)\)\s*\|\s*([^|\n]+?)\s*\|\s*([^|\n]+?)\s*\|\s*([0-9A-Fa-f]+)\s*$/m;

/**
 * USB VID/PID per firmware family. This is the immutable, non-user-editable identity
 * the Visual Studio extension matches a connected device against:
 *   - The USB "friendly name" AND the wire-protocol HAL device name share one persisted
 *     store, so a user who renames the device changes both -> neither is reliable.
 *   - The OEM/Model/SKU codes are never populated by firmware (always 0) -> useless.
 *   - VID/PID cannot be changed by the user, and PID granularity matches firmware
 *     granularity exactly (SC20100 + SC20260 share the SC20 firmware and PID 0x5010).
 * The downloads page carries no VID/PID, so they are authored here, keyed by family code.
 * Source of truth: C:\TinyCLR-Devices\Devices\Sc20xxx\Device.h and ...\Sc13xxx\Device.h.
 * When a new board family is added, add its VID/PID here or the extension can't match it.
 */
const USB_IDS = {
  SC20: { vid: '0x1B9F', pid: '0x5010' },
  SC13: { vid: '0x1B9F', pid: '0x5012' },
};

/** "v3.0.0.2000-prerelease" -> "3.0.0.2000". Four fields, each 0-65535 (the device reports this
 *  exact version; it is compared field-by-field with no scaling). */
function parseVersion(label) {
  const s = label.trim().replace(/^v/i, '').replace(/[-_].*$/, ''); // drop leading v + "-prerelease"/"_RTW"
  const parts = s.split('.').map((n) => Number.parseInt(n, 10));
  if (parts.length !== 4 || parts.some((n) => Number.isNaN(n) || n < 0 || n > 65535))
    throw new Error(`Unexpected firmware version label: "${label}" (expected 4 fields, each 0-65535)`);
  return parts.join('.');
}

/** "pathname:///bin/fw/x.ghi" -> "/bin/fw/x.ghi"; absolute http(s) URLs pass through. */
function normalizeUrl(u) {
  const s = u.trim();
  return /^pathname:\/\//i.test(s) ? s.replace(/^pathname:\/\//i, '') : s;
}

function parseFamilies(section) {
  const headings = [...section.matchAll(FAMILY_HEADING)];
  if (!headings.length) throw new Error('No "### SITCore SCxx" firmware families found.');

  const families = [];
  for (let i = 0; i < headings.length; i++) {
    const h = headings[i];
    const name = h[1].trim();             // "SITCore SC20xxx" — display name
    const familyCode = h[2].toUpperCase(); // "SC20" — USB_IDS key
    const blockEnd = i + 1 < headings.length ? headings[i + 1].index : section.length;
    let block = section.slice(h.index, blockEnd);
    // The current release lives above the collapsed older-versions block.
    const detailsAt = block.search(/<details\b/i);
    if (detailsAt !== -1) block = block.slice(0, detailsAt);

    const row = TABLE_ROW.exec(block);
    if (!row) {
      console.warn(`[fw] WARN: no current firmware row found under "${name}"; skipping.`);
      continue;
    }
    const usb = USB_IDS[familyCode] || null;
    if (!usb)
      console.warn(`[fw] WARN: no USB VID/PID mapping for family "${familyCode}"; the extension cannot match this device. Add it to USB_IDS.`);

    const [, label, rawUrl, date, , md5] = row;
    families.push({
      id: familyCode.toLowerCase(),  // "sc20"
      name,                          // "SITCore SC20xxx" — shown to users (never the renamable device name)
      usb,                           // { vid, pid } — the immutable match key, or null when unmapped
      version: parseVersion(label),  // "3.0.0.2000" — the firmware version (4x16-bit); display AND compare key
      date: date.trim(),             // "2026-06-11"
      url: normalizeUrl(rawUrl),     // "/bin/fw/sitcore-sc20-firmware-v3.0.0.2000.ghi"
      md5: md5.trim().toUpperCase(),
    });
  }
  if (!families.length) throw new Error('No firmware families were parsed.');
  return families;
}

// Deterministic serialization (no timestamp) so regenerating without a content
// change yields a byte-identical file — clean diffs, no spurious churn.
function serialize(families) {
  return JSON.stringify(
    { schemaVersion: SCHEMA_VERSION, source: 'docs/tinyclr/downloads.mdx', families },
    null,
    2,
  ) + '\n';
}

// ---------------------------------------------------------------------------
// Driver
// ---------------------------------------------------------------------------
async function main() {
  const args = parseArgs(process.argv.slice(2));
  const mdx = await fs.readFile(args.mdx, 'utf8');
  const families = parseFamilies(firmwareSection(mdx));
  const json = serialize(families);

  if (args.check) {
    let current = null;
    try { current = await fs.readFile(args.out, 'utf8'); } catch { /* not generated yet */ }
    if (current !== json) {
      console.error(`[fw] ${path.relative(WEBSITE_ROOT, args.out)} is stale. Run: npm run gen-firmware`);
      process.exit(1);
    }
    console.log(`[fw] OK: manifest is up to date (${families.length} families).`);
    return;
  }

  await fs.mkdir(path.dirname(args.out), { recursive: true });
  await fs.writeFile(args.out, json);
  console.log(`[fw] wrote ${path.relative(WEBSITE_ROOT, args.out)}`);
  for (const f of families)
    console.log(`[fw]   ${f.id.padEnd(5)} vid/pid ${(f.usb ? f.usb.vid + '/' + f.usb.pid : 'unmapped').padEnd(15)} version ${f.version}`);
}

main().catch((err) => { console.error(err); process.exit(1); });
