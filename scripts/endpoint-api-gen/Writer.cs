using System.Text;
using System.Text.Json;

namespace EndpointApiGen;

// Writes Docusaurus MDX for one package in ONE target language. The site has
// three parallel API-reference trees (dotnet/, python/, cpp/) so a reader
// picks the language once from the sidebar and sees every type and member
// rendered in that language's syntax. The underlying API names are identical
// across the three languages by design, so only the signatures change.

public enum Language { Csharp, Python, Cpp }

public static class Writer {

    const string NoDesc = "_No description available._";

    public static string LangFolder(Language l) => l switch {
        Language.Csharp => "dotnet",
        Language.Python => "python",
        Language.Cpp    => "cpp",
        _ => throw new ArgumentOutOfRangeException(nameof(l)),
    };

    public static string LangDisplay(Language l) => l switch {
        Language.Csharp => ".NET",
        Language.Python => "Python",
        Language.Cpp    => "C/C++",
        _ => throw new ArgumentOutOfRangeException(nameof(l)),
    };

    public static string FenceLang(Language l) => l switch {
        Language.Csharp => "csharp",
        Language.Python => "python",
        Language.Cpp    => "cpp",
        _ => throw new ArgumentOutOfRangeException(nameof(l)),
    };

    public static void WritePackage(string outRoot, AssemblyModel a, Language lang, string version) {
        var langRoot = Path.Combine(outRoot, LangFolder(lang));
        Directory.CreateDirectory(langRoot);

        if (a.Types.Count == 0) {
            File.WriteAllText(Path.Combine(langRoot, a.Name + ".mdx"), RenderEmptyPackage(a));
            return;
        }

        var folder = Path.Combine(langRoot, a.Name);
        Directory.CreateDirectory(folder);

        var label = a.Name.StartsWith("GHIElectronics.") ? a.Name["GHIElectronics.".Length..] : a.Name;
        File.WriteAllText(Path.Combine(folder, "_category_.json"),
            JsonSerializer.Serialize(new { label }, new JsonSerializerOptions { WriteIndented = true }));

        var fileOf = AssignFilenames(a.Types);

        var nestedBy = a.Types
            .Where(t => t.SidebarPath.Contains('.'))
            .GroupBy(t => t.SidebarPath[..t.SidebarPath.LastIndexOf('.')])
            .ToDictionary(g => g.Key, g => g.OrderBy(x => x.SidebarPath, StringComparer.Ordinal).ToList());

        WritePackageIndex(folder, a, fileOf);
        foreach (var t in a.Types) {
            nestedBy.TryGetValue(t.SidebarPath, out var children);
            File.WriteAllText(Path.Combine(folder, fileOf[t] + ".mdx"), RenderType(a, t, lang, children, fileOf));
        }
    }

    static string RenderEmptyPackage(AssemblyModel a) {
        var label = a.Name.StartsWith("GHIElectronics.") ? a.Name["GHIElectronics.".Length..] : a.Name;
        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine($"title: {Yaml(a.Name)}");
        L.AppendLine("hide_title: true");
        L.AppendLine($"sidebar_label: {Yaml(label)}");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine($"<h1 className=\"api-package-heading\">{a.Name}</h1>");
        L.AppendLine();
        if (!string.IsNullOrWhiteSpace(a.Description)) L.AppendLine(Prose(a.Description!));
        return L.ToString();
    }

