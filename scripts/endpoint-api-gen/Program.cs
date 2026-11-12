using System.Reflection;
using EndpointApiGen;

// Endpoint API docs generator. Reads built GHIElectronics.Endpoint.*.dll files
// (together with their compiler-emitted .xml docs), and emits Docusaurus MDX
// into docs/endpoint/api-reference/, one folder per NuGet. Each type page has csharp /
// python / c++ language tabs synthesized from the .NET metadata, matching the
// three-language-mirror design.

var args_ = ParseArgs(args);

if (args_.ShowHelp) {
    Console.WriteLine("""
        endpoint-api-gen --libs <path-to-dll-root> --out <path-to-docs/endpoint/api-reference> [--version 0.4.0]

        <path-to-dll-root>  is scanned recursively for GHIElectronics.Endpoint.*.dll
                            plus a matching .xml next to each one.
        <path-to-docs/endpoint/api-reference>  is cleaned and rewritten.
        """);
    return 0;
}

var libsRoot = args_.LibsRoot ?? throw new ArgumentException("--libs is required");
var outRoot  = args_.OutRoot  ?? throw new ArgumentException("--out is required");
var version  = args_.Version  ?? "0.4.0";

Console.WriteLine($"[gen] libs: {libsRoot}");
Console.WriteLine($"[gen] out:  {outRoot}");

// Packages intentionally hidden from the docs (not ready for v0.4.0 yet).
// Remove entries from this set to re-enable; nothing else needs to change.
var skipAssemblies = new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
    "GHIElectronics.Endpoint.Devices.DigitalSignal",
    "GHIElectronics.Endpoint.Update",
};

// Packages that intentionally exist only on .NET and are deliberately NOT
// mirrored in Python or C/C++ (USB-device class drivers in particular are
// .NET-only today). They appear in the .NET tree but are hidden from the
// Python and C/C++ trees.
var dotnetOnlyAssemblies = new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
    "GHIElectronics.Endpoint.Devices.Usb",
};

// Individual top-level types intentionally hidden from the docs (and all
// their nested types). Matched against the type's outermost enclosing class
// name, e.g. "EPN256" hides EPN256, EPN256.Adc, EPN256.Gpio.Driver, etc.
// EPN256 and EPN128 are working names for unreleased modules; remove these
// entries once the chips ship.
var skipTopLevelTypes = new HashSet<string>(StringComparer.Ordinal) {
    "EPN256",
    "EPN128",
};

// Discover DLLs: skip bin\Debug\...\ref\ and anything inside obj\
var dllPaths = Directory.EnumerateFiles(libsRoot, "GHIElectronics.Endpoint.*.dll", SearchOption.AllDirectories)
    .Where(p => !p.Contains(Path.DirectorySeparatorChar + "obj" + Path.DirectorySeparatorChar))
    .Where(p => !p.Contains(Path.DirectorySeparatorChar + "ref" + Path.DirectorySeparatorChar))
    .Where(p => !skipAssemblies.Contains(Path.GetFileNameWithoutExtension(p)))
    // Deduplicate by assembly name (pick the first one found per name)
    .GroupBy(p => Path.GetFileNameWithoutExtension(p))
    .Select(g => g.First())
    .OrderBy(p => Path.GetFileName(p))
    .ToList();

if (dllPaths.Count == 0) {
    Console.Error.WriteLine($"[gen] no GHIElectronics.Endpoint.*.dll under {libsRoot}");
    return 1;
}

Console.WriteLine($"[gen] found {dllPaths.Count} assemblies:");
foreach (var p in dllPaths) Console.WriteLine($"       {Path.GetFileName(p)}");

using var loader = new Loader(dllPaths);

var model = new List<AssemblyModel>();
foreach (var asm in loader.LoadAll(dllPaths)) {
    var docs = loader.DocsFor(asm);
    var am = BuildAssemblyModel(asm, docs, version, skipTopLevelTypes);
    if (am != null) model.Add(am);
}

model = model.OrderBy(a => a.Name, StringComparer.Ordinal).ToList();

// Write out
if (Directory.Exists(outRoot)) {
    // Preserve nothing; the full tree is regenerated. Retry a few times to
    // defeat Windows file watchers (VS Code, Docusaurus dev server).
    for (var i = 0; ; i++) {
        try { Directory.Delete(outRoot, recursive: true); break; }
        catch when (i < 5) { Thread.Sleep(400); }
    }
}
Directory.CreateDirectory(outRoot);

