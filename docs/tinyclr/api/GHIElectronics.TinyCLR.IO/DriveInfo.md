---
title: "DriveInfo Class"
sidebar_label: "DriveInfo"
---

# DriveInfo Class

**Namespace:** `System.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

Information about a mounted volume — total/available space, type, root path.

```csharp
public sealed class DriveInfo
```

## Constructors

### DriveInfo(string driveName)

```csharp
public DriveInfo(string driveName)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `driveName` | `string` |  |

## Properties

### Name

```csharp
public string Name { get; }
```

The native API name. _(inherited)_

### RootDirectory

```csharp
public DirectoryInfo RootDirectory { get; }
```

_No description available._

### DriveType

```csharp
public DriveType DriveType { get; }
```

_No description available._

### DriveFormat

```csharp
public string DriveFormat { get; }
```

_No description available._

### IsReady

```csharp
public bool IsReady { get; }
```

_No description available._

### AvailableFreeSpace

```csharp
public long AvailableFreeSpace { get; }
```

_No description available._

### TotalFreeSpace

```csharp
public long TotalFreeSpace { get; }
```

_No description available._

### TotalSize

```csharp
public long TotalSize { get; }
```

Total size of the region, in bytes. _(inherited)_

### VolumeLabel

```csharp
public string VolumeLabel { get; }
```

_No description available._

## Methods

### GetDrives()

```csharp
public static DriveInfo[] GetDrives()
```

_No description available._

**Returns** `DriveInfo[]`

### RegisterDriveProvider(IDriveProvider provider)

```csharp
public static IDriveProvider RegisterDriveProvider(IDriveProvider provider)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IDriveProvider` |  |

**Returns** `IDriveProvider`

### DeregisterDriveProvider(IDriveProvider provider)

```csharp
public static void DeregisterDriveProvider(IDriveProvider provider)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IDriveProvider` |  |