    // Per-language overview page for api-reference/<lang>/index.mdx. Lists the
    // packages visible in this language. Called once per language.
    public static void WriteLanguageIndex(string outRoot, Language lang, List<AssemblyModel> model) {
        var langRoot = Path.Combine(outRoot, LangFolder(lang));
        Directory.CreateDirectory(langRoot);

        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine($"title: {Yaml("API Reference (" + LangDisplay(lang) + ")")}");
        L.AppendLine("sidebar_label: Overview");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine($"# {LangDisplay(lang)} API Reference");
        L.AppendLine();
        L.AppendLine(lang switch {
            Language.Csharp => "Endpoint on **.NET**: standard `System.Device.*` and .NET IoT APIs, plus the libraries below for hardware features .NET does not cover.",
            Language.Python => "Endpoint on **Python**: the same libraries as .NET, with identical class and method names, so code reads the same between the two.",
            Language.Cpp    => "Endpoint on **C/C++**: the same libraries as .NET and Python, with identical class and method names, exposed as a C++23 header library.",
            _ => "",
        });
        L.AppendLine();
        L.AppendLine("## Standard .NET");
        L.AppendLine();
        L.AppendLine("- [.NET API](https://learn.microsoft.com/en-gb/dotnet/api/)");
        L.AppendLine("- [.NET IoT API](https://learn.microsoft.com/en-gb/dotnet/api/?view=iot-dotnet-latest)");
        L.AppendLine();
        L.AppendLine("## Endpoint libraries");
        L.AppendLine();
        L.AppendLine("| Library | Description |");
        L.AppendLine("|---|---|");
        foreach (var a in model) {
            var desc = ProseCell(a.Description);
            var href = a.Types.Count == 0
                ? $"./{Uri.EscapeDataString(a.Name)}.mdx"
                : $"./{Uri.EscapeDataString(a.Name)}/index.mdx";
            L.AppendLine($"| [{a.Name}]({href}) | {desc} |");
        }
        File.WriteAllText(Path.Combine(langRoot, "index.mdx"), L.ToString());
    }

    // Top-level api-reference/index.mdx: a short hub that points at the three
    // per-language trees and sells the fact that the API is the same in all
    // three. Written once, by Program.cs, after each language has been
    // generated.
    public static void WriteHubIndex(string outRoot) {
        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine("title: API Reference");
        L.AppendLine("sidebar_label: Overview");
        L.AppendLine("slug: /endpoint/api-reference");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine("# Endpoint API Reference");
        L.AppendLine();
        L.AppendLine("Endpoint runs **.NET, Python, and C/C++** with the same API. Classes, methods, and properties share the same names in all three languages, so code you read in one language is the code you write in another. Pick your language below.");
        L.AppendLine();
        L.AppendLine("| Language | Reference |");
        L.AppendLine("|---|---|");
        L.AppendLine($"| **.NET (C#)**  | [{LangDisplay(Language.Csharp)} API](./dotnet/index.mdx) |");
        L.AppendLine($"| **Python**     | [{LangDisplay(Language.Python)} API](./python/index.mdx) |");
        L.AppendLine($"| **C/C++**      | [{LangDisplay(Language.Cpp)} API](./cpp/index.mdx)    |");
        L.AppendLine();
        L.AppendLine("Where a standard .NET API exists (`System.Device.Gpio`, `System.Device.I2c`, …) Endpoint uses it as-is on .NET and mirrors the same class and method names in Python and C/C++, so the three references stay aligned. A handful of domains where a language has a long-standing library its developers already use (serial ports in Python, for instance) follow that convention instead.");
        File.WriteAllText(Path.Combine(outRoot, "index.mdx"), L.ToString());
    }

    static void WritePackageIndex(string folder, AssemblyModel a, IReadOnlyDictionary<TypeModel, string> fileOf) {
        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine($"title: {Yaml(a.Name)}");
        L.AppendLine("hide_title: true");
        L.AppendLine("sidebar_label: Overview");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine($"<h1 className=\"api-package-heading\">{a.Name}</h1>");
        L.AppendLine();
        if (!string.IsNullOrWhiteSpace(a.Description)) L.AppendLine(Prose(a.Description!)).AppendLine();

        var topLevel = a.Types.Where(t => !t.SidebarPath.Contains('.')).ToList();

        var sections = new (string Head, string Singular, TypeKind Kind)[] {
            ("Classes",    "Class",     TypeKind.Class),
            ("Structs",    "Struct",    TypeKind.Struct),
            ("Interfaces", "Interface", TypeKind.Interface),
            ("Enums",      "Enum",      TypeKind.Enum),
            ("Delegates",  "Delegate",  TypeKind.Delegate),
        };
        foreach (var (head, singular, kind) in sections) {
            var group = topLevel.Where(t => t.Kind == kind).OrderBy(t => t.SidebarPath, StringComparer.Ordinal).ToList();
            if (group.Count == 0) continue;
            L.AppendLine($"## {head}").AppendLine();
            L.AppendLine($"| {singular} | Summary |");
            L.AppendLine("|---|---|");
            foreach (var t in group) {
                var link = $"[{Prose(t.SidebarPath)}](./{Uri.EscapeDataString(fileOf[t])}.mdx)";
                L.AppendLine($"| {link} | {ProseCell(t.Summary)} |");
            }
            L.AppendLine();
        }

        File.WriteAllText(Path.Combine(folder, "index.mdx"), L.ToString());
    }

