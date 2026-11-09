using System.Reflection;
using System.Text;

namespace EndpointApiGen;

// Produces human-readable signatures in three languages from reflection types.
// Names stay PascalCase in all three languages (per the Endpoint design: the
// Python and C/C++ APIs mirror the .NET API character-for-character). Only the
// TYPE spellings differ (e.g. int → int → int32_t, string → str → std::string).

public static class Signatures {

    // ─────────────────────────────── Type formatting ────────────────────────

    public static string Csharp(Type t) {
        if (t.IsByRef) return Csharp(t.GetElementType()!);
        if (t.IsArray) return Csharp(t.GetElementType()!) + "[]";
        if (t.IsGenericType) {
            var def = t.GetGenericTypeDefinition();
            var name = def.Name;
            var tick = name.IndexOf('`');
            if (tick >= 0) name = name[..tick];
            // Nullable<T> → T?
            if (def == typeof(Nullable<>)) return Csharp(t.GetGenericArguments()[0]) + "?";
            var args = string.Join(", ", t.GetGenericArguments().Select(Csharp));
            return $"{name}<{args}>";
        }
        return t.FullName switch {
            "System.Void" => "void",
            "System.Boolean" => "bool",
            "System.Byte" => "byte",
            "System.SByte" => "sbyte",
            "System.Int16" => "short",
            "System.UInt16" => "ushort",
            "System.Int32" => "int",
            "System.UInt32" => "uint",
            "System.Int64" => "long",
            "System.UInt64" => "ulong",
            "System.Single" => "float",
            "System.Double" => "double",
            "System.Char" => "char",
            "System.String" => "string",
            "System.Object" => "object",
            "System.IntPtr" => "nint",
            "System.UIntPtr" => "nuint",
            _ => t.Name,
        };
    }

    public static string Python(Type t) {
        if (t.IsByRef) return Python(t.GetElementType()!);
        if (t.IsArray) {
            var el = t.GetElementType()!;
            if (el == typeof(byte)) return "bytes";
            return $"list[{Python(el)}]";
        }
        if (t.IsGenericType) {
            var def = t.GetGenericTypeDefinition();
            if (def == typeof(Nullable<>)) return $"{Python(t.GetGenericArguments()[0])} | None";
            var name = def.Name;
            var tick = name.IndexOf('`');
            if (tick >= 0) name = name[..tick];
            var args = string.Join(", ", t.GetGenericArguments().Select(Python));
            return $"{name}[{args}]";
        }
        return t.FullName switch {
            "System.Void" => "None",
            "System.Boolean" => "bool",
            "System.Byte" => "int",
            "System.SByte" => "int",
            "System.Int16" => "int",
            "System.UInt16" => "int",
            "System.Int32" => "int",
            "System.UInt32" => "int",
            "System.Int64" => "int",
            "System.UInt64" => "int",
            "System.Single" => "float",
            "System.Double" => "float",
            "System.Char" => "str",
            "System.String" => "str",
            "System.Object" => "object",
            "System.IntPtr" => "int",
            "System.UIntPtr" => "int",
            "System.TimeSpan" => "datetime.timedelta",
            "System.DateTime" => "datetime.datetime",
            _ => t.Name,
        };
    }

    public static string Cpp(Type t) {
        if (t.IsByRef) return Cpp(t.GetElementType()!) + "&";
        if (t.IsArray) {
            var el = t.GetElementType()!;
            if (el == typeof(byte)) return "std::vector<uint8_t>";
            return $"std::vector<{Cpp(el)}>";
        }
        if (t.IsGenericType) {
            var def = t.GetGenericTypeDefinition();
            if (def == typeof(Nullable<>)) return $"std::optional<{Cpp(t.GetGenericArguments()[0])}>";
            var name = def.Name;
            var tick = name.IndexOf('`');
            if (tick >= 0) name = name[..tick];
            var args = string.Join(", ", t.GetGenericArguments().Select(Cpp));
            return $"{name}<{args}>";
        }
        return t.FullName switch {
            "System.Void" => "void",
            "System.Boolean" => "bool",
            "System.Byte" => "uint8_t",
            "System.SByte" => "int8_t",
            "System.Int16" => "int16_t",
            "System.UInt16" => "uint16_t",
            "System.Int32" => "int32_t",
            "System.UInt32" => "uint32_t",
            "System.Int64" => "int64_t",
            "System.UInt64" => "uint64_t",
            "System.Single" => "float",
            "System.Double" => "double",
            "System.Char" => "char",
            "System.String" => "std::string",
            "System.Object" => "void*",
            "System.IntPtr" => "intptr_t",
            "System.UIntPtr" => "uintptr_t",
            "System.TimeSpan" => "Core::TimeSpan",
            _ => t.Name,
        };
    }

