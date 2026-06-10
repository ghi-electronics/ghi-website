// @ts-check
/**
 * TinyCLR API reference generator.
 *
 * Parses the C# source of the TinyCLR libraries (sibling `../TinyCLR-Libraries`)
 * and emits "Complete" API reference pages as Docusaurus MDX into
 * `docs/tinyclr/api/`. No DocFX, no .NET, no library build required — everything
 * (member list + signatures + doc-comments) comes straight from source.
 *
 * Usage:
 *   node scripts/generate-api.mjs                 # all libraries
 *   node scripts/generate-api.mjs --only Gpio     # spike: only matching projects
 *   node scripts/generate-api.mjs --libs <path>   # override libraries root
 */
import { promises as fs } from 'node:fs';
import path from 'node:path';
import { fileURLToPath } from 'node:url';

const __dirname = path.dirname(fileURLToPath(import.meta.url));
const WEBSITE_ROOT = path.resolve(__dirname, '..');

function parseArgs(argv) {
  const args = { only: null, libs: null };
  for (let i = 0; i < argv.length; i++) {
    if (argv[i] === '--only') args.only = argv[++i];
    else if (argv[i] === '--libs') args.libs = argv[++i];
  }
  return args;
}

// ---------------------------------------------------------------------------
// 1. Lexical pre-pass: blank out strings / char-literals / comments so that
//    brace and terminator scanning never trips over braces inside "$"{x}"" etc.
//    Output is the same length & line layout as the source; `///` doc-comment
//    lines are collected separately (keyed by the line they document).
// ---------------------------------------------------------------------------
// Preprocessor: blank out code in inactive #if/#elif/#else regions so the docs
// match the shipped device Release assembly (e.g. #if ENABLE_MANAGED_GRAPHIC and
// #if DEBUG are dropped, while #if !DESKTOP stays active). Directive lines are
// blanked too. Line positions are preserved (blank to spaces, keep newlines) so
// downstream line lookups stay valid. Undefined symbols evaluate to false.
const PP_DEFINED = new Set(['TRACE']);

function ppEval(expr, defined) {
  const toks = expr.match(/[A-Za-z_][A-Za-z0-9_]*|&&|\|\||[!()]/g) || [];
  let pos = 0;
  const peek = () => toks[pos];
  const next = () => toks[pos++];
  function parseOr() { let v = parseAnd(); while (peek() === '||') { next(); v = parseAnd() || v; } return v; }
  function parseAnd() { let v = parseUnary(); while (peek() === '&&') { next(); v = parseUnary() && v; } return v; }
  function parseUnary() { if (peek() === '!') { next(); return !parseUnary(); } return parsePrimary(); }
  function parsePrimary() {
    const t = next();
    if (t === '(') { const v = parseOr(); if (peek() === ')') next(); return v; }
    if (t === 'true') return true;
    if (t === 'false' || t === undefined) return false;
    return defined.has(t);
  }
  return !!parseOr();
}

function preprocess(src, defined) {
  if (src.indexOf('#if') === -1) return src;
  const lines = src.split('\n');
  const stack = []; // { active, taken, parentActive }
  const cur = () => stack.length ? stack[stack.length - 1].active : true;
  for (let i = 0; i < lines.length; i++) {
    const ln = lines[i];
    // No `$` anchor: lines may keep a trailing `\r` (CRLF), which `.`/`$` won't span.
    const m = /^\s*#\s*(if|elif|else|endif|define|undef|region|endregion|pragma|error|warning|line|nullable)\b(.*)/.exec(ln);
    if (m) {
      const dir = m[1], arg = (m[2] || '').replace(/\/\/.*$/, '').trim();
      if (dir === 'if') { const pa = cur(); const c = pa && ppEval(arg, defined); stack.push({ active: c, taken: c, parentActive: pa }); }
      else if (dir === 'elif') { const t = stack[stack.length - 1]; if (t) { const c = t.parentActive && !t.taken && ppEval(arg, defined); t.active = c; if (c) t.taken = true; } }
      else if (dir === 'else') { const t = stack[stack.length - 1]; if (t) { t.active = t.parentActive && !t.taken; t.taken = true; } }
      else if (dir === 'endif') { stack.pop(); }
      else if (dir === 'define') { if (cur()) defined.add(arg.split(/\s/)[0]); }
      else if (dir === 'undef') { if (cur()) defined.delete(arg.split(/\s/)[0]); }
      lines[i] = ' '.repeat(ln.length);
      continue;
    }
    if (!cur()) lines[i] = ' '.repeat(ln.length);
  }
  return lines.join('\n');
}

function cleanAndCollectDocs(src) {
  const out = Buffer.from(src, 'utf8').toString('utf8').split('');
  const n = src.length;
  const blank = (a, b) => { for (let k = a; k < b; k++) if (out[k] !== '\n') out[k] = ' '; };

  // doc blocks: array of {text, nextLine}
  const docLines = []; // {line, text}
  let i = 0;
  while (i < n) {
    const c = src[i], d = src[i + 1];
    // comments
    if (c === '/' && d === '/') {
      let j = src.indexOf('\n', i); if (j === -1) j = n;
      // Only a leading `///` (first non-whitespace on its line) is a doc comment.
      // A `///` trailing after code on the same line is just a comment (Roslyn
      // ignores it too) and must not merge into the preceding doc block.
      let ls = i; while (ls > 0 && src[ls - 1] !== '\n') ls--;
      const atLineStart = !/\S/.test(src.slice(ls, i));
      const isDoc = src[i + 2] === '/' && src[i + 3] !== '/' && atLineStart;
      if (isDoc) {
        const line = lineOf(src, i);
        docLines.push({ line, text: src.slice(i + 3, j).replace(/\r$/, ''), end: j });
      }
      blank(i, j); i = j; continue;
    }
    if (c === '/' && d === '*') {
      let j = src.indexOf('*/', i + 2); j = j === -1 ? n : j + 2;
      blank(i, j); i = j; continue;
    }
    // strings (with optional @ / $ prefixes) and char literals
    if (c === '"' || c === '\'' || ((c === '@' || c === '$') && peekString(src, i))) {
      const end = scanStringOrChar(src, i);
      blank(i, end); i = end; continue;
    }
    i++;
  }

  // Fold consecutive doc lines into blocks; map block -> first code line after it.
  // Key to the next line that actually holds code, skipping blank lines AND
  // blanked-out non-doc comment lines (e.g. NETMF-style `// Summary:` blocks that
  // sit between a `///` comment and its declaration — Roslyn still attaches the
  // doc to the declaration, so the rendered docs must match that).
  const docByLine = new Map();
  let b = 0;
  while (b < docLines.length) {
    let e = b;
    while (e + 1 < docLines.length && docLines[e + 1].line === docLines[e].line + 1) e++;
    const text = docLines.slice(b, e + 1).map(x => x.text).join('\n');
    let p = docLines[e].end;            // index just past the last `///` line
    while (p < n && (out[p] === ' ' || out[p] === '\t' || out[p] === '\r' || out[p] === '\n')) p++;
    const targetLine = p < n ? lineOf(src, p) : docLines[e].line + 1;
    docByLine.set(targetLine, text);
    b = e + 1;
  }
  return { code: out.join(''), docByLine };
}