foreach (var lang in new[] { Language.Csharp, Language.Python, Language.Cpp }) {
    var visible = (lang == Language.Csharp)
        ? model
        : model.Where(a => !dotnetOnlyAssemblies.Contains(a.Name)).ToList();
    foreach (var a in visible) {
        Writer.WritePackage(outRoot, a, lang, version);
    }
    Writer.WriteLanguageIndex(outRoot, lang, visible);
}
Writer.WriteHubIndex(outRoot);

var typeCount = model.Sum(a => a.Types.Count);
var memCount  = model.Sum(a => a.Types.Sum(t => t.Constructors.Count + t.Properties.Count + t.Methods.Count + t.Events.Count + t.Fields.Count + t.EnumMembers.Count));
var docd      = model.Sum(a => a.Types.Count(t => !string.IsNullOrWhiteSpace(t.Summary)));
Console.WriteLine($"[gen] wrote {typeCount} type pages ({docd} with a <summary>) and {memCount} members across {model.Count} packages → {outRoot}");
return 0;

// ──────────────────────────────────────────────────────────────────────────
static AssemblyModel? BuildAssemblyModel(Assembly a, XmlDocReader? docs, string version, HashSet<string> skipTopLevelTypes) {
    var name = a.GetName().Name;
    if (name == null || !name.StartsWith("GHIElectronics.Endpoint", StringComparison.Ordinal)) return null;

    var asmVersion = a.GetName().Version?.ToString();
    var am = new AssemblyModel {
        Name = name,
        Version = !string.IsNullOrEmpty(asmVersion) && asmVersion != "0.0.0.0" ? asmVersion : version,
        Description = DescriptionOf(a),
    };

    foreach (var t in a.GetTypes()) {
        if (!IsPublicApiType(t)) continue;
        if (skipTopLevelTypes.Contains(OutermostName(t))) continue;
        var tm = BuildTypeModel(t, docs);
        am.Types.Add(tm);
    }
    am.Types.Sort((x, y) => string.CompareOrdinal(x.Name, y.Name));
    return am;
}

// Name of the outermost enclosing type: "EPN256" for EPN256.Gpio.Driver, etc.
// Used to skip a chip's entire type tree in one entry.
static string OutermostName(Type t) {
    var c = t;
    while (c.DeclaringType is Type d) c = d;
    return c.Name.Split('`')[0];
}

static bool IsPublicApiType(Type t) {
    if (t.IsNested) {
        // A public nested inside an internal enclosing type is unreachable
        // from outside the assembly, so don't document it.
        if (!IsPublicApiType(t.DeclaringType!)) return false;
        return t.IsNestedPublic || t.IsNestedFamily || t.IsNestedFamORAssem;
    }
    return t.IsPublic;
}

static string? DescriptionOf(Assembly a) {
    foreach (var ca in a.GetCustomAttributesData()) {
        if (ca.AttributeType.FullName == "System.Reflection.AssemblyDescriptionAttribute" && ca.ConstructorArguments.Count > 0) {
            var v = ca.ConstructorArguments[0].Value as string;
            if (!string.IsNullOrWhiteSpace(v)) return v;
        }
    }
    return null;
}

