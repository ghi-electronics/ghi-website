---
title: "FileSystem Class"
sidebar_label: "FileSystem"
---

# FileSystem Class

**Namespace:** `GHIElectronics.TinyCLR.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

Mounts and unmounts file systems on top of a `GHIElectronics.TinyCLR.Devices.Storage.StorageController`. Pass the controller's `Hdc` to `Mount(IntPtr)` to make its content accessible via `System.IO.File` / `System.IO.Directory`.

```csharp
public static class FileSystem
```

## Methods

### Mount(IntPtr hdc)

```csharp
public static IDriveProvider Mount(IntPtr hdc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hdc` | `IntPtr` |  |

**Returns** `IDriveProvider`

### Unmount(IntPtr hdc)

```csharp
public static bool Unmount(IntPtr hdc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hdc` | `IntPtr` |  |

**Returns** `bool`

### Flush(IntPtr hdc)

```csharp
public static void Flush(IntPtr hdc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hdc` | `IntPtr` |  |

### Format(IntPtr hdc, string volume, uint parameter, byte forceSize)

```csharp
public static bool Format(IntPtr hdc, string volume = null, uint parameter = 0, byte forceSize = 0)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hdc` | `IntPtr` |  |
| `volume` | `string` |  |
| `parameter` | `uint` |  |
| `forceSize` | `byte` |  |

**Returns** `bool`
