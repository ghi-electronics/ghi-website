---
title: "DirectoryInfo Class"
sidebar_label: "DirectoryInfo"
---

# DirectoryInfo Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Provides information about a directory and the means to create or delete it.

```csharp
public sealed class DirectoryInfo : FileSystemInfo
```

## Constructors

### DirectoryInfo(string path)

```csharp
public DirectoryInfo(string path)
```

Creates a new instance for the directory at the given path.

## Properties

### Name

```csharp
public override string Name { get; }
```

The name of the file or directory. _(inherited)_

### Parent

```csharp
public DirectoryInfo Parent { get; }
```

The parent directory, or null if this is a root.

### Exists

```csharp
public override bool Exists { get; }
```

Whether the file or directory exists. _(inherited)_

### Root

```csharp
public DirectoryInfo Root { get; }
```

The root portion of the directory's path.

## Methods

### CreateSubdirectory(string path)

```csharp
public DirectoryInfo CreateSubdirectory(string path)
```

Creates a subdirectory under this directory and returns it.

**Returns** `DirectoryInfo`

### Create()

```csharp
public void Create()
```

Creates the directory.

### GetFiles()

```csharp
public FileInfo[] GetFiles()
```

Returns the files contained in the directory.

**Returns** `FileInfo[]`

### GetDirectories()

```csharp
public DirectoryInfo[] GetDirectories()
```

Returns the subdirectories contained in the directory.

**Returns** `DirectoryInfo[]`

### MoveTo(string destDirName)

```csharp
public void MoveTo(string destDirName)
```

Moves the directory and its contents to a new path.

### Delete()

```csharp
public override void Delete()
```

Deletes the file or directory. _(inherited)_

### Delete(bool recursive)

```csharp
public void Delete(bool recursive)
```

Deletes the directory, optionally including its contents.

### ToString()

```csharp
public override string ToString()
```

Returns the full path of the directory.

**Returns** `string`
