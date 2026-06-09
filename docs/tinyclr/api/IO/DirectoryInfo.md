---
title: "DirectoryInfo Class"
sidebar_label: "DirectoryInfo"
---

# DirectoryInfo Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public sealed class DirectoryInfo : FileSystemInfo
```

## Constructors

### DirectoryInfo(string path)

```csharp
public DirectoryInfo(string path)
```

_No description available._

## Properties

### Name

```csharp
public override string Name { get; }
```

The native API name. _(inherited)_

### Parent

```csharp
public DirectoryInfo Parent { get; }
```

_No description available._

### Exists

```csharp
public override bool Exists { get; }
```

_No description available._

### Root

```csharp
public DirectoryInfo Root { get; }
```

_No description available._

## Methods

### CreateSubdirectory(string path)

```csharp
public DirectoryInfo CreateSubdirectory(string path)
```

_No description available._

**Returns** `DirectoryInfo`

### Create()

```csharp
public void Create()
```

_No description available._

### GetFiles()

```csharp
public FileInfo[] GetFiles()
```

Returns the names of the files in the file system. _(inherited)_

**Returns** `FileInfo[]` — An array of the names of the files.

### GetDirectories()

```csharp
public DirectoryInfo[] GetDirectories()
```

_No description available._

**Returns** `DirectoryInfo[]`

### MoveTo(string destDirName)

```csharp
public void MoveTo(string destDirName)
```

_No description available._

### Delete()

```csharp
public override void Delete()
```

_No description available._

### Delete(bool recursive)

```csharp
public void Delete(bool recursive)
```

Deletes a file from the device. _(inherited)_

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`
