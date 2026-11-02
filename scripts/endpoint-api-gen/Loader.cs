using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Xml.Linq;

namespace EndpointApiGen;

// Loads a set of GHIElectronics.Endpoint.* DLLs with MetadataLoadContext so we
// can inspect them with full reflection without actually executing any of their
// code (and without needing their native dependencies to be present).

public sealed class Loader : IDisposable {
    readonly MetadataLoadContext mlc;
    readonly Dictionary<string, XmlDocReader> xmlDocs = new();   // key: assembly simple name

    public Loader(IEnumerable<string> assemblyPaths) {
        // MetadataLoadContext needs a resolver that can find every referenced
        // assembly. We give it:
        //   1. the Endpoint DLLs the caller passed,
        //   2. the current runtime's shared framework (System.*, mscorlib),
        //   3. any sibling DLLs the Endpoint projects dropped into their
        //      bin\Debug\...\ folders when they built — System.Device.Gpio
        //      and similar NuGet references land there.
        var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment(), "*.dll");

        // Collect sibling DLLs from every unique directory the user's DLL
        // paths live in. Overlaps are fine — PathAssemblyResolver dedupes.
        var siblingDirs = assemblyPaths.Select(p => Path.GetDirectoryName(p)!).Distinct();
        var siblings = siblingDirs.SelectMany(d => Directory.GetFiles(d, "*.dll"));

        // NuGet packages (System.Device.Gpio etc.) are not next to the project
        // DLLs — they stay in ~/.nuget/packages. Read each project's deps.json
        // and pull in every runtime assembly listed there.
        var nugetAssemblies = assemblyPaths
            .Select(p => Path.ChangeExtension(p, ".deps.json"))
            .Where(File.Exists)
            .SelectMany(ResolveDepsJsonAssemblies);

        var all = assemblyPaths.Concat(siblings).Concat(nugetAssemblies).Concat(runtimeAssemblies).Distinct().ToArray();
        this.mlc = new MetadataLoadContext(new PathAssemblyResolver(all));

        foreach (var path in assemblyPaths) {
            var xmlPath = Path.ChangeExtension(path, ".xml");
            if (File.Exists(xmlPath)) {
                var reader = new XmlDocReader(XDocument.Load(xmlPath));
                var name = Path.GetFileNameWithoutExtension(path);
                this.xmlDocs[name] = reader;
            }
        }
    }

    public IEnumerable<Assembly> LoadAll(IEnumerable<string> assemblyPaths) {
        foreach (var p in assemblyPaths) {
            Assembly? a = null;
            try { a = this.mlc.LoadFromAssemblyPath(p); }
            catch (Exception ex) {
                Console.Error.WriteLine($"[loader] skip {Path.GetFileName(p)}: {ex.Message}");
            }
            if (a != null) yield return a;
        }
    }

    public XmlDocReader? DocsFor(Assembly a) {
        this.xmlDocs.TryGetValue(a.GetName().Name ?? "", out var r);
        return r;
    }

    static string RuntimeEnvironment() {
        // Where the executing framework's reference assemblies live.
        return Path.GetDirectoryName(typeof(object).Assembly.Location)!;
    }

    static IEnumerable<string> ResolveDepsJsonAssemblies(string depsJsonPath) {
        var nugetRoot = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".nuget", "packages");
        if (!Directory.Exists(nugetRoot)) yield break;

        JsonDocument doc;
        try { doc = JsonDocument.Parse(File.ReadAllText(depsJsonPath)); }
        catch { yield break; }

        using (doc) {
            if (!doc.RootElement.TryGetProperty("libraries", out var libs)) yield break;

            foreach (var lib in libs.EnumerateObject()) {
                // lib.Name is e.g. "System.Device.Gpio/4.2.0"
                if (!lib.Value.TryGetProperty("type", out var type)) continue;
                if (type.GetString() != "package") continue;
                if (!lib.Value.TryGetProperty("path", out var pathProp)) continue;
                var relPath = pathProp.GetString();
                if (string.IsNullOrEmpty(relPath)) continue;

                var pkgDir = Path.Combine(nugetRoot, relPath);
                if (!Directory.Exists(pkgDir)) continue;

                // Prefer net8.0/net9.0/net10.0 → netstandard2.1 → netstandard2.0 → net6/7
                var libDir = Path.Combine(pkgDir, "lib");
                if (!Directory.Exists(libDir)) continue;

                var tfms = Directory.GetDirectories(libDir)
                    .Select(Path.GetFileName)
                    .Where(n => n != null)
                    .OrderByDescending(TfmPriority)
                    .ToArray();
                if (tfms.Length == 0) continue;

                var chosen = Path.Combine(libDir, tfms[0]!);
                foreach (var dll in Directory.GetFiles(chosen, "*.dll")) {
                    yield return dll;
                }
            }
        }
    }

    static int TfmPriority(string? tfm) => tfm switch {
        "net10.0" => 100, "net9.0" => 95, "net8.0" => 90,
        "net7.0" => 70, "net6.0" => 65,
        "netstandard2.1" => 50, "netstandard2.0" => 45,
        _ => 10,
    };

    public void Dispose() => this.mlc.Dispose();
}