static TypeModel BuildTypeModel(Type t, XmlDocReader? docs) {
    var kind = ClassifyKind(t);
    var typeDoc = docs?.ForType(t);
    var tm = new TypeModel {
        Namespace = t.Namespace ?? "",
        Name = t.Name.Split('`')[0],
        DisplayName = Signatures.Csharp(t),
        SidebarPath = SidebarPathOf(t),
        Kind = kind,
        CsharpSignature = Signatures.CsharpTypeHeader(t),
        PythonSignature = Signatures.PythonTypeHeader(t),
        CppSignature    = Signatures.CppTypeHeader(t),
        Summary = Xml.Summary(typeDoc),
        Remarks = Xml.Remarks(typeDoc),
    };

    if (kind == TypeKind.Enum) {
        var underlying = Enum.GetUnderlyingType(t);
        foreach (var f in t.GetFields(BindingFlags.Public | BindingFlags.Static).OrderBy(f => f.MetadataToken)) {
            var em = new EnumMemberModel {
                Name = f.Name,
                Value = f.GetRawConstantValue()?.ToString() ?? "",
                Summary = Xml.Summary(docs?.ForField(f)),
            };
            tm.EnumMembers.Add(em);
        }
        return tm;
    }

    // Delegate: the type-level summary + signature already shows the Invoke
    // sig; skip the compiler-synthesized Invoke / BeginInvoke / EndInvoke
    // members entirely so they don't fill the page with "No description".
    if (kind == TypeKind.Delegate) return tm;

    const BindingFlags BF = BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;

    foreach (var c in t.GetConstructors(BF)) {
        if (!IsPublicApiMethod(c)) continue;
        tm.Constructors.Add(BuildMember(c, MemberKind.Constructor, docs));
    }
    foreach (var p in t.GetProperties(BF)) {
        if (!IsPublicApiProperty(p)) continue;
        tm.Properties.Add(BuildPropertyMember(p, docs));
    }
    foreach (var m in t.GetMethods(BF)) {
        if (!IsPublicApiMethod(m)) continue;
        if (m.IsSpecialName) continue;   // property / event accessors
        tm.Methods.Add(BuildMember(m, MemberKind.Method, docs));
    }
    foreach (var e in t.GetEvents(BF)) {
        if (!IsPublicApiEvent(e)) continue;
        tm.Events.Add(BuildEventMember(e, docs));
    }
    foreach (var f in t.GetFields(BF)) {
        if (!IsPublicApiField(f)) continue;
        tm.Fields.Add(BuildFieldMember(f, docs));
    }
    tm.Methods.Sort((a, b) => string.CompareOrdinal(a.Name, b.Name));
    tm.Properties.Sort((a, b) => string.CompareOrdinal(a.Name, b.Name));
    tm.Events.Sort((a, b) => string.CompareOrdinal(a.Name, b.Name));
    tm.Fields.Sort((a, b) => string.CompareOrdinal(a.Name, b.Name));
    return tm;
}

// Full type path for the sidebar label. For nested types we join the parent
// chain so EPM815.Gpio.Driver and EPN256.Gpio.Driver don't both display as
// just "Driver" (same for Can, Pin, Pull, SerialPort, etc.).
static string SidebarPathOf(Type t) {
    var stack = new Stack<string>();
    for (var c = t; c != null; c = c.DeclaringType) {
        stack.Push(c.Name.Split('`')[0]);
    }
    return string.Join(".", stack);
}

static TypeKind ClassifyKind(Type t) {
    if (t.IsEnum) return TypeKind.Enum;
    if (t.IsInterface) return TypeKind.Interface;
    // Compare by FullName, because MetadataLoadContext types are distinct from the
    // host runtime's typeof(MulticastDelegate), so IsAssignableFrom fails.
    for (var b = t.BaseType; b != null; b = b.BaseType) {
        if (b.FullName == "System.MulticastDelegate") return TypeKind.Delegate;
        if (b.FullName == "System.Delegate") return TypeKind.Delegate;
    }
    if (t.IsValueType) return TypeKind.Struct;
    return TypeKind.Class;
}

static bool IsPublicApiMethod(MethodBase m) => m.IsPublic || m.IsFamily || m.IsFamilyOrAssembly;
static bool IsPublicApiProperty(PropertyInfo p) {
    var a = p.GetMethod ?? p.SetMethod;
    return a != null && IsPublicApiMethod(a);
}
static bool IsPublicApiEvent(EventInfo e) {
    var a = e.AddMethod;
    return a != null && IsPublicApiMethod(a);
}
static bool IsPublicApiField(FieldInfo f) => f.IsPublic || f.IsFamily || f.IsFamilyOrAssembly;