    // ─────────────────────────────── Member signatures ──────────────────────

    public static string CsharpMethod(MethodBase m, string? propertyAccessors = null) {
        var sb = new StringBuilder();
        sb.Append(AccessibilityOf(m)).Append(' ');
        if (m.IsStatic) sb.Append("static ");
        if (m is MethodInfo mi) {
            if (mi.IsVirtual && !mi.IsFinal && !mi.DeclaringType!.IsInterface) {
                // MetadataLoadContext doesn't support GetBaseDefinition(); use
                // the vtable slot flag instead. IsNewSlot => fresh virtual (or
                // abstract); otherwise it's an override.
                if (!IsNewSlot(mi)) sb.Append("override ");
                else if (mi.IsAbstract) sb.Append("abstract ");
                else sb.Append("virtual ");
            }
            sb.Append(Csharp(mi.ReturnType)).Append(' ');
        }
        var name = m is ConstructorInfo ? m.DeclaringType!.Name.Split('`')[0] : m.Name;
        sb.Append(name);
        if (m is MethodInfo gi && gi.IsGenericMethodDefinition) {
            sb.Append('<').Append(string.Join(", ", gi.GetGenericArguments().Select(a => a.Name))).Append('>');
        }
        sb.Append('(');
        sb.Append(string.Join(", ", m.GetParameters().Select(p => $"{Csharp(p.ParameterType)} {p.Name}")));
        sb.Append(')');
        return sb.ToString();
    }

    public static string PythonMethod(MethodBase m) {
        var sb = new StringBuilder();
        if (m.IsStatic) sb.Append("@staticmethod\n");
        sb.Append("def ");
        var name = m is ConstructorInfo ? "__init__" : m.Name;
        sb.Append(name).Append('(');
        var paramParts = new List<string>();
        if (!m.IsStatic) paramParts.Add("self");
        foreach (var p in m.GetParameters()) {
            paramParts.Add($"{p.Name}: {Python(p.ParameterType)}");
        }
        sb.Append(string.Join(", ", paramParts));
        sb.Append(')');
        if (m is MethodInfo mi && mi.ReturnType != typeof(void)) {
            sb.Append(" -> ").Append(Python(mi.ReturnType));
        }
        sb.Append(':');
        return sb.ToString();
    }

    public static string CppMethod(MethodBase m) {
        var sb = new StringBuilder();
        if (m.IsStatic) sb.Append("static ");
        if (m is MethodInfo mi) {
            if (mi.IsVirtual && !mi.IsFinal) sb.Append("virtual ");
            sb.Append(Cpp(mi.ReturnType)).Append(' ');
        }
        var name = m is ConstructorInfo ? m.DeclaringType!.Name.Split('`')[0] : m.Name;
        sb.Append(name).Append('(');
        sb.Append(string.Join(", ", m.GetParameters().Select(p => {
            var typeName = Cpp(p.ParameterType);
            // Pass managed reference types by const&; primitives by value
            var pass = IsPassByValue(p.ParameterType) ? typeName : $"const {typeName}&";
            return $"{pass} {p.Name}";
        })));
        sb.Append(')');
        if (m is MethodInfo mi2 && mi2.IsVirtual && !mi2.IsFinal && !IsNewSlot(mi2)) sb.Append(" override");
        sb.Append(';');
        return sb.ToString();
    }

    static bool IsNewSlot(MethodInfo mi) => (mi.Attributes & MethodAttributes.NewSlot) != 0;

    static bool IsPassByValue(Type t) =>
        t.IsPrimitive || t.IsEnum || t.IsValueType ||
        t == typeof(IntPtr) || t == typeof(UIntPtr) || t.IsByRef;

    public static string CsharpProperty(PropertyInfo p) {
        var get = p.GetGetMethod() is MethodInfo g;
        var set = p.GetSetMethod() is MethodInfo s;
        var acc = p.GetAccessors(true).FirstOrDefault() ?? throw new InvalidOperationException($"Property {p.Name} has no accessors.");
        var mods = new StringBuilder(AccessibilityOf(acc));
        if (acc.IsStatic) mods.Append(" static");
        var accessors = (get, set) switch {
            (true, true)  => "{ get; set; }",
            (true, false) => "{ get; }",
            (false, true) => "{ set; }",
            _ => "{ }"
        };
        return $"{mods} {Csharp(p.PropertyType)} {p.Name} {accessors}";
    }

