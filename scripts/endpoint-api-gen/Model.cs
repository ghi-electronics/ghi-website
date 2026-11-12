namespace EndpointApiGen;

// Flattened API model: one AssemblyModel per NuGet, one TypeModel per public
// type, one MemberModel per public/protected member. Everything the renderer
// needs is pre-computed here so the renderer only concatenates strings.

public sealed class AssemblyModel {
    public required string Name { get; init; }           // "GHIElectronics.Endpoint.Devices.Gpio"
    public required string Version { get; init; }        // "0.4.0"
    public required string? Description { get; init; }   // nupkg Description, or null
    public List<TypeModel> Types { get; } = new();
}

public sealed class TypeModel {
    public required string Namespace { get; init; }
    public required string Name { get; init; }           // "GpioController" (no generic params)
    public required string DisplayName { get; init; }    // "GpioController<T>" (with generic params if any)
    public required string SidebarPath { get; init; }    // "EPM815.Gpio.Driver": enclosing type path for nested
    public required TypeKind Kind { get; init; }
    public required string CsharpSignature { get; init; }
    public required string PythonSignature { get; init; }
    public required string CppSignature    { get; init; }
    public required string? Summary { get; init; }
    public required string? Remarks { get; init; }
    public List<MemberModel> Constructors { get; } = new();
    public List<MemberModel> Properties { get; } = new();
    public List<MemberModel> Methods { get; } = new();
    public List<MemberModel> Events { get; } = new();
    public List<MemberModel> Fields { get; } = new();    // includes const
    public List<EnumMemberModel> EnumMembers { get; } = new();
}

public enum TypeKind { Class, Struct, Interface, Enum, Delegate, Record }

public sealed class MemberModel {
    public required MemberKind Kind { get; init; }
    public required string Name { get; init; }           // "OpenPin"
    public required string DisplayName { get; init; }    // "OpenPin(int pinNumber)": disambiguates overloads
    public required string CsharpSignature { get; init; }
    public required string PythonSignature { get; init; }
    public required string CppSignature { get; init; }
    public required string? Summary { get; init; }
    public required string? Returns { get; init; }
    public required string? ReturnTypeDisplay { get; init; }   // null for ctors / void / fields
    public List<ParamModel> Parameters { get; } = new();
    public bool Obsolete { get; init; }
    public string? ObsoleteMessage { get; init; }
}

public enum MemberKind { Constructor, Property, Method, Event, Field, Constant }

public sealed class ParamModel {
    public required string Name { get; init; }
    public required string TypeDisplay { get; init; }
    public required string? Description { get; init; }
}

public sealed class EnumMemberModel {
    public required string Name { get; init; }
    public required string Value { get; init; }
    public required string? Summary { get; init; }
}
