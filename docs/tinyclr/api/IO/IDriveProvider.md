---
title: "IDriveProvider Interface"
sidebar_label: "IDriveProvider"
---

# IDriveProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO`

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

**Returns** `IFileSystemEntryFinder`

### GetFileSystemEntry(string path)

```csharp
FileSystemEntry GetFileSystemEntry(string path)
```

_No description available._

**Returns** `FileSystemEntry`

### OpenFile(string path, int bufferSize)

```csharp
IFileStream OpenFile(string path, int bufferSize)
```

_No description available._

**Returns** `IFileStream`

### Delete(string path)

```csharp
void Delete(string path)
```

Deletes a file from the device. _(inherited)_

### Move(string source, string destination)

```csharp
bool Move(string source, string destination)
```

Moves a file from the source to the destination. _(inherited)_

**Returns** `bool`

### CreateDirectory(string path)

```csharp
void CreateDirectory(string path)
```

_No description available._

### GetAttributes(string path)

```csharp
FileAttributes GetAttributes(string path)
```

_No description available._

**Returns** `FileAttributes`

### SetAttributes(string path, FileAttributes attributes)

```csharp
void SetAttributes(string path, FileAttributes attributes)
```

_No description available._

### Initialize(string name)

```csharp
void Initialize(string name)
```

_No description available._
