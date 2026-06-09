---
title: "DeviceStats Struct"
sidebar_label: "DeviceStats"
---

# DeviceStats Struct

**NuGet:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`

Statistics for the device

```csharp
public struct DeviceStats
```

## Constructors

### DeviceStats(int bytesFree, int bytesOrphaned)

```csharp
public DeviceStats(int bytesFree, int bytesOrphaned)
```

Creates an instance of the DeviceStats structure.

| Parameter | Type | Description |
|---|---|---|
| `bytesFree` | `int` | Bytes free in the file system. |
| `bytesOrphaned` | `int` | Bytes orphaned in the file system. |

## Methods

### ToString()

```csharp
public override string ToString()
```

Returns a `string` that represents this instance.

**Returns** `string` — A `string` that represents this instance.

## Fields

### BytesFree

```csharp
public readonly int BytesFree
```

Free memory available for use.

### BytesOrphaned

```csharp
public readonly int BytesOrphaned
```

Memory occupied by orphaned clusters.