function peekString(src, i) {
  // i points at @ or $; allow $@ / @$ combos then a quote
  let j = i;
  while (src[j] === '@' || src[j] === '$') j++;
  return src[j] === '"';
}

function scanStringOrChar(src, i) {
  const n = src.length;
  let verbatim = false, j = i;
  while (src[j] === '@' || src[j] === '$') { if (src[j] === '@') verbatim = true; j++; }
  const quote = src[j];
  j++; // past opening quote
  if (quote === '\'') {
    while (j < n) { if (src[j] === '\\') j += 2; else if (src[j] === '\'') return j + 1; else j++; }
    return n;
  }
  // string
  while (j < n) {
    const c = src[j];
    if (verbatim) {
      if (c === '"') { if (src[j + 1] === '"') j += 2; else return j + 1; }
      else j++;
    } else {
      if (c === '\\') j += 2;
      else if (c === '"') return j + 1;
      else j++;
    }
  }
  return n;
}

// Precomputed-free line lookup (small files, fine).
function lineOf(src, idx) {
  let line = 0;
  for (let k = 0; k < idx; k++) if (src[k] === '\n') line++;
  return line;
}

// ---------------------------------------------------------------------------
// 2. Declaration scanner: walk a brace-block, yielding header/body segments.
// ---------------------------------------------------------------------------
function matchBrace(code, open) {
  let depth = 0;
  for (let i = open; i < code.length; i++) {
    if (code[i] === '{') depth++;
    else if (code[i] === '}') { depth--; if (depth === 0) return i; }
  }
  return code.length - 1;
}

function findTopSemicolon(code, from) {
  let pd = 0, bd = 0, ad = 0;
  for (let i = from; i < code.length; i++) {
    const c = code[i];
    if (c === '(') pd++; else if (c === ')') pd--;
    else if (c === '{') bd++; else if (c === '}') bd--;
    else if (c === '[') ad++; else if (c === ']') ad--;
    else if (c === ';' && pd <= 0 && bd <= 0 && ad <= 0) return i;
  }
  return code.length - 1;
}

/** Yield {headerStart, headerEnd, bodyStart, bodyEnd, kind:'block'|'stmt'|'expr'} within [start,end). */
function* segments(code, start, end) {
  let i = start, bufStart = start;
  while (i < end) {
    const c = code[i];
    if (c === '{') {
      const bodyEnd = matchBrace(code, i);
      yield { headerStart: bufStart, headerEnd: i, bodyStart: i, bodyEnd, kind: 'block' };
      i = bodyEnd + 1; bufStart = i;
    } else if (c === ';') {
      if (code.slice(bufStart, i).trim()) yield { headerStart: bufStart, headerEnd: i, kind: 'stmt' };
      i++; bufStart = i;
    } else if (c === '=' && code[i + 1] === '>') {
      const semi = findTopSemicolon(code, i + 2);
      yield { headerStart: bufStart, headerEnd: i, exprStart: i, exprEnd: semi, kind: 'expr' };
      i = semi + 1; bufStart = i;
    } else i++;
  }
}

// ---------------------------------------------------------------------------
// 3. Header classification.
// ---------------------------------------------------------------------------
const MODIFIERS = new Set([
  'public', 'private', 'protected', 'internal', 'static', 'virtual', 'abstract',
  'override', 'sealed', 'readonly', 'const', 'extern', 'unsafe', 'volatile',
  'async', 'new', 'partial', 'implicit', 'explicit',
]);

function stripAttributes(srcHeader, cleanHeader) {
  const attrs = [];
  let s = 0;
  for (;;) {
    const m = /^\s*\[/.exec(cleanHeader.slice(s));
    if (!m) break;
    const open = s + m[0].length - 1;
    let depth = 0, k = open;
    for (; k < cleanHeader.length; k++) {
      if (cleanHeader[k] === '[') depth++;
      else if (cleanHeader[k] === ']') { depth--; if (depth === 0) break; }
    }
    attrs.push(srcHeader.slice(open, k + 1).trim());
    s = k + 1;
  }
  return { attrs, src: srcHeader.slice(s), clean: cleanHeader.slice(s) };
}

function leadingWords(clean) {
  const words = [];
  const m = clean.trimStart();
  const re = /^([A-Za-z_][A-Za-z0-9_]*)/;
  let rest = m, mods = [];
  for (;;) {
    const w = re.exec(rest);
    if (!w) break;
    if (MODIFIERS.has(w[1])) { mods.push(w[1]); rest = rest.slice(w[0].length).trimStart(); }
    else break;
  }
  return { mods, rest };
}

function collapse(s) { return s.replace(/\s+/g, ' ').trim(); }

function accessibilityOf(mods, parentKind) {
  if (mods.includes('public')) return 'public';
  if (mods.includes('protected')) return 'protected';
  if (mods.includes('private')) return 'private';
  if (mods.includes('internal')) return 'internal';
  return parentKind === 'interface' || parentKind === 'enum' ? 'public' : 'private';
}

// ---------------------------------------------------------------------------
// 4. Doc-comment XML parsing.
// ---------------------------------------------------------------------------
function cleanInline(s) {
  if (!s) return '';
  return s
    .replace(/<see\s+cref\s*=\s*"([^"]+)"\s*\/?>/g, (_, id) => '`' + shortCref(id) + '`')
    .replace(/<see\s+langword\s*=\s*"([^"]+)"\s*\/?>/g, (_, w) => '`' + w + '`')
    .replace(/<paramref\s+name\s*=\s*"([^"]+)"\s*\/?>/g, (_, w) => '`' + w + '`')
    .replace(/<typeparamref\s+name\s*=\s*"([^"]+)"\s*\/?>/g, (_, w) => '`' + w + '`')
    .replace(/<c>([\s\S]*?)<\/c>/g, (_, w) => '`' + w.trim() + '`')
    .replace(/<code>([\s\S]*?)<\/code>/g, (_, w) => '`' + w.trim().replace(/\s+/g, ' ') + '`')
    .replace(/<\/?(para|remarks|summary|list|item|term|description|returns|value|example|note)[^>]*>/gi, ' ')
    .replace(/<\/?[a-zA-Z][^>]*>/g, '')   // drop any remaining doc-comment XML tags (itemref, p, b, i, ...)
    .replace(/\s+/g, ' ')
    .trim()
    // Decode XML entities LAST — after every real tag has been handled/stripped,
    // so a decoded "<T>" can't be mistaken for a tag and removed. Without this,
    // entities inside code spans (e.g. <c>ISet&lt;T&gt;</c>) render literally as
    // `ISet&lt;T&gt;` because markdown code spans don't decode entities. prose()
    // re-escapes the non-code "<" for MDX afterwards, so plain text stays correct.
    .replace(/&lt;/g, '<').replace(/&gt;/g, '>')
    .replace(/&quot;/g, '"').replace(/&#39;/g, "'").replace(/&apos;/g, "'")
    .replace(/&amp;/g, '&');
}

