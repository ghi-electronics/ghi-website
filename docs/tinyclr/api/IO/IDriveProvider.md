---
title: "IDriveProvider Interface"
sidebar_label: "IDriveProvider"
---

# IDriveProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO`

Backing store for a mounted drive that the IO library calls into.

```csharp
public interface IDriveProvider
```

## Properties

### DriveType

```csharp
DriveType DriveType { get; }
```

The type of the drive.

### DriveFormat

```csharp
string DriveFormat { get; }
```

The name of the file system format on the drive.

### IsReady

```csharp
bool IsReady { get; }
```

Whether the drive is ready for access.

### AvailableFreeSpace

```csharp
long AvailableFreeSpace { get; }
```

The amount of free space available on the drive in bytes.

### TotalFreeSpace

```csharp
long TotalFreeSpace { get; }
```

The total free space on the drive in bytes.

### TotalSize

```csharp
long TotalSize { get; }
```

The total size of the drive in bytes.

### VolumeLabel

```csharp
string VolumeLabel { get; }
```

The volume label of the drive.

### Name

```csharp
string Name { get; }
```

The root name assigned to the drive.

## Methods

### Find(string path, string searchPattern)

```csharp
IFileSystemEntryFinder Find(string path, string searchPattern)
```

Returns a finder for the entries under the path that match the search pattern.

**Returns** `IFileSystemEntryFinder`

### GetFileSystemEntry(string path)

```csharp
FileSystemEntry GetFileSystemEntry(string path)
```

Returns metadata for the entry at the path, or null if it does not exist.

**Returns** `FileSystemEntry`

### OpenFile(string path, int bufferSize)

```csharp
IFileStream OpenFile(string path, int bufferSize)
```

Opens the file at the path and returns a stream to it.

**Returns** `IFileStream`

### Delete(string path)

```csharp
void Delete(string path)
```

Deletes the file or directory at the path.

### Move(string source, string destination)

```csharp
bool Move(string source, string destination)
```

Moves an entry from the source path to the destination path.

**Returns** `bool`

### CreateDirectory(string path)

```csharp
void CreateDirectory(string path)
```

Creates a directory at the path.

### GetAttributes(string path)

```csharp
FileAttributes GetAttributes(string path)
```

Returns the attributes of the entry at the path.

**Returns** `FileAttributes`

### SetAttributes(string path, FileAttributes attributes)

```csharp
void SetAttributes(string path, FileAttributes attributes)
```

Sets the attributes of the entry at the path.

### Initialize(string name)

```csharp
void Initialize(string name)
```

Initializes the provider with the given root name.