    public static string PythonProperty(PropertyInfo p) {
        // Python wrappers expose these as @property / @setter; we show the symbolic access form.
        var get = p.GetGetMethod() is not null;
        var set = p.GetSetMethod() is not null;
        var access = (get, set) switch {
            (true, true)  => "@property / @setter",
            (true, false) => "@property",
            (false, true) => "@setter",
            _ => ""
        };
        return $"{p.Name}: {Python(p.PropertyType)}  # {access}";
    }

    public static string CppProperty(PropertyInfo p) {
        // The C++ wrappers expose properties as a pair of methods.
        var get = p.GetGetMethod() is not null;
        var set = p.GetSetMethod() is not null;
        var parts = new List<string>();
        if (get) parts.Add($"{Cpp(p.PropertyType)} {p.Name}() const;");
        if (set) parts.Add($"void {p.Name}({Cpp(p.PropertyType)} value);");
        return string.Join("\n", parts);
    }

    public static string CsharpEvent(EventInfo e) {
        var add = e.GetAddMethod(true)!;
        var mods = new StringBuilder(AccessibilityOf(add));
        if (add.IsStatic) mods.Append(" static");
        return $"{mods} event {Csharp(e.EventHandlerType!)} {e.Name}";
    }

    public static string PythonEvent(EventInfo e) => $"{e.Name}  # += / -= handler";
    public static string CppEvent(EventInfo e) => $"Core::Event<...> {e.Name};";

    public static string CsharpField(FieldInfo f) {
        var mods = new StringBuilder(AccessibilityOf(f));
        if (f.IsLiteral) mods.Append(" const");
        else if (f.IsStatic) mods.Append(" static");
        if (f.IsInitOnly) mods.Append(" readonly");
        var decl = $"{mods} {Csharp(f.FieldType)} {f.Name}";
        if (f.IsLiteral) {
            var v = f.GetRawConstantValue();
            if (v is string s) decl += $" = \"{s}\"";
            else if (v is char c) decl += $" = '{c}'";
            else if (v is not null) decl += $" = {v}";
        }
        return decl;
    }

    public static string PythonField(FieldInfo f) {
        var decl = $"{f.Name}: {Python(f.FieldType)}";
        if (f.IsLiteral) {
            var v = f.GetRawConstantValue();
            if (v is string s) decl += $" = \"{s}\"";
            else if (v is not null) decl += $" = {v}";
        }
        return decl;
    }

    public static string CppField(FieldInfo f) {
        var mods = new StringBuilder();
        if (f.IsLiteral) mods.Append("static constexpr ");
        else if (f.IsStatic) mods.Append("static ");
        var decl = $"{mods}{Cpp(f.FieldType)} {f.Name}";
        if (f.IsLiteral) {
            var v = f.GetRawConstantValue();
            if (v is string s) decl += $" = \"{s}\"";
            else if (v is not null) decl += $" = {v}";
        }
        decl += ";";
        return decl;
    }

    public static string AccessibilityOf(MemberInfo m) => m switch {
        MethodBase mb when mb.IsPublic => "public",
        MethodBase mb when mb.IsFamily => "protected",
        MethodBase mb when mb.IsFamilyOrAssembly => "protected internal",
        FieldInfo fi when fi.IsPublic => "public",
        FieldInfo fi when fi.IsFamily => "protected",
        _ => "public"
    };

    // Ordered list of a type's base-class + interfaces, filtered to ones that
    // actually carry information (System.Object, System.ValueType, System.Enum,
    // System.Delegate are implicit). Shared by the three per-language headers.
    static List<Type> InterestingBases(Type t) {
        var bases = new List<Type>();
        if (t.BaseType is Type bt
            && bt.FullName != "System.Object"
            && bt.FullName != "System.ValueType"
            && bt.FullName != "System.Enum"
            && bt.FullName != "System.MulticastDelegate"
            && bt.FullName != "System.Delegate") {
            bases.Add(bt);
        }
        foreach (var i in t.GetInterfaces()) {
            if (t.BaseType is Type pbt && pbt.GetInterfaces().Contains(i)) continue;
            bases.Add(i);
        }
        return bases;
    }

    static bool IsDelegate(Type t) {
        for (var b = t.BaseType; b != null; b = b.BaseType) {
            if (b.FullName == "System.MulticastDelegate") return true;
            if (b.FullName == "System.Delegate") return true;
        }
        return false;
    }

