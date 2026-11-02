using System.Text;
using System.Text.Json;

namespace EndpointApiGen;

// Writes Docusaurus MDX for one package: an index.mdx with linked tables of
// types grouped by kind, a _category_.json for sidebar label, and one Type.mdx
// per public type. Each type page has csharp / python / cpp language tabs
// (both for the install snippet at the top and for the signature of every
// member).

public static class Writer {

    const string NoDesc = "_No description available._";

    public static void WritePackage(string outRoot, AssemblyModel a, string version) {
        // Packages with no public types (e.g. GHIElectronics.Endpoint.Devices.Can,
        // which only exists to pull in .NET IoT's CanRaw) are rendered as a
        // single top-level .mdx — a stray folder with only "Overview" inside
        // reads badly in the sidebar.
        if (a.Types.Count == 0) {
            File.WriteAllText(Path.Combine(outRoot, a.Name + ".mdx"), RenderEmptyPackage(a));
            return;
        }

        var folder = Path.Combine(outRoot, a.Name);
        Directory.CreateDirectory(folder);

        // _category_.json — label stripped of "GHIElectronics." for a tidier sidebar
        var label = a.Name.StartsWith("GHIElectronics.") ? a.Name["GHIElectronics.".Length..] : a.Name;
        File.WriteAllText(Path.Combine(folder, "_category_.json"),
            JsonSerializer.Serialize(new { label }, new JsonSerializerOptions { WriteIndented = true }));

        // Per-type unique filenames (duplicate type names across namespaces are
        // rare in Endpoint but we still guard with a numeric suffix).
        var fileOf = AssignFilenames(a.Types);

        // Pre-compute parent → children map, so each type's page can list its
        // nested types in a section with correct links.
        var nestedBy = a.Types
            .Where(t => t.SidebarPath.Contains('.'))
            .GroupBy(t => t.SidebarPath[..t.SidebarPath.LastIndexOf('.')])
            .ToDictionary(g => g.Key, g => g.OrderBy(x => x.SidebarPath, StringComparer.Ordinal).ToList());

        WritePackageIndex(folder, a, version, fileOf);
        foreach (var t in a.Types) {
            nestedBy.TryGetValue(t.SidebarPath, out var children);
            File.WriteAllText(Path.Combine(folder, fileOf[t] + ".mdx"), RenderType(a, t, version, children, fileOf));
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

    public static void WriteTopIndex(string outRoot, List<AssemblyModel> model) {
        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine("title: API Reference");
        L.AppendLine("sidebar_label: Overview");
        L.AppendLine("slug: /endpoint/api");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine("# Endpoint API Reference");
        L.AppendLine();
        L.AppendLine("Endpoint uses the standard .NET APIs wherever they exist, and adds the libraries below for hardware features .NET does not cover. Every library has three parallel bindings — **.NET** (NuGet), **Python** (pip) and **C/C++** (header). The API names match character-for-character across the three languages.");
        L.AppendLine();
        L.AppendLine("## Standard .NET");
        L.AppendLine();
        L.AppendLine("- [.NET API](https://learn.microsoft.com/en-gb/dotnet/api/)");
        L.AppendLine("- [.NET IoT API](https://learn.microsoft.com/en-gb/dotnet/api/?view=iot-dotnet-latest)");
        L.AppendLine();
        L.AppendLine("## Standard device APIs");
        L.AppendLine();
        L.AppendLine(".NET's device APIs (GPIO, I²C, SPI, PWM, serial) are standard — Microsoft documents them in the links above and the C# code looks the same on any board. Python and C/C++ have no equivalent standard, so Endpoint ships wrapper packages with the SAME names and shape as the .NET API. Install the wrapper for your language; the member names (`GpioController`, `OpenPin`, `Write`, …) are identical.");
        L.AppendLine();
        L.AppendLine("| API | .NET | Python | C/C++ |");
        L.AppendLine("|---|---|---|---|");
        L.AppendLine("| GPIO | [`System.Device.Gpio`](https://learn.microsoft.com/en-us/dotnet/api/system.device.gpio) | `pip install GHIElectronics.Endpoint.Devices.Gpio` | `#include <endpoint.h>` → `GHIElectronics::Endpoint::Devices::Gpio` |");
        L.AppendLine("| I²C | [`System.Device.I2c`](https://learn.microsoft.com/en-us/dotnet/api/system.device.i2c) | `pip install GHIElectronics.Endpoint.Devices.I2c` | `#include <endpoint.h>` → `GHIElectronics::Endpoint::Devices::I2c` |");
        L.AppendLine("| SPI | [`System.Device.Spi`](https://learn.microsoft.com/en-us/dotnet/api/system.device.spi) | `pip install GHIElectronics.Endpoint.Devices.Spi` | `#include <endpoint.h>` → `GHIElectronics::Endpoint::Devices::Spi` |");
        L.AppendLine("| PWM | [`System.Device.Pwm`](https://learn.microsoft.com/en-us/dotnet/api/system.device.pwm) | `pip install GHIElectronics.Endpoint.Devices.Pwm` | `#include <endpoint.h>` → `GHIElectronics::Endpoint::Devices::Pwm` |");
        L.AppendLine("| Serial port | [`System.IO.Ports.SerialPort`](https://learn.microsoft.com/en-us/dotnet/api/system.io.ports.serialport) | `pip install pyserial` *(Python-native; use its `serial.Serial` API)* | `#include <endpoint.h>` → `GHIElectronics::Endpoint::Devices::Ports` |");
        L.AppendLine();
        L.AppendLine(":::note");
        L.AppendLine("For serial, Python has an established ecosystem library — **pyserial** (`import serial`) — so the Endpoint pip package for serial is not shipped. Use pyserial directly; its API is different from .NET's `SerialPort` but it is what Python developers expect.");
        L.AppendLine(":::");
        L.AppendLine();
        L.AppendLine("## Endpoint libraries");
        L.AppendLine();
        L.AppendLine("Hardware features Microsoft's standard .NET APIs do not cover. Every library below is published for all three languages under the same name.");
        L.AppendLine();
        L.AppendLine("| Library | Description |");
        L.AppendLine("|---|---|");
        foreach (var a in model) {
            var desc = ProseCell(a.Description);
            // Empty packages are a single top-level .mdx; others are a folder
            // with an index.mdx. Link accordingly.
            var href = a.Types.Count == 0
                ? $"./{Uri.EscapeDataString(a.Name)}.mdx"
                : $"./{Uri.EscapeDataString(a.Name)}/index.mdx";
            L.AppendLine($"| [{a.Name}]({href}) | {desc} |");
        }
        File.WriteAllText(Path.Combine(outRoot, "index.mdx"), L.ToString());
    }

    static void WritePackageIndex(string folder, AssemblyModel a, string version, IReadOnlyDictionary<TypeModel, string> fileOf) {
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

        // Only top-level types in the package overview. Nested types (e.g.
        // EPM815.Can inside EPM815) show up on their enclosing type's own
        // page under a "Nested Types" section — and in the sidebar — so the
        // overview stays short and surveys the primary API surface.
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

    static string RenderType(AssemblyModel a, TypeModel t, string version, List<TypeModel>? nested, IReadOnlyDictionary<TypeModel, string> fileOf) {
        var L = new StringBuilder();
        L.AppendLine("---");
        L.AppendLine($"title: {Yaml(t.SidebarPath + " " + Cap(t.Kind.ToString()))}");
        L.AppendLine($"sidebar_label: {Yaml(t.SidebarPath)}");
        L.AppendLine("---");
        L.AppendLine();
        L.AppendLine(TabsImport);
        L.AppendLine();
        L.AppendLine($"# {Prose(t.DisplayName)} {Cap(t.Kind.ToString())}");
        L.AppendLine();
        L.Append("**Package:** `").Append(a.Name).Append("`<br/>**Namespace:** `").Append(t.Namespace).AppendLine("`");
        L.AppendLine();
        L.AppendLine(string.IsNullOrWhiteSpace(t.Summary) ? NoDesc : Prose(t.Summary!));
        L.AppendLine();
        L.AppendLine("```csharp");
        L.AppendLine(t.CsharpSignature);
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
        Section(L, "Constructors", t.Constructors);
        Section(L, "Properties",   t.Properties);
        Section(L, "Methods",      t.Methods);
        Section(L, "Events",       t.Events);
        RenderFieldsSection(L, t.Fields);
        return L.ToString();
    }

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

    static void Section(StringBuilder L, string heading, IReadOnlyList<MemberModel> items) {
        if (items.Count == 0) return;
        L.AppendLine($"## {heading}").AppendLine();
        foreach (var m in items) RenderMember(L, m);
    }

    // Fields section: documented fields get the full h3 + language-tabs
    // treatment; undocumented ones collapse into a compact table at the
    // bottom. Keeps pages like EPM815.Gpio.Pin (150+ bare constants plus one
    // NONE with a <summary>) readable without hiding the documented members.
    static void RenderFieldsSection(StringBuilder L, IReadOnlyList<MemberModel> fields) {
        if (fields.Count == 0) return;
        L.AppendLine("## Fields").AppendLine();
        var documented = fields.Where(f => !string.IsNullOrWhiteSpace(f.Summary)).ToList();
        var undocumented = fields.Where(f => string.IsNullOrWhiteSpace(f.Summary)).ToList();

        foreach (var m in documented) RenderMember(L, m);

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

    static void RenderMember(StringBuilder L, MemberModel m) {
        L.AppendLine($"### {Prose(m.DisplayName)}").AppendLine();
        if (m.Obsolete) {
            L.Append("> ⚠️ **Obsolete.** ")
             .AppendLine(string.IsNullOrWhiteSpace(m.ObsoleteMessage) ? "" : ProseCell(m.ObsoleteMessage))
             .AppendLine();
        }
        L.AppendLine(SignatureTabs(m));
        L.AppendLine();
        // No noisy "No description available." placeholder — if the summary
        // is empty, just show the signature and move on.
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
            if (!string.IsNullOrWhiteSpace(m.Returns)) L.Append(" — ").Append(Prose(m.Returns!));
            L.AppendLine().AppendLine();
        }
    }

    static string SignatureTabs(MemberModel m) {
        var sb = new StringBuilder();
        sb.AppendLine("<Tabs groupId=\"endpoint-lang\">");
        sb.AppendLine("<TabItem value=\"csharp\" label=\"C#\">").AppendLine();
        sb.AppendLine("```csharp").AppendLine(m.CsharpSignature).AppendLine("```").AppendLine();
        sb.AppendLine("</TabItem>").AppendLine("<TabItem value=\"python\" label=\"Python\">").AppendLine();
        sb.AppendLine("```python").AppendLine(m.PythonSignature).AppendLine("```").AppendLine();
        sb.AppendLine("</TabItem>").AppendLine("<TabItem value=\"cpp\" label=\"C/C++\">").AppendLine();
        sb.AppendLine("```cpp").AppendLine(m.CppSignature).AppendLine("```").AppendLine();
        sb.AppendLine("</TabItem>").Append("</Tabs>");
        return sb.ToString();
    }

    const string TabsImport = "import Tabs from '@theme/Tabs';\nimport TabItem from '@theme/TabItem';";

    static Dictionary<TypeModel, string> AssignFilenames(List<TypeModel> types) {
        // SidebarPath disambiguates nested types that share a leaf name
        // (EPM815.Can vs EPN256.Can). Use "_" to separate for file-system
        // friendliness, falling back to a numeric suffix if even that collides.
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
    // Prose: escape `<` and `{` outside of inline-code spans so MDX doesn't try
    // to interpret them as JSX. Inline code (`…`) passes through untouched.
    public static string Prose(string s) {
        if (string.IsNullOrEmpty(s)) return "";
        var parts = SplitInlineCode(s);
        var sb = new StringBuilder();
        foreach (var (text, isCode) in parts) {
            if (isCode) sb.Append(text);
            else sb.Append(text.Replace("<", "&lt;").Replace("{", "&#123;").Replace("}", "&#125;"));
        }
        return sb.ToString();
    }

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
