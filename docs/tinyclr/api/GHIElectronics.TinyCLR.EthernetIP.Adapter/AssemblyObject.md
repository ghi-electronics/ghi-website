---
title: "AssemblyObject Class"
sidebar_label: "AssemblyObject"
---

# AssemblyObject Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Describes a CIP Assembly (Class 4) instance that a scanner can read or write.

```csharp
public class AssemblyObject
```

## Constructors

### AssemblyObject(int instanceId, byte[] data, ushort size)

```csharp
public AssemblyObject(int instanceId, byte[] data, ushort size)
```

Creates an assembly object with the given instance ID, data buffer, and size.

## Properties

### Impl

```csharp
public IntPtr Impl { get; set; }
```

Native handle to the underlying assembly object.

### InstanceId

```csharp
public int InstanceId { get; }
```

The CIP instance ID of this assembly.

### Data

```csharp
public byte[] Data { get; }
```

The data buffer backing this assembly's contents.

### Size

```csharp
public ushort Size { get; }
```

The size of the assembly data in bytes.