    public static string PythonTypeHeader(Type t) {
        var name = t.Name.Split('`')[0];
        if (t.IsEnum) {
            var underlying = Enum.GetUnderlyingType(t);
            var baseCls = underlying.Name is "Int64" or "UInt64" or "UInt32" ? "IntFlag" : "IntEnum";
            return $"class {name}({baseCls}): ...";
        }
        if (IsDelegate(t)) {
            var invoke = t.GetMethod("Invoke");
            var args = invoke is null ? "" : string.Join(", ", invoke.GetParameters().Select(p => Python(p.ParameterType)));
            var ret  = invoke is null || invoke.ReturnType.FullName == "System.Void" ? "None" : Python(invoke.ReturnType);
            return $"{name} = Callable[[{args}], {ret}]";
        }
        var bases = InterestingBases(t).Select(b => Python(b)).ToList();
        if (t.IsInterface && bases.Count == 0) bases.Add("Protocol");
        var parents = bases.Count == 0 ? "" : "(" + string.Join(", ", bases) + ")";
        return $"class {name}{parents}: ...";
    }

    public static string CppTypeHeader(Type t) {
        var name = t.Name.Split('`')[0];
        if (t.IsEnum) {
            var u = Enum.GetUnderlyingType(t);
            return $"enum class {name} : {Cpp(u)} {{}};";
        }
        if (IsDelegate(t)) {
            var invoke = t.GetMethod("Invoke");
            var args = invoke is null ? "" : string.Join(", ", invoke.GetParameters().Select(p => Cpp(p.ParameterType)));
            var ret  = invoke is null ? "void" : Cpp(invoke.ReturnType);
            return $"using {name} = std::function<{ret}({args})>;";
        }
        var keyword = t.IsValueType ? "struct" : "class";
        var bases = InterestingBases(t).Select(b => "public " + Cpp(b)).ToList();
        var parents = bases.Count == 0 ? "" : " : " + string.Join(", ", bases);
        return $"{keyword} {name}{parents} {{}};";
    }

    public static string CsharpTypeHeader(Type t) {
        var sb = new StringBuilder();
        sb.Append(t.IsPublic || t.IsNestedPublic ? "public " : "");
        if (t.IsAbstract && t.IsSealed) sb.Append("static ");
        else if (t.IsAbstract && !t.IsInterface) sb.Append("abstract ");
        else if (t.IsSealed && !t.IsEnum && !t.IsValueType) sb.Append("sealed ");

        var isDelegate = false;
        for (var b = t.BaseType; b != null; b = b.BaseType) {
            if (b.FullName == "System.MulticastDelegate" || b.FullName == "System.Delegate") {
                isDelegate = true; break;
            }
        }

        if (t.IsEnum) sb.Append("enum ");
        else if (t.IsInterface) sb.Append("interface ");
        else if (t.IsValueType) sb.Append("struct ");
        else if (isDelegate) sb.Append("delegate ");
        else sb.Append("class ");

        if (isDelegate) {
            // delegate: show return + params
            var invoke = t.GetMethod("Invoke");
            if (invoke != null) {
                sb.Clear();
                sb.Append(t.IsPublic || t.IsNestedPublic ? "public " : "");
                sb.Append("delegate ").Append(Csharp(invoke.ReturnType)).Append(' ').Append(t.Name.Split('`')[0]);
                if (t.IsGenericTypeDefinition) {
                    sb.Append('<').Append(string.Join(", ", t.GetGenericArguments().Select(a => a.Name))).Append('>');
                }
                sb.Append('(');
                sb.Append(string.Join(", ", invoke.GetParameters().Select(p => $"{Csharp(p.ParameterType)} {p.Name}")));
                sb.Append(");");
                return sb.ToString();
            }
        }

        sb.Append(t.Name.Split('`')[0]);
        if (t.IsGenericTypeDefinition) {
            sb.Append('<').Append(string.Join(", ", t.GetGenericArguments().Select(a => a.Name))).Append('>');
        }

        var bases = new List<string>();
        if (t.BaseType is Type bt
            && bt.FullName != "System.Object"
            && bt.FullName != "System.ValueType"
            && bt.FullName != "System.Enum"
            && bt.FullName != "System.MulticastDelegate"
            && bt.FullName != "System.Delegate") {
            bases.Add(Csharp(bt));
        }
        foreach (var i in t.GetInterfaces()) {
            if (t.BaseType is Type pbt && pbt.GetInterfaces().Contains(i)) continue;  // inherited interface
            bases.Add(Csharp(i));
        }
        if (bases.Count > 0) sb.Append(" : ").Append(string.Join(", ", bases));
        return sb.ToString();
    }
}