// Reads a compiler-emitted XML docs file and resolves XML comments by the
// mangled member key the C# compiler assigns (DocFX uses the same scheme).

public sealed class XmlDocReader {
    readonly Dictionary<string, XElement> byKey;

    public XmlDocReader(XDocument doc) {
        this.byKey = doc.Descendants("member")
            .Where(e => e.Attribute("name") != null)
            .ToDictionary(e => e.Attribute("name")!.Value, e => e);
    }

    public XElement? For(string key) => this.byKey.TryGetValue(key, out var e) ? e : null;

    public XElement? ForType(Type t) => this.For("T:" + Keys.TypeKey(t));
    public XElement? ForField(FieldInfo f) => this.For("F:" + Keys.TypeKey(f.DeclaringType!) + "." + f.Name);
    public XElement? ForProperty(PropertyInfo p) {
        var baseKey = "P:" + Keys.TypeKey(p.DeclaringType!) + "." + p.Name;
        if (p.GetIndexParameters().Length > 0) {
            baseKey += "(" + string.Join(",", p.GetIndexParameters().Select(x => Keys.TypeKey(x.ParameterType))) + ")";
        }
        return this.For(baseKey);
    }
    public XElement? ForEvent(EventInfo e) => this.For("E:" + Keys.TypeKey(e.DeclaringType!) + "." + e.Name);
    public XElement? ForMethod(MethodBase m) {
        var name = m is ConstructorInfo ? "#ctor" : m.Name;
        var key = "M:" + Keys.TypeKey(m.DeclaringType!) + "." + name;
        if (m is MethodInfo mi && mi.IsGenericMethodDefinition) key += "``" + mi.GetGenericArguments().Length;
        var ps = m.GetParameters();
        if (ps.Length > 0) key += "(" + string.Join(",", ps.Select(x => Keys.ParamKey(x.ParameterType))) + ")";
        return this.For(key);
    }
}

// Produces the compiler-style member-key fragments used in the XML docs file.
// See https://learn.microsoft.com/dotnet/csharp/language-reference/xmldoc/.
static class Keys {
    public static string TypeKey(Type t) {
        if (t.IsGenericParameter) {
            // method generic parameter → ``n ; type generic parameter → `n
            var owner = t.DeclaringMethod;
            return (owner != null ? "``" : "`") + t.GenericParameterPosition;
        }
        if (t.IsArray) return TypeKey(t.GetElementType()!) + (t.GetArrayRank() == 1 ? "[]" : "[" + new string(',', t.GetArrayRank() - 1) + "]");
        if (t.IsByRef) return TypeKey(t.GetElementType()!) + "@";
        if (t.IsPointer) return TypeKey(t.GetElementType()!) + "*";

        var full = t.IsNested ? TypeKey(t.DeclaringType!) + "." + t.Name : (t.Namespace is { Length: > 0 } ns ? ns + "." + t.Name : t.Name);
        if (t.IsGenericType) {
            var def = t.GetGenericTypeDefinition();
            var defFull = def.IsNested ? TypeKey(def.DeclaringType!) + "." + def.Name : (def.Namespace is { Length: > 0 } dns ? dns + "." + def.Name : def.Name);
            // Strip the `n arity on parameter keys per compiler convention
            var baseName = defFull.Split('`')[0];
            var args = string.Join(",", t.GetGenericArguments().Select(TypeKey));
            return $"{baseName}{{{args}}}";
        }
        return full;
    }

    public static string ParamKey(Type t) {
        // Parameter positions use the same scheme but with `` for method
        // generic params and ` for type generic params.
        return TypeKey(t);
    }
}