static MemberModel BuildMember(MethodBase m, MemberKind kind, XmlDocReader? docs) {
    var doc = docs?.ForMethod(m);
    var ps = m.GetParameters().Select(p => new ParamModel {
        Name = p.Name ?? "",
        TypeDisplay = Signatures.Csharp(p.ParameterType),
        Description = Xml.ParamText(doc, p.Name ?? ""),
    }).ToList();
    var mm = new MemberModel {
        Kind = kind,
        Name = m is ConstructorInfo ? m.DeclaringType!.Name.Split('`')[0] : m.Name,
        DisplayName = DisplayFor(m),
        CsharpSignature = Signatures.CsharpMethod(m),
        PythonSignature = Signatures.PythonMethod(m),
        CppSignature = Signatures.CppMethod(m),
        Summary = Xml.Summary(doc),
        Returns = Xml.Returns(doc),
        ReturnTypeDisplay = m is MethodInfo mi && mi.ReturnType != typeof(void)
            ? Signatures.Csharp(mi.ReturnType)
            : null,
        Obsolete = IsObsolete(m, out var reason),
        ObsoleteMessage = reason,
    };
    mm.Parameters.AddRange(ps);
    return mm;
}

static MemberModel BuildPropertyMember(PropertyInfo p, XmlDocReader? docs) {
    var doc = docs?.ForProperty(p);
    return new MemberModel {
        Kind = MemberKind.Property,
        Name = p.Name,
        DisplayName = p.Name,
        CsharpSignature = Signatures.CsharpProperty(p),
        PythonSignature = Signatures.PythonProperty(p),
        CppSignature = Signatures.CppProperty(p),
        Summary = Xml.Summary(doc),
        Returns = null,
        ReturnTypeDisplay = Signatures.Csharp(p.PropertyType),
        Obsolete = IsObsolete(p, out var reason),
        ObsoleteMessage = reason,
    };
}

static MemberModel BuildEventMember(EventInfo e, XmlDocReader? docs) {
    var doc = docs?.ForEvent(e);
    return new MemberModel {
        Kind = MemberKind.Event,
        Name = e.Name,
        DisplayName = e.Name,
        CsharpSignature = Signatures.CsharpEvent(e),
        PythonSignature = Signatures.PythonEvent(e),
        CppSignature = Signatures.CppEvent(e),
        Summary = Xml.Summary(doc),
        Returns = null,
        ReturnTypeDisplay = Signatures.Csharp(e.EventHandlerType!),
        Obsolete = IsObsolete(e, out var reason),
        ObsoleteMessage = reason,
    };
}

static MemberModel BuildFieldMember(FieldInfo f, XmlDocReader? docs) {
    var doc = docs?.ForField(f);
    return new MemberModel {
        Kind = f.IsLiteral ? MemberKind.Constant : MemberKind.Field,
        Name = f.Name,
        DisplayName = f.Name,
        CsharpSignature = Signatures.CsharpField(f),
        PythonSignature = Signatures.PythonField(f),
        CppSignature = Signatures.CppField(f),
        Summary = Xml.Summary(doc),
        Returns = null,
        ReturnTypeDisplay = Signatures.Csharp(f.FieldType),
        Obsolete = IsObsolete(f, out var reason),
        ObsoleteMessage = reason,
    };
}

static string DisplayFor(MethodBase m) {
    var name = m is ConstructorInfo ? m.DeclaringType!.Name.Split('`')[0] : m.Name;
    var ps = m.GetParameters();
    if (ps.Length == 0) return name + "()";
    return name + "(" + string.Join(", ", ps.Select(p => $"{Signatures.Csharp(p.ParameterType)} {p.Name}")) + ")";
}

static bool IsObsolete(MemberInfo m, out string? reason) {
    reason = null;
    foreach (var ca in m.GetCustomAttributesData()) {
        if (ca.AttributeType.FullName == "System.ObsoleteAttribute") {
            if (ca.ConstructorArguments.Count > 0) reason = ca.ConstructorArguments[0].Value as string;
            return true;
        }
    }
    return false;
}

static Args ParseArgs(string[] argv) {
    var a = new Args();
    for (var i = 0; i < argv.Length; i++) {
        var cur = argv[i];
        if (cur is "--help" or "-h" or "/?") a.ShowHelp = true;
        else if (cur == "--libs" && i + 1 < argv.Length) a.LibsRoot = argv[++i];
        else if (cur == "--out"  && i + 1 < argv.Length) a.OutRoot  = argv[++i];
        else if (cur == "--version" && i + 1 < argv.Length) a.Version = argv[++i];
    }
    return a;
}

sealed class Args {
    public string? LibsRoot;
    public string? OutRoot;
    public string? Version;
    public bool ShowHelp;
}
