---
title: "CIPClass Class"
sidebar_label: "CIPClass"
---

# CIPClass Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Describes a CIP object class to be registered with the adapter.

```csharp
public class CIPClass
```

## Constructors

### CIPClass()

```csharp
public CIPClass()
```

Creates an empty CIP class wrapper.

### CIPClass(ClassId classCode, int numberClassAttributes, uint highestClassAttributeNumber, int numberClassServices, int numberInstanceAttributes, uint highestInstanceAttributeNumber, int numberInstanceServices, uint numberInstances, string name, ushort revision, bool defaultInitialize)

```csharp
public CIPClass(ClassId classCode, int numberClassAttributes, uint highestClassAttributeNumber, int numberClassServices, int numberInstanceAttributes, uint highestInstanceAttributeNumber, int numberInstanceServices, uint numberInstances, string name, ushort revision, bool defaultInitialize = true)
```

Creates a CIP class with the given class code, attribute/service counts, name, and revision.

## Properties

### Impl

```csharp
public IntPtr Impl { get; set; }
```

Native handle to the underlying CIP class.

### ClassCode

```csharp
public ClassId ClassCode { get; }
```

The CIP class code identifying this object class.

### NumberClassAttributes

```csharp
public int NumberClassAttributes { get; }
```

The number of class-level attributes.

### HighestClassAttributeNumber

```csharp
public uint HighestClassAttributeNumber { get; }
```

The highest class-attribute number used.

### NumberClassServices

```csharp
public int NumberClassServices { get; }
```

The number of class-level services.

### NumberInstanceAttributes

```csharp
public int NumberInstanceAttributes { get; }
```

The number of instance-level attributes.

### HighestInstanceAttributeNumber

```csharp
public uint HighestInstanceAttributeNumber { get; }
```

The highest instance-attribute number used.

### NumberInstanceServices

```csharp
public int NumberInstanceServices { get; }
```

The number of instance-level services.

### NumberInstances

```csharp
public uint NumberInstances { get; }
```

The number of instances to create for this class.

### Name

```csharp
public string Name { get; }
```

The class name.

### Revision

```csharp
public ushort Revision { get; }
```

The class revision number.

### DefaultInitialize

```csharp
public bool DefaultInitialize { get; }
```

Whether the class is created with the OpENer default initialization.