function shortCref(id) {
  let s = id.replace(/^[A-Za-z]:/, '');       // strip T:/M:/P:/F:/E: prefix
  s = s.replace(/`+\d+/g, '');                 // generic arity markers
  return s;
}

function parseDoc(text) {
  if (!text) return null;
  const inheritdoc = /<inheritdoc\s*\/?>/.test(text);
  const summaryM = /<summary>([\s\S]*?)<\/summary>/.exec(text);
  let summary = summaryM ? cleanInline(summaryM[1]) : '';
  // Fall back to NETMF-style <devdoc> when there's no <summary>, but ignore the
  // boilerplate "[To be supplied.]" placeholder that litters those comments.
  if (!summary) {
    const dd = /<devdoc>([\s\S]*?)<\/devdoc>/.exec(text);
    if (dd) summary = cleanInline(dd[1]);
  }
  if (/^\[\s*to be supplied\.?\s*\]$/i.test(summary.trim())) summary = '';
  const returnsM = /<returns>([\s\S]*?)<\/returns>/.exec(text);
  const params = {};
  for (const m of text.matchAll(/<param\s+name\s*=\s*"([^"]+)"\s*>([\s\S]*?)<\/param>/g))
    params[m[1]] = cleanInline(m[2]);
  return {
    inheritdoc,
    summary,
    returns: returnsM ? cleanInline(returnsM[1]) : '',
    params,
  };
}

// ---------------------------------------------------------------------------
// 5. Parse one source file into a list of types (with members).
// ---------------------------------------------------------------------------
function parseFile(src, assembly, model) {
  const { code, docByLine } = cleanAndCollectDocs(src);

  const docFor = (headerStart) => {
    // first non-ws char line of the header buffer
    let k = headerStart;
    while (k < code.length && /\s/.test(code[k])) k++;
    return parseDoc(docByLine.get(lineOf(src, k)));
  };

  function walkNamespace(nsName, start, end) {
    for (const seg of segments(code, start, end)) {
      const headerSrc = src.slice(seg.headerStart, seg.headerEnd);
      const headerClean = code.slice(seg.headerStart, seg.headerEnd);
      const { rest } = leadingWords(headerClean);

      const nsM = /^namespace\s+([A-Za-z0-9_.]+)/.exec(rest);
      if (nsM && seg.kind === 'block') {
        const child = nsName ? nsName + '.' + nsM[1] : nsM[1];
        walkNamespace(child, seg.bodyStart + 1, seg.bodyEnd);
        continue;
      }
      classifyType(nsName, '', headerSrc, headerClean, seg);
    }
  }

  // outerPath = dotted chain of enclosing TYPE names (e.g. "SC20260.Timer.Pwm"),
  // distinct from the namespace. Recorded on each type so nested board peripherals
  // (SC20260.Adc vs FEZBit.Adc) stay distinct instead of collapsing by simple name.
  function classifyType(nsName, outerPath, headerSrc, headerClean, seg) {
    const { attrs, src: hSrc, clean: hClean } = stripAttributes(headerSrc, headerClean);
    const { mods, rest } = leadingWords(hClean);
    const kindM = /^(class|struct|interface|enum|delegate)\b/.exec(rest);
    if (!kindM) return;
    const kind = kindM[1];
    const access = accessibilityOf(mods, 'namespace');
    if (access !== 'public' && access !== 'protected') return;

    if (kind === 'delegate') {
      const sig = collapse(hClean);
      const nameM = /\bdelegate\s+[^()]*?\b([A-Za-z_][A-Za-z0-9_]*)\s*(<[^>]*>)?\s*\(/.exec(sig);
      const name = nameM ? nameM[1] + (nameM[2] || '') : '(delegate)';
      const t = makeType(nsName, name, 'delegate', mods, attrs, docFor(seg.headerStart));
      t.assembly = assembly;
      t.outer = outerPath;
      t.signature = sig + ';';
      t.params = parseParams(extractParens(hClean));
      model.types.push(t);
      return;
    }

    const declSrc = collapse(rest); // strip src attrs already; rest is from clean — get name+base from clean is fine
    const nameM = /^(?:class|struct|interface|enum)\s+([A-Za-z_][A-Za-z0-9_]*)\s*(<[^>]*>)?/.exec(declSrc);
    const name = nameM ? nameM[1] + (nameM[2] || '') : '(type)';
    const baseM = /:\s*([^{]+)$/.exec(declSrc);
    const t = makeType(nsName, name, kind, mods, attrs, docFor(seg.headerStart));
    t.assembly = assembly;
    t.outer = outerPath;
    t.bases = baseM ? baseM[1].split(',').map(s => collapse(s)).filter(Boolean) : [];
    t.signature = reconstructTypeSig(mods, kind, name, t.bases);
    model.types.push(t);

    if (seg.kind !== 'block') return;
    const bare = name.replace(/<.*>/, '');
    const ownPath = outerPath ? outerPath + '.' + bare : bare;
    if (kind === 'enum') parseEnumBody(t, seg.bodyStart + 1, seg.bodyEnd);
    else parseTypeBody(t, kind, seg.bodyStart + 1, seg.bodyEnd, nsName, ownPath);
  }

  function parseEnumBody(t, start, end) {
    const body = code.slice(start, end);
    let depth = 0, fieldStart = start;
    const flush = (a, b) => {
      const pieceClean = code.slice(a, b);            // comments blanked → first ident is the member
      const nm = /([A-Za-z_][A-Za-z0-9_]*)\s*(=\s*[^,]+)?/.exec(pieceClean);
      if (!nm) return;
      const lead = pieceClean.length - pieceClean.trimStart().length;
      t.fields.push({ name: nm[1], value: nm[2] ? collapse(nm[2].slice(1)) : '', doc: parseDoc(docByLine.get(lineOf(src, a + lead))) });
    };
    for (let i = start; i < end; i++) {
      const c = code[i];
      if (c === '(' || c === '[' || c === '{') depth++;
      else if (c === ')' || c === ']' || c === '}') depth--;
      else if (c === ',' && depth === 0) { flush(fieldStart, i); fieldStart = i + 1; }
    }
    if (code.slice(fieldStart, end).trim()) flush(fieldStart, end);
  }

  function parseTypeBody(t, parentKind, start, end, nsName, ownPath) {
    for (const seg of segments(code, start, end)) {
      const headerSrc = src.slice(seg.headerStart, seg.headerEnd);
      const headerClean = code.slice(seg.headerStart, seg.headerEnd);
      const { rest } = leadingWords(headerClean);

      // nested type?
      if (/^(class|struct|interface|enum|delegate)\b/.test(rest) || /^namespace\b/.test(rest)) {
        classifyType(nsName, ownPath, headerSrc, headerClean, seg);
        continue;
      }
      classifyMember(t, parentKind, headerSrc, headerClean, seg);
    }
  }

  function classifyMember(t, parentKind, headerSrc, headerClean, seg) {
    const { attrs, src: hSrc, clean: hClean } = stripAttributes(headerSrc, headerClean);
    if (!hClean.trim()) return;
    const { mods, rest } = leadingWords(hClean);
    const access = accessibilityOf(mods, parentKind);
    if (access !== 'public' && access !== 'protected') return;

    const isEvent = mods.includes('event') || /^event\b/.test(rest);
    const restNoEvent = rest.replace(/^event\s+/, '');
    const hasParens = /\(/.test(hClean);
    const obsolete = attrs.find(a => /^Obsolete/.test(a));
    const doc = docFor(seg.headerStart);
    const member = { mods, access, attrs, obsolete: obsolete || null, doc };

    if (hasParens && !isEvent) {
      // method or constructor
      const beforeParen = collapse(restNoEvent.slice(0, restNoEvent.indexOf('(')));
      const toks = beforeParen.split(/\s+/).filter(Boolean);
      const baseTypeName = t.name.replace(/<.*>/, '');
      let name, ret;
      if (toks.length === 1 && toks[0].replace(/<.*>/, '') === baseTypeName) { name = toks[0]; ret = ''; member.ctor = true; }
      else { name = toks[toks.length - 1]; ret = toks.slice(0, -1).join(' '); }
      member.kind = member.ctor ? 'ctor' : 'method';
      member.name = name;
      member.returns = ret;
      member.params = parseParams(extractParens(hClean));
      member.signature = collapse(hClean.replace(/=>[\s\S]*$/, '')).replace(/\s*\{?$/, '');
      t.methods.push(member);
      return;
    }
    if (isEvent) {
      const toks = collapse(restNoEvent).split(/\s+/).filter(Boolean);
      member.kind = 'event';
      member.name = toks[toks.length - 1];
      member.type = toks.slice(0, -1).join(' ');
      member.signature = collapse(`${mods.join(' ')} event ${member.type} ${member.name}`);
      t.events.push(member);
      return;
    }
    // property or field: "Type Name" possibly with { get; set; } or = init
    const decl = collapse(restNoEvent).replace(/=.*$/, '').trim();
    const toks = decl.split(/\s+/).filter(Boolean);
    if (toks.length < 2) return;
    member.name = toks[toks.length - 1];
    member.type = toks.slice(0, -1).join(' ');
    // Initializer from the ORIGINAL source: the cleaned text blanks string literals,
    // which would empty const-string values like the native "...Controller\0" Ids.
    const _eq = hSrc.search(/=(?![=>])/);
    member.value = _eq >= 0 ? collapse(hSrc.slice(_eq + 1)).replace(/;\s*$/, '') : '';
    if (seg.kind === 'block') {
      const bodyClean = code.slice(seg.bodyStart + 1, seg.bodyEnd);
      const hasGet = /\bget\b/.test(bodyClean);
      const hasSet = /\bset\b/.test(bodyClean);
      member.kind = 'property';
      member.accessors = `{ ${[hasGet && 'get;', hasSet && 'set;'].filter(Boolean).join(' ')} }`;
    } else if (seg.kind === 'expr') {
      member.kind = 'property';
      member.accessors = '{ get; }';
    } else {
      member.kind = mods.includes('const') ? 'const' : 'field';
      member.accessors = '';
    }
    member.signature = collapse(`${mods.filter(m => m !== 'event').join(' ')} ${member.type} ${member.name} ${member.accessors}`);
    if (member.kind === 'property') t.properties.push(member);
    else t.fields.push(member);
  }

  walkNamespace('', 0, code.length);
}

function makeType(ns, name, kind, mods, attrs, doc) {
  return { ns, name, kind, mods, attrs, doc, outer: '', bases: [], properties: [], methods: [], events: [], fields: [], params: null, signature: '' };
}

/**
 * Fold `partial` type declarations into a single type. A `partial class Foo` split
 * across N source files parses as N separate type objects (same ns+name+kind), which
 * otherwise renders as N near-identical sidebar entries — only the fragment that
 * happens to carry the `<summary>` and base list looks "real". Merge keeps the first
 * fragment as the canonical object and folds in every other fragment's members and
 * bases, adopting a `<summary>` from whichever fragment has one. Keyed by
 * assembly+ns+kind+name so genuinely distinct same-named types stay separate.
 */
function mergePartialTypes(model) {
  const groups = new Map();   // key -> fragments[]; insertion order preserved
  for (const t of model.types) {
    const key = `${t.assembly || ''}|${t.ns}|${t.outer || ''}|${t.kind}|${t.name}`;
    if (!groups.has(key)) groups.set(key, []);
    groups.get(key).push(t);
  }
  const merged = [];
  for (const frags of groups.values()) {
    if (frags.length === 1) { merged.push(frags[0]); continue; }
    // Canonical = the principal declaration. The base/interface list and the real
    // class <summary> almost always sit on it (the other fragments are member-only
    // splits, sometimes with a comment that actually describes a nested type).
    const canonical =
      frags.find(f => f.bases && f.bases.length) ||
      frags.find(f => f.doc && f.doc.summary) ||
      frags[0];
    for (const f of frags) {
      if (f === canonical) continue;
      canonical.properties.push(...f.properties);
      canonical.methods.push(...f.methods);
      canonical.events.push(...f.events);
      canonical.fields.push(...f.fields);
      for (const b of f.bases) if (!canonical.bases.includes(b)) canonical.bases.push(b);
    }
    if (!canonical.doc || !canonical.doc.summary) {
      const withDoc = frags.find(f => f.doc && f.doc.summary);
      if (withDoc) canonical.doc = withDoc.doc;
    }
    canonical.signature = reconstructTypeSig(canonical.mods, canonical.kind, canonical.name, canonical.bases);
    merged.push(canonical);
  }
  model.types = merged;
}

function reconstructTypeSig(mods, kind, name, bases) {
  const m = mods.filter(x => x !== 'partial').join(' ');
  let s = `${m} ${kind} ${name}`.trim();
  if (bases.length) s += ' : ' + bases.join(', ');
  return s;
}

function extractParens(s) {
  const o = s.indexOf('(');
  if (o === -1) return '';
  let depth = 0;
  for (let i = o; i < s.length; i++) {
    if (s[i] === '(') depth++;
    else if (s[i] === ')') { depth--; if (depth === 0) return s.slice(o + 1, i); }
  }
  return '';
}

function parseParams(inside) {
  inside = inside.trim();
  if (!inside) return [];
  const parts = splitTop(inside, ',');
  return parts.map(p => {
    const clean = collapse(p).replace(/^\[[^\]]*\]\s*/, '');
    const eq = clean.indexOf('=');
    const decl = (eq === -1 ? clean : clean.slice(0, eq)).trim();
    const def = eq === -1 ? '' : clean.slice(eq + 1).trim();
    const toks = decl.split(/\s+/);
    const name = toks[toks.length - 1];
    const type = toks.slice(0, -1).join(' ');
    return { name, type, def };
  });
}

function splitTop(s, sep) {
  const out = []; let depth = 0, last = 0;
  for (let i = 0; i < s.length; i++) {
    const c = s[i];
    if (c === '<' || c === '(' || c === '[') depth++;
    else if (c === '>' || c === ')' || c === ']') depth--;
    else if (c === sep && depth === 0) { out.push(s.slice(last, i)); last = i + 1; }
  }
  out.push(s.slice(last));
  return out;
}

// ---------------------------------------------------------------------------
// 6. inheritdoc resolution: walk a member's ACTUAL base/interface hierarchy (within the
//    same assembly) to inherit a documented summary. The previous version matched members
//    by name+param-count GLOBALLY, which pulled docs off unrelated types (e.g. an SPI
//    "Mode" onto a crypto type, RoutedEventHandlerInfo.Equals onto everything) — always
//    wrong. Now a doc is only inherited from a real ancestor that defines that member.
// ---------------------------------------------------------------------------
function resolveInheritdoc(model) {
  const memberKey = (m) => `${m.name}/${(m.params || []).length}`;
  const bareName = (n) => n.replace(/<.*>/, '');
  const typeIndex = new Map();                                  // "assembly|TypeName" -> type
  for (const t of model.types) typeIndex.set(`${t.assembly || ''}|${bareName(t.name)}`, t);

  const docCache = new Map();                                   // type -> Map(memberKey -> doc)
  const docsOf = (t) => {
    let m = docCache.get(t);
    if (!m) {
      m = new Map();
      for (const mem of [...t.methods, ...t.properties, ...t.events])
        if (mem.doc && mem.doc.summary) m.set(memberKey(mem), mem.doc);
      docCache.set(t, m);
    }
    return m;
  };

  // Nearest documented ancestor member, following t's base/interface list (same assembly).
  const findInherited = (t, mk, seen) => {
    for (const baseName of (t.bases || [])) {
      const base = typeIndex.get(`${t.assembly || ''}|${bareName(baseName)}`);
      if (!base || seen.has(base)) continue;
      seen.add(base);
      const doc = docsOf(base).get(mk);
      if (doc) return doc;
      const deeper = findInherited(base, mk, seen);
      if (deeper) return deeper;
    }
    return null;
  };

  for (const t of model.types)
    for (const m of [...t.methods, ...t.properties, ...t.events])
      if (!m.doc || m.doc.inheritdoc || !m.doc.summary) {
        const found = findInherited(t, memberKey(m), new Set());
        if (found) m.doc = { ...found, inherited: true };
      }
}

// ---------------------------------------------------------------------------
// 7. MDX rendering.
// ---------------------------------------------------------------------------
const NODESC = '_No description available._';
const fileBase = (name) => name.replace(/<.*>/, '');

// Inline code: MDX does NOT parse `<`/`{` inside backticks, so emit raw (only guard | and stray `).
const codeCell = (s) => '`' + String(s || '').replace(/`/g, '').replace(/\|/g, '\\|') + '`';

// Prose: escape `<` and `{`/`}` (JSX triggers) everywhere EXCEPT inside inline-code spans.
function prose(s) {
  if (!s) return '';
  return String(s).split(/(`[^`]*`)/).map((part, i) =>
    i % 2 === 1 ? part // odd parts are the captured `code` spans — leave untouched
      : part.replace(/</g, '&lt;').replace(/\{/g, '&#123;').replace(/\}/g, '&#125;')
  ).join('');
}
const proseCell = (s) => prose(s).replace(/\|/g, '\\|').replace(/\n/g, ' ');
// Safe YAML scalar for frontmatter (double-quote and escape embedded quotes/backslashes).
const yaml = (s) => '"' + String(s || '').replace(/\\/g, '\\\\').replace(/"/g, '\\"') + '"';

function renderType(t) {
  const L = [];
  L.push('---');
  L.push(`title: ${yaml(t.name + ' ' + cap(t.kind))}`);
  L.push(`sidebar_label: ${yaml(t.name)}`);
  L.push('---');
  L.push('');
  L.push(`# ${prose(t.name)} ${cap(t.kind)}`);
  L.push('');
  const _meta = packageMeta(t.assembly);
  L.push([`**NuGet:** \`${_meta.nuget}\``, `**Assembly:** \`${_meta.assembly}\``, `**Namespace:** \`${t.ns}\``].join('<br/>'));
  L.push('');
  L.push(t.doc && t.doc.summary ? prose(t.doc.summary) : NODESC);
  L.push('');
  L.push('```csharp');
  L.push(t.signature);
  L.push('```');
  L.push('');

  if (t.kind === 'enum') {
    L.push('## Fields', '');
    L.push('| Name | Value | Description |', '|---|---|---|');
    for (const f of t.fields)
      L.push(`| ${codeCell(f.name)} | ${f.value ? codeCell(f.value) : ''} | ${f.doc && f.doc.summary ? proseCell(f.doc.summary) : ''} |`);
    L.push('');
    return L.join('\n');
  }

  if (t.kind === 'delegate') {
    if (t.params && t.params.length) renderParamList(L, t.params, t.doc);
    return L.join('\n');
  }

  section(L, 'Constructors', t.methods.filter(m => m.ctor), renderMember);
  section(L, 'Properties', t.properties, renderMember);
  section(L, 'Methods', t.methods.filter(m => !m.ctor), renderMember);
  section(L, 'Events', t.events, renderMember);
  section(L, 'Fields', t.fields, renderMember);
  return L.join('\n');
}

function section(L, title, items, fn) {
  if (!items || !items.length) return;
  L.push(`## ${title}`, '');
  for (const m of items) fn(L, m);
}

// Heading that disambiguates overloads in the page + right-side TOC:
// methods/ctors show their parameter list, e.g. "CanMessage(int arbitrationId, byte[] data)".
function memberHeading(m) {
  if (m.kind === 'method' || m.kind === 'ctor') {
    const ps = (m.params || []).map(p => `${p.type} ${p.name}`).join(', ');
    return `${m.name}(${ps})`;
  }
  return m.name;
}

function renderMember(L, m) {
  L.push(`### ${prose(memberHeading(m))}`, '');
  if (m.obsolete) L.push(`> ⚠️ **Obsolete.** ${proseCell(obsoleteText(m.obsolete))}`, '');
  L.push('```csharp', m.signature, '```', '');
  const summary = m.doc && m.doc.summary ? prose(m.doc.summary) : NODESC;
  L.push(summary + (m.doc && m.doc.inherited ? ' _(inherited)_' : ''), '');
  // Only show the parameter table when at least one parameter is actually documented —
  // otherwise it just repeats the signature (name + type) with empty Description cells.
  const hasParamDoc = m.params && m.doc && m.doc.params && m.params.some(p => m.doc.params[p.name]);
  if ((m.kind === 'method' || m.kind === 'ctor') && m.params && m.params.length && hasParamDoc) {
    L.push('| Parameter | Type | Description |', '|---|---|---|');
    for (const p of m.params)
      L.push(`| ${codeCell(p.name)} | ${codeCell(p.type)} | ${m.doc && m.doc.params[p.name] ? proseCell(m.doc.params[p.name]) : ''} |`);
    L.push('');
  }
  if (m.kind === 'method' && m.returns && m.returns !== 'void') {
    L.push(`**Returns** ${codeCell(m.returns)}${m.doc && m.doc.returns ? ' — ' + prose(m.doc.returns) : ''}`, '');
  }
}

function renderParamList(L, params, doc) {
  // Skip entirely when no parameter is documented — the signature already shows each
  // parameter's name and type, so an all-empty Description column adds nothing.
  if (!params || !params.length || !(doc && doc.params && params.some(p => doc.params[p.name]))) return;
  L.push('## Parameters', '');
  L.push('| Parameter | Type | Description |', '|---|---|---|');
  for (const p of params)
    L.push(`| ${codeCell(p.name)} | ${codeCell(p.type)} | ${doc && doc.params[p.name] ? proseCell(doc.params[p.name]) : ''} |`);
  L.push('');
}

function obsoleteText(attr) {
  const m = /"([^"]*)"/.exec(attr);
  return m ? m[1] : '';
}
function cap(s) { return s.charAt(0).toUpperCase() + s.slice(1); }

// Assembly (NuGet) overview page: types grouped by kind (DocFX-style), each a linked
// table. A Namespace column appears when the package spans more than one namespace
// (e.g. Foo + Foo.Provider), since both ship in the same NuGet.
const KIND_SECTIONS = [
  ['class', 'Classes'], ['struct', 'Structs'], ['interface', 'Interfaces'],
  ['enum', 'Enums'], ['delegate', 'Delegates'],
];

// Folder / URL segment for a package: the NuGet id minus the "GHIElectronics.TinyCLR."
// prefix (e.g. "System.Security.Cryptography"). Used for api/<name>/ paths and links.
const shortName = (asm) => asm.replace(/^GHIElectronics\.TinyCLR\./, '');

// Per-package admonition shown under the heading. Used to cross-link a NuGet to the
// standard-.NET compat shim DLL it ships alongside (same NuGet, separate assembly),
// so users browsing the small helper package discover the richer .NET-compatible API.
const PACKAGE_NOTES = {
  'GHIElectronics.TinyCLR.Cryptography':
    ':::tip\n' +
    '**Need standard .NET cryptography?** This NuGet also provides the .NET-compatible `System.Security.Cryptography` API (hashing, AES, RSA, X.509, …) — see **[GHIElectronics.TinyCLR.System.Security.Cryptography](../System.Security.Cryptography/index.md)**. The `Crc16` and `Xtea` types here are lightweight extras.\n' +
    ':::',
  'GHIElectronics.TinyCLR.System.Security.Cryptography':
    ':::info\n' +
    'The standard-.NET `System.Security.Cryptography` API for TinyCLR. It ships inside the **[GHIElectronics.TinyCLR.Cryptography](../Cryptography/index.md)** NuGet — there is no separate package to install.\n' +
    ':::',
};

// Device NuGets that also ship a standard-.NET compat shim DLL (same NuGet, separate
// assembly): [parent package, shim package, shim API name]. Unlike crypto, here the
// native parent API is primary and the shim is the .NET-compatibility option. Notes
// are generated for both directions and merged into PACKAGE_NOTES.
const SHIM_PAIRS = [
  ['GHIElectronics.TinyCLR.Devices.Gpio', 'GHIElectronics.TinyCLR.System.Device.Gpio', 'System.Device.Gpio'],
  ['GHIElectronics.TinyCLR.Devices.I2c',  'GHIElectronics.TinyCLR.System.Device.I2c',  'System.Device.I2c'],
  ['GHIElectronics.TinyCLR.Devices.Spi',  'GHIElectronics.TinyCLR.System.Device.Spi',  'System.Device.Spi'],
  ['GHIElectronics.TinyCLR.Devices.Pwm',  'GHIElectronics.TinyCLR.System.Device.Pwm',  'System.Device.Pwm'],
  ['GHIElectronics.TinyCLR.Devices.Uart', 'GHIElectronics.TinyCLR.System.IO.Ports',    'System.IO.Ports'],
];
for (const [parent, shim, api] of SHIM_PAIRS) {
  PACKAGE_NOTES[parent] =
    ':::tip\n' +
    `This NuGet also includes the standard, .NET-compatible **\`${api}\`** API — see **[${shim}](../${shortName(shim)}/index.md)**.\n` +
    ':::';
  PACKAGE_NOTES[shim] =
    ':::info\n' +
    `The standard, .NET-compatible \`${api}\` API for TinyCLR. It ships inside the **[${parent}](../${shortName(parent)}/index.md)** NuGet — there is no separate package to install.\n` +
    ':::';
}

// shim package folder -> the parent NuGet it ships inside.
const SHIM_PARENT = { 'GHIElectronics.TinyCLR.System.Security.Cryptography': 'GHIElectronics.TinyCLR.Cryptography' };
for (const [parent, shim] of SHIM_PAIRS) SHIM_PARENT[shim] = parent;

// For a package folder: the NuGet you install, and the real assembly (DLL) name. For the
// 6 compat shims these differ (NuGet = parent, assembly = the System.* DLL); for everything
// else they're the same full id.
function packageMeta(folder) {
  const parent = SHIM_PARENT[folder];
  return { nuget: parent || folder, assembly: parent ? shortName(folder) : folder };
}

function renderAssemblyIndex(assembly, types, fileOf) {
  const showNs = true;                         // always show the Namespace column (uniform table shape)
  const L = [];
  L.push('---');
  L.push(`title: ${yaml(assembly)}`);
  // Suppress Docusaurus's auto-rendered (oversized) title H1; we emit our own
  // MS-styled <h1> below. Without this both show up (duplicate heading).
  L.push('hide_title: true');
  L.push(`sidebar_label: Overview`);
  L.push('---');
  L.push('');
  // Heading: "<name> Library" (matches the index "Library" column). Each page is one
  // assembly/DLL — it may span several namespaces and isn't always a separate NuGet (the
  // System.* shims ship inside a parent package), so "Library" reads better than "NuGet"
  // or "Namespace". Raw <h1> (className works because Docusaurus 3 parses .md as MDX) lets
  // custom.css size it like the Microsoft docs page, not Docusaurus's oversized default.
  L.push(`<h1 className="api-package-heading">${shortName(assembly)} Library</h1>`);
  L.push('');
  if (PACKAGE_NOTES[assembly]) {
    L.push(PACKAGE_NOTES[assembly], '');
  }
  for (const [kind, heading] of KIND_SECTIONS) {
    const group = types.filter(t => t.kind === kind).sort((a, b) => a.name.localeCompare(b.name));
    if (!group.length) continue;
    L.push(`## ${heading}`, '');
    L.push(showNs ? `| ${cap(kind)} | Namespace | Summary |` : `| ${cap(kind)} | Summary |`);
    L.push(showNs ? '|---|---|---|' : '|---|---|');
    for (const t of group) {
      const link = `[${prose(t.name)}](./${encodeURIComponent(fileOf.get(t))}.md)`;
      const summary = t.doc && t.doc.summary ? proseCell(t.doc.summary) : '';
      L.push(showNs ? `| ${link} | \`${t.ns}\` | ${summary} |` : `| ${link} | ${summary} |`);
    }
    L.push('');
  }
  return L.join('\n');
}

// Assign a unique file basename per type within an assembly folder (guard collisions
// across namespaces, e.g. Foo.Bar and Foo.Baz.Bar both named "Bar").
function assignFilenames(types) {
  const used = new Set(), map = new Map();
  for (const t of types) {
    let base = fileBase(t.name), f = base, n = 2;
    while (used.has(f.toLowerCase())) f = `${base}_${n++}`;
    used.add(f.toLowerCase());
    map.set(t, f);
  }
  return map;
}

// ---------------------------------------------------------------------------
// 8. Driver.
// ---------------------------------------------------------------------------
// Windows file watchers (VS Code) can transiently lock the output dir; retry hard.
async function rmrf(dir) {
  for (let attempt = 0; ; attempt++) {
    try { await fs.rm(dir, { recursive: true, force: true, maxRetries: 10, retryDelay: 200 }); return; }
    catch (err) {
      if (attempt >= 5) throw err;
      await new Promise(r => setTimeout(r, 400));
    }
  }
}

async function findCsFiles(dir) {
  const out = [];
  async function walk(d) {
    let entries;
    try { entries = await fs.readdir(d, { withFileTypes: true }); } catch { return; }
    for (const e of entries) {
      const full = path.join(d, e.name);
      if (e.isDirectory()) {
        if (e.name === 'bin' || e.name === 'obj' || e.name === 'Properties') continue;
        await walk(full);
      } else if (e.name.endsWith('.cs') && !e.name.endsWith('AssemblyAttributes.cs')) out.push(full);
    }
  }
  await walk(dir);
  return out;
}

// Package description for the API index table: the nuspec <description> for most
// packages, falling back to [assembly: AssemblyDescription("...")] for the dual-mode
// compat shims that ship inside a parent NuGet and have no nuspec of their own.
// Both sources live in TinyCLR-Libraries (edit there, not here).
async function readPackageDescription(libsRoot, asm) {
  try {
    const nuspec = await fs.readFile(path.join(libsRoot, asm, asm + '.nuspec'), 'utf8');
    const m = nuspec.match(/<description>([\s\S]*?)<\/description>/i);
    if (m && m[1].trim()) return m[1].trim();
  } catch { /* no nuspec for this package */ }
  try {
    const info = await fs.readFile(path.join(libsRoot, asm, 'Properties', 'AssemblyInfo.cs'), 'utf8');
    const m = info.match(/AssemblyDescription\("([^"]*)"\)/);
    if (m && m[1].trim()) return m[1].trim();
  } catch { /* no AssemblyInfo */ }
  return '';
}

// ---------------------------------------------------------------------------
// Pins package: a board -> peripheral -> pin constant tree, rendered specially.
// ---------------------------------------------------------------------------
const pinsFullPath = (t) => (t.outer ? t.outer + '.' + t.name : t.name);

function renderPinsIndex(asm, boards) {
  const real = boards.filter(b => !/^STM32/.test(b.name));
  const chips = boards.filter(b => /^STM32/.test(b.name));
  const L = ['---', `title: ${yaml(asm)}`, 'hide_title: true', 'sidebar_label: Overview', '---', '',
    `<h1 className="api-package-heading">${shortName(asm)} Library</h1>`, '',
    'Pin, peripheral, and bus definitions, grouped by board. Pick your board:', '',
    '## Boards', ''];
  for (const b of real) L.push(`- [${b.name}](./${encodeURIComponent(b.name)}.md)`);
  if (chips.length) {
    L.push('', '## Chip families', '',
      'Shared chip-level definitions that the boards above reference.', '');
    for (const b of chips) L.push(`- [${b.name}](./${encodeURIComponent(b.name)}.md)`);
  }
  L.push('');
  return L.join('\n');
}

function renderPinsBoardPage(board, allTypes) {
  const childrenOf = (p) => allTypes.filter(t => t.outer === p)
    .sort((a, b) => a.name.localeCompare(b.name, undefined, { numeric: true })); // Controller2 before Controller12
  const L = ['---', `title: ${yaml(board.name)}`, 'hide_title: true', `sidebar_label: ${yaml(board.name)}`, '---', '',
    `<h1 className="api-package-heading">${board.name}</h1>`, ''];
  const _meta = packageMeta(board.assembly);
  L.push([`**NuGet:** \`${_meta.nuget}\``, `**Assembly:** \`${_meta.assembly}\``, `**Namespace:** \`${board.ns}\``].join('<br/>'), '');
  if (board.doc && board.doc.summary) L.push(proseCell(board.doc.summary), '');
  const prefix = board.name + '.';
  const walk = (type) => {
    if (type.fields.length) {
      const rel = pinsFullPath(type).slice(prefix.length) || type.name;  // path under the board, e.g. "Timer.Pwm.Controller1"
      L.push(`## ${rel}`, '');
      if (type.doc && type.doc.summary) L.push(proseCell(type.doc.summary), '');
      L.push('| Member | Value |', '|---|---|');
      for (const f of type.fields) {
        const v = (f.value || '').replace(/^"([\s\S]*)"$/, '$1');   // unwrap a string-literal value, e.g. "...AdcController\\0"
        L.push(`| \`${f.name}\` | ${v ? '`' + v.replace(/\|/g, '\\|') + '`' : ''} |`);
      }
      L.push('');
    }
    for (const c of childrenOf(pinsFullPath(type))) walk(c);
  };
  for (const c of childrenOf(board.name)) walk(c);
  return L.join('\n');
}

async function main() {
  const args = parseArgs(process.argv.slice(2));
  const libsRoot = args.libs ? path.resolve(args.libs) : path.resolve(WEBSITE_ROOT, '..', 'TinyCLR-Libraries');
  const outRoot = path.join(WEBSITE_ROOT, 'docs', 'tinyclr', 'api');

  let projectDirs = (await fs.readdir(libsRoot, { withFileTypes: true }))
    .filter(e => e.isDirectory() && e.name.startsWith('GHIElectronics.TinyCLR.') && !e.name.endsWith('.Desktop'))
    .map(e => e.name);
  if (args.only) projectDirs = projectDirs.filter(n => n.includes(args.only));

  console.log(`[api] libraries root: ${libsRoot}`);
  console.log(`[api] ${projectDirs.length} project(s): ${projectDirs.join(', ')}`);

  const model = { types: [] };
  for (const proj of projectDirs) {
    const assembly = proj;
    const files = await findCsFiles(path.join(libsRoot, proj));
    for (const f of files) {
      const src = preprocess(await fs.readFile(f, 'utf8'), new Set(PP_DEFINED));
      try { parseFile(src, assembly, model); }
      catch (err) { console.warn(`[api] parse warning in ${path.relative(libsRoot, f)}: ${err.message}`); }
    }
  }
  mergePartialTypes(model);
  resolveInheritdoc(model);

  // clean + write
  await rmrf(outRoot);
  await fs.mkdir(outRoot, { recursive: true });

  // Group by assembly (NuGet package), not namespace — one sidebar entry per NuGet.
  const byAsm = new Map();
  for (const t of model.types) {
    const asm = t.assembly || '(unknown)';
    if (!byAsm.has(asm)) byAsm.set(asm, []);
    byAsm.get(asm).push(t);
  }

  const assemblies = [...byAsm.keys()].sort();
  for (const asm of assemblies) {
    const asmDir = path.join(outRoot, shortName(asm));
    await fs.mkdir(asmDir, { recursive: true });
    const types = byAsm.get(asm).sort((a, b) => a.name.localeCompare(b.name));
    const fileOf = assignFilenames(types);
    // _category_.json: label only — the folder's index.md becomes the category landing page.
    // The sidebar label strips the "GHIElectronics.TinyCLR." prefix so the API tree
    // stays readable (e.g. "System.Security.Cryptography" instead of the full id).
    // The folder name and the page content (index.md title + heading) keep the FULL
    // package name so users still see the real NuGet id and aren't misled.
    const sidebarLabel = asm.replace(/^GHIElectronics\.TinyCLR\./, '');
    await fs.writeFile(path.join(asmDir, '_category_.json'),
      JSON.stringify({ label: sidebarLabel }, null, 2));

    // Pins is a board -> peripheral -> pin constant tree, not normal API types:
    // render a board index + one page per board instead of the flat type table.
    if (asm === 'GHIElectronics.TinyCLR.Pins') {
      const boards = types.filter(t => !t.outer && t.kind === 'class')
        .sort((a, b) => a.name.localeCompare(b.name));
      await fs.writeFile(path.join(asmDir, 'index.md'), renderPinsIndex(asm, boards));
      for (const b of boards)
        await fs.writeFile(path.join(asmDir, b.name + '.md'), renderPinsBoardPage(b, types));
      continue;
    }

    await fs.writeFile(path.join(asmDir, 'index.md'), renderAssemblyIndex(asm, types, fileOf));
    for (const t of types)
      await fs.writeFile(path.join(asmDir, fileOf.get(t) + '.md'), renderType(t));
  }

  // top-level api index — list NuGet packages
  const nsCount = new Set(model.types.map(t => t.ns)).size;
  const descOf = new Map();
  for (const asm of assemblies) descOf.set(asm, await readPackageDescription(libsRoot, asm));
  const idx2 = ['---', 'title: API Reference', 'sidebar_label: Overview', 'slug: /tinyclr/api', '---', '',
    '# TinyCLR API Reference', '',
    '| Library | Description |', '|---|---|'];
  for (const asm of assemblies)
    idx2.push(`| [${shortName(asm)}](./${encodeURIComponent(shortName(asm))}/index.md) | ${proseCell(descOf.get(asm))} |`);
  await fs.writeFile(path.join(outRoot, 'index.md'), idx2.join('\n'));

  const total = model.types.length;
  const documented = model.types.filter(t => t.doc && t.doc.summary).length;
  console.log(`[api] wrote ${total} type pages across ${assemblies.length} NuGet packages (${nsCount} namespaces) -> ${path.relative(WEBSITE_ROOT, outRoot)}`);
  console.log(`[api] (${documented}/${total} types have a summary)`);
}

main().catch(err => { console.error(err); process.exit(1); });