    static string RenderType(AssemblyModel a, TypeModel t, Language lang, List<TypeModel>? nested, IReadOnlyDictionary<TypeModel, string> fileOf) {
        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine($"title: {Yaml(t.SidebarPath + " " + Cap(t.Kind.ToString()))}");
        L.AppendLine($"sidebar_label: {Yaml(t.SidebarPath)}");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine($"# {Prose(t.DisplayName)} {Cap(t.Kind.ToString())}");
        L.AppendLine();
        L.Append("**Package:** `").Append(a.Name).Append("`<br/>**Namespace:** `").Append(t.Namespace).AppendLine("`");
        L.AppendLine();
        L.AppendLine(string.IsNullOrWhiteSpace(t.Summary) ? NoDesc : Prose(t.Summary!));
        L.AppendLine();
        L.Append("```").AppendLine(FenceLang(lang));
        L.AppendLine(TypeHeaderFor(t, lang));
        L.AppendLine("```");
        L.AppendLine();
        if (!string.IsNullOrWhiteSpace(t.Remarks)) {
            L.AppendLine("### Remarks").AppendLine();
            L.AppendLine(Prose(t.Remarks!)).AppendLine();
        }

        if (t.Kind == TypeKind.Enum) {
            L.AppendLine("## Fields").AppendLine();
            var anyDesc = t.EnumMembers.Any(em => !string.IsNullOrWhiteSpace(em.Summary));
            if (anyDesc) {
                L.AppendLine("| Name | Value | Description |");
                L.AppendLine("|---|---|---|");
                foreach (var em in t.EnumMembers) {
                    L.AppendLine($"| `{em.Name}` | {(string.IsNullOrEmpty(em.Value) ? "" : "`" + em.Value + "`")} | {ProseCell(em.Summary)} |");
                }
            } else {
                L.AppendLine("| Name | Value |");
                L.AppendLine("|---|---|");
                foreach (var em in t.EnumMembers) {
                    L.AppendLine($"| `{em.Name}` | {(string.IsNullOrEmpty(em.Value) ? "" : "`" + em.Value + "`")} |");
                }
            }
            L.AppendLine();
            return L.ToString();
        }

        RenderNestedTypesSection(L, nested, fileOf);
        Section(L, "Constructors", t.Constructors, lang);
        Section(L, "Properties",   t.Properties,   lang);
        Section(L, "Methods",      t.Methods,      lang);
        Section(L, "Events",       t.Events,       lang);
        RenderFieldsSection(L, t.Fields, lang);
        return L.ToString();
    }

    static string TypeHeaderFor(TypeModel t, Language lang) => lang switch {
        Language.Csharp => t.CsharpSignature,
        Language.Python => t.PythonSignature,
        Language.Cpp    => t.CppSignature,
        _ => t.CsharpSignature,
    };

    static void RenderNestedTypesSection(StringBuilder L, List<TypeModel>? nested, IReadOnlyDictionary<TypeModel, string> fileOf) {
        if (nested is null || nested.Count == 0) return;
        L.AppendLine("## Nested Types").AppendLine();
        L.AppendLine("| Type | Kind | Summary |");
        L.AppendLine("|---|---|---|");
        foreach (var n in nested) {
            var link = $"[{Prose(n.SidebarPath)}](./{Uri.EscapeDataString(fileOf[n])}.mdx)";
            L.AppendLine($"| {link} | {Cap(n.Kind.ToString())} | {ProseCell(n.Summary)} |");
        }
        L.AppendLine();
    }

    static void Section(StringBuilder L, string heading, IReadOnlyList<MemberModel> items, Language lang) {
        if (items.Count == 0) return;
        L.AppendLine($"## {heading}").AppendLine();
        foreach (var m in items) RenderMember(L, m, lang);
    }

    static void RenderFieldsSection(StringBuilder L, IReadOnlyList<MemberModel> fields, Language lang) {
        if (fields.Count == 0) return;
        L.AppendLine("## Fields").AppendLine();
        var documented = fields.Where(f => !string.IsNullOrWhiteSpace(f.Summary)).ToList();
        var undocumented = fields.Where(f => string.IsNullOrWhiteSpace(f.Summary)).ToList();

        foreach (var m in documented) RenderMember(L, m, lang);

        if (undocumented.Count > 0) {
            if (documented.Count > 0) L.AppendLine("### Other fields").AppendLine();
            L.AppendLine("| Name | Type |");
            L.AppendLine("|---|---|");
            foreach (var f in undocumented) {
                L.AppendLine($"| `{f.Name}` | `{f.ReturnTypeDisplay}` |");
            }
            L.AppendLine();
        }
    }

