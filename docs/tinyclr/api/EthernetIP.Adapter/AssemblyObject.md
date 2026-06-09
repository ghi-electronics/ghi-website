---
title: "AssemblyObject Class"
sidebar_label: "AssemblyObject"
---

# AssemblyObject Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

_No description available._

```csharp
public class AssemblyObject
```

## Constructors

### AssemblyObject(int instanceId, byte[] data, ushort size)

```csharp
public AssemblyObject(int instanceId, byte[] data, ushort size)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `instanceId` | `int` |  |
| `data` | `byte[]` |  |
| `size` | `ushort` |  |

## Properties

### Impl

```csharp
public IntPtr Impl { get; set; }
```

_No description available._

### InstanceId

```csharp
public int InstanceId { get; }
```

_No description available._

### Data

```csharp
public byte[] Data { get; }
```

The payload buffer. Up to 64 bytes for CAN-FD, 8 for classic CAN. _(inherited)_

### Size

```csharp
public ushort Size { get; }
```

Total size of the loaded image. _(inherited)_
