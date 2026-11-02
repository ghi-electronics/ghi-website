using System.Text;
using System.Xml.Linq;

namespace EndpointApiGen;

// Extracts human-readable text from a compiler-emitted doc-comment XElement.
// Inline tags (<see cref/>, <c>, <paramref/>) are rendered to markdown-safe
// strings; block tags are flattened to a single paragraph.

public static class Xml {
    public static string? Summary(XElement? e) => Flatten(e?.Element("summary"));
    public static string? Remarks(XElement? e) => Flatten(e?.Element("remarks"));
    public static string? Returns(XElement? e) => Flatten(e?.Element("returns"));
    public static string? ParamText(XElement? e, string name) {
        if (e == null) return null;
        var p = e.Elements("param").FirstOrDefault(x => (string?)x.Attribute("name") == name);
        return Flatten(p);
    }

    static string? Flatten(XElement? e) {
        if (e == null) return null;
        var sb = new StringBuilder();
        foreach (var n in e.Nodes()) Render(n, sb);
        var s = CollapseWhitespace(sb.ToString()).Trim();
        return s.Length == 0 ? null : s;
    }

    static void Render(XNode node, StringBuilder sb) {
        switch (node) {
            case XText t:
                sb.Append(t.Value);
                break;
            case XElement el:
                switch (el.Name.LocalName) {
                    case "see":
                    case "seealso":
                        var cref = (string?)el.Attribute("cref");
                        var langword = (string?)el.Attribute("langword");
                        var href = (string?)el.Attribute("href");
                        if (langword is { Length: > 0 }) sb.Append('`').Append(langword).Append('`');
                        else if (cref is { Length: > 0 }) sb.Append('`').Append(ShortCref(cref)).Append('`');
                        else if (href is { Length: > 0 }) sb.Append(href);
                        else foreach (var n in el.Nodes()) Render(n, sb);
                        break;
                    case "paramref":
                    case "typeparamref":
                        sb.Append('`').Append((string?)el.Attribute("name") ?? "").Append('`');
                        break;
                    case "c":
                        sb.Append('`').Append(el.Value.Trim()).Append('`');
                        break;
                    case "code":
                        // Inline-style collapse; multi-line code blocks are not
                        // common inside <summary>/<returns>/<param>.
                        sb.Append('`').Append(CollapseWhitespace(el.Value).Trim()).Append('`');
                        break;
                    case "para":
                        if (sb.Length > 0 && sb[^1] != ' ') sb.Append(' ');
                        foreach (var n in el.Nodes()) Render(n, sb);
                        break;
                    default:
                        foreach (var n in el.Nodes()) Render(n, sb);
                        break;
                }
                break;
        }
    }

    // "T:Foo.Bar.Baz" → "Baz" ; "M:Foo.Bar.Baz.Qux(System.Int32)" → "Baz.Qux"
    public static string ShortCref(string id) {
        var s = id;
        if (s.Length > 1 && s[1] == ':') s = s[2..];
        var paren = s.IndexOf('(');
        if (paren >= 0) s = s[..paren];
        var tick = s.IndexOf('`');
        if (tick >= 0) s = s[..tick];
        // Keep the last two segments (Type.Member), unless it's a lone type.
        var parts = s.Split('.');
        return parts.Length switch {
            0 => s,
            1 => parts[0],
            _ => parts[^2] + "." + parts[^1],
        };
    }

    static string CollapseWhitespace(string s) {
        var sb = new StringBuilder(s.Length);
        var lastSpace = true;
        foreach (var c in s) {
            if (char.IsWhiteSpace(c)) {
                if (!lastSpace) { sb.Append(' '); lastSpace = true; }
            } else {
                sb.Append(c);
                lastSpace = false;
            }
        }
        return sb.ToString();
    }
}