    static void RenderMember(StringBuilder L, MemberModel m, Language lang) {
        L.AppendLine($"### {Prose(m.DisplayName)}").AppendLine();
        if (m.Obsolete) {
            L.Append("> ⚠️ **Obsolete.** ")
             .AppendLine(string.IsNullOrWhiteSpace(m.ObsoleteMessage) ? "" : ProseCell(m.ObsoleteMessage))
             .AppendLine();
        }
        L.AppendLine(SignatureBlock(m, lang));
        L.AppendLine();
        if (!string.IsNullOrWhiteSpace(m.Summary)) {
            L.AppendLine(Prose(m.Summary!));
            L.AppendLine();
        }

        var hasParamDocs = m.Parameters.Any(p => !string.IsNullOrWhiteSpace(p.Description));
        if (m.Parameters.Count > 0 && hasParamDocs) {
            L.AppendLine("| Parameter | Type | Description |");
            L.AppendLine("|---|---|---|");
            foreach (var p in m.Parameters) {
                L.AppendLine($"| `{p.Name}` | `{p.TypeDisplay}` | {ProseCell(p.Description)} |");
            }
            L.AppendLine();
        }

        if ((m.Kind == MemberKind.Method || m.Kind == MemberKind.Property) &&
            m.ReturnTypeDisplay is { Length: > 0 } rt && rt != "void") {
            L.Append("**Returns** `").Append(rt).Append('`');
            if (!string.IsNullOrWhiteSpace(m.Returns)) L.Append(": ").Append(Prose(m.Returns!));
            L.AppendLine().AppendLine();
        }
    }

    static string SignatureBlock(MemberModel m, Language lang) {
        var sig = lang switch {
            Language.Csharp => m.CsharpSignature,
            Language.Python => m.PythonSignature,
            Language.Cpp    => m.CppSignature,
            _ => m.CsharpSignature,
        };
        return "```" + FenceLang(lang) + "\n" + sig + "\n```";
    }

    static Dictionary<TypeModel, string> AssignFilenames(List<TypeModel> types) {
        var used = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var map  = new Dictionary<TypeModel, string>();
        foreach (var t in types) {
            var baseName = t.SidebarPath.Replace('.', '_');
            var name = baseName;
            var n = 2;
            while (!used.Add(name)) name = $"{baseName}_{n++}";
            map[t] = name;
        }
        return map;
    }

    // ─────────────────────────────── MDX escaping helpers ───────────────────
    public static string Prose(string s) {
        if (string.IsNullOrEmpty(s)) return "";
        var parts = SplitInlineCode(s);
        var sb = new StringBuilder();
        foreach (var (text, isCode) in parts) {
            if (isCode) sb.Append(text);
            else sb.Append(text.Replace("<", "&lt;").Replace("{", "&#123;").Replace("}", "&#125;"));
        }
        var result = sb.ToString();
        if (result.Contains('—')) {
            Console.Error.WriteLine($"[gen] WARNING: em-dash (—) found in doc comment, stripping. Fix the source /// comment. Context: \"{Preview(result)}\"");
            result = result.Replace(" — ", ": ").Replace('—', ',');
        }
        return result;
    }

    static string Preview(string s) =>
        s.Length <= 80 ? s : s[..80] + "...";

    public static string ProseCell(string? s) => Prose(s ?? "").Replace("|", "\\|").Replace("\n", " ");

    static IEnumerable<(string text, bool isCode)> SplitInlineCode(string s) {
        var start = 0;
        for (var i = 0; i < s.Length; i++) {
            if (s[i] != '`') continue;
            var end = s.IndexOf('`', i + 1);
            if (end < 0) break;
            if (i > start) yield return (s[start..i], false);
            yield return (s[i..(end + 1)], true);
            start = end + 1;
            i = end;
        }
        if (start < s.Length) yield return (s[start..], false);
    }

    public static string Yaml(string s) =>
        "\"" + s.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";

    public static string Cap(string s) =>
        string.IsNullOrEmpty(s) ? s : char.ToUpperInvariant(s[0]) + s[1..].ToLowerInvariant();
}
