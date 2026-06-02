---
title: "IDriveProvider Interface"
sidebar_label: "IDriveProvider"
---

# IDriveProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

_No description available._

```csharp
public interface IDriveProvider
```

## Properties

### DriveType

```csharp
DriveType DriveType { get; }
```

_No description available._

### DriveFormat

```csharp
string DriveFormat { get; }
```

_No description available._

### IsReady

```csharp
bool IsReady { get; }
```

_No description available._

### AvailableFreeSpace

```csharp
long AvailableFreeSpace { get; }
```

_No description available._

### TotalFreeSpace

```csharp
long TotalFreeSpace { get; }
```

_No description available._

### TotalSize

```csharp
long TotalSize { get; }
```

Total size of the region, in bytes. _(inherited)_

### VolumeLabel

```csharp
string VolumeLabel { get; }
```

_No description available._

### Name

```csharp
string Name { get; }
```

The native API name. _(inherited)_

## Methods

### Find(string path, string searchPattern)

```csharp
IFileSystemEntryFinder Find(string path, string searchPattern)
```

Locates a native API by name and type. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `searchPattern` | `string` |  |

**Returns** `IFileSystemEntryFinder`

### GetFileSystemEntry(string path)

```csharp
FileSystemEntry GetFileSystemEntry(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `FileSystemEntry`

### OpenFile(string path, int bufferSize)

```csharp
IFileStream OpenFile(string path, int bufferSize)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `bufferSize` | `int` |  |

**Returns** `IFileStream`

### Delete(string path)

```csharp
void Delete(string path)
```

Deletes a file from the device. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

### Move(string source, string destination)

```csharp
bool Move(string source, string destination)
```

Moves a file from the source to the destination. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `source` | `string` |  |
| `destination` | `string` |  |

**Returns** `bool`

### CreateDirectory(string path)

```csharp
void CreateDirectory(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

### GetAttributes(string path)

```csharp
FileAttributes GetAttributes(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `FileAttributes`

### SetAttributes(string path, FileAttributes attributes)

```csharp
void SetAttributes(string path, FileAttributes attributes)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `attributes` | `FileAttributes` |  |

### Initialize(string name)

```csharp
void Initialize(string name)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
