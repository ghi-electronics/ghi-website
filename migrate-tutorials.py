"""One-shot migration of TinyCLR tutorials from the legacy docs repo
into the new Docusaurus tree. Run from the website root. Safe to re-run.
Skips files the user has already authored (getting-started.md, features.md).
"""
import json
import os
import re
import subprocess
import sys

REPO_API = "https://api.github.com/repos/ghi-electronics/Documentation/contents/software/tinyclr/tutorials"
RAW_BASE = "https://raw.githubusercontent.com/ghi-electronics/Documentation/master/software/tinyclr/tutorials"
IMG_BASE = "https://docs.ghielectronics.com/software/tinyclr/tutorials/images"
TARGET_DIR = os.path.join(os.path.dirname(__file__), "docs", "tinyclr", "feature")

SKIP_FILES = {"intro.md", "features.md", "getting-started.md", "toc.md"}

ADMONITION_MAP = {
    "tip": "tip",
    "note": "note",
    "warning": "warning",
    "caution": "warning",
    "important": "info",
    "danger": "danger",
}


def fetch_json(url):
    out = subprocess.check_output(["curl", "-s", url])
    return json.loads(out)


def fetch_text(url):
    return subprocess.check_output(["curl", "-s", url]).decode("utf-8")


def convert_admonitions(text):
    """Convert > [!Kind] blockquote admonitions to Docusaurus :::kind blocks."""
    lines = text.splitlines()
    out = []
    i = 0
    while i < len(lines):
        m = re.match(r"^>\s*\[!(\w+)\]\s*(.*)$", lines[i])
        if not m:
            out.append(lines[i])
            i += 1
            continue
        kind_src = m.group(1).lower()
        kind = ADMONITION_MAP.get(kind_src, "note")
        title_remainder = m.group(2).strip()
        body = []
        if title_remainder:
            body.append(title_remainder)
        i += 1
        while i < len(lines) and lines[i].lstrip().startswith(">"):
            stripped = re.sub(r"^>\s?", "", lines[i])
            body.append(stripped)
            i += 1
        out.append(f":::{kind}")
        out.extend(body)
        out.append(":::")
    return "\n".join(out)


def transform(text):
    # Code fence cs → csharp (Prism)
    text = re.sub(r"^```cs\s*$", "```csharp", text, flags=re.M)
    # Image paths: images/foo → absolute URL
    text = re.sub(
        r"!\[([^\]]*)\]\(images/([^)]+)\)",
        rf"![\1]({IMG_BASE}/\2)",
        text,
    )
    # DocFX admonitions
    text = convert_admonitions(text)
    # Escape common MDX-breaking characters in plain text contexts
    # (avoid touching code blocks — quick heuristic: skip inside ```)
    return text


def extract_title(text, fallback):
    m = re.search(r"^#\s+(.+?)\s*$", text, flags=re.M)
    return (m.group(1).strip() if m else fallback).replace('"', "")


def slug_to_title(slug):
    return " ".join(p.capitalize() for p in slug.replace(".md", "").split("-"))


def main():
    os.makedirs(TARGET_DIR, exist_ok=True)
    entries = fetch_json(REPO_API)
    md_files = [e["name"] for e in entries if e.get("name", "").endswith(".md")]

    written = []
    skipped = []
    for name in md_files:
        if name in SKIP_FILES:
            skipped.append(name)
            continue
        url = f"{RAW_BASE}/{name}"
        try:
            raw = fetch_text(url)
        except Exception as exc:
            print(f"FAIL: {name}: {exc}", file=sys.stderr)
            continue

        title = extract_title(raw, slug_to_title(name))
        body = transform(raw)
        # Title is provided by frontmatter; drop the original h1 so we don't double up
        body = re.sub(r"^#\s+.+?\s*$\n?", "", body, count=1, flags=re.M)
        # Drop a stray leading '---' separator if present (legacy DocFX style)
        body = re.sub(r"^\s*---\s*\n", "", body, count=1)

        frontmatter = f"---\ntitle: {title}\n---\n\n"
        out = frontmatter + body.lstrip()
        out_path = os.path.join(TARGET_DIR, name)
        with open(out_path, "w", encoding="utf-8", newline="\n") as f:
            f.write(out)
        written.append(name)

    print(f"Wrote {len(written)} files. Skipped {len(skipped)}: {skipped}")
    print("First 10 written:", written[:10])


if __name__ == "__main__":
    main()
