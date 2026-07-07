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
 *   The firmware version is a 32-bit value split into 4 bytes: x.y.z.t, each 0-255.
 *   The website/Config DISPLAY the 4th byte multiplied by 100, so it always ends
 *   in "00" (device 3.0.0.20  ->  shown 3.0.0.2000). The device itself reports the
 *   real byte (20). So the manifest carries BOTH:
 *     - `version`       the display string ("3.0.0.2000") — shown to users
 *     - `deviceVersion` the real x.y.z.t   ("3.0.0.20")   — what the device reports
 *     - `value`         the real version packed as a uint32 — the compare key
 *   The extension packs the device's reported version the same way and compares
 *   uint32 to uint32. No ÷100 heuristic or string parsing lives in the extension.
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

/** "v3.0.0.2000-prerelease" -> display octets [3,0,0,2000]. */
function displayOctets(label) {
  const s = label.trim().replace(/^v/i, '').replace(/[-_].*$/, ''); // drop leading v + "-prerelease"/"_RTW"
  const parts = s.split('.').map((n) => Number.parseInt(n, 10));
  if (parts.length !== 4 || parts.some((n) => Number.isNaN(n)))
    throw new Error(`Unexpected firmware version label: "${label}"`);
  return parts;
}

/** Display octets [3,0,0,2000] -> real device octets [3,0,0,20] (4th byte ÷100). */
function deviceOctets(display, label) {
  const [a, b, c, d] = display;
  if (d % 100 !== 0)
    console.warn(`[fw] WARN: 4th field ${d} in "${label}" is not a multiple of 100 (expected trailing "00").`);
  const t = Math.round(d / 100);
  const real = [a, b, c, t];
  if (real.some((x) => x < 0 || x > 255))
    console.warn(`[fw] WARN: version "${real.join('.')}" from "${label}" has a byte outside 0-255.`);
  return real;
}

/** Pack real octets into an unsigned 32-bit compare key. */
const packValue = ([a, b, c, d]) => ((a << 24) | (b << 16) | (c << 8) | d) >>> 0;

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
    const display = displayOctets(label);
    const real = deviceOctets(display, label);
    families.push({
      id: familyCode.toLowerCase(),  // "sc20"
      name,                          // "SITCore SC20xxx" — shown to users (never the renamable device name)
      usb,                           // { vid, pid } — the immutable match key, or null when unmapped
      version: display.join('.'),    // "3.0.0.2000" — display form (shown to users)
      deviceVersion: real.join('.'), // "3.0.0.20"   — what the device reports
      value: packValue(real),        // uint32 compare key
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
    console.log(`[fw]   ${f.id.padEnd(5)} vid/pid ${(f.usb ? f.usb.vid + '/' + f.usb.pid : 'unmapped').padEnd(15)} display ${f.version.padEnd(12)} device ${f.deviceVersion.padEnd(10)} value ${f.value}`);
}

main().catch((err) => { console.error(err); process.exit(1); });
