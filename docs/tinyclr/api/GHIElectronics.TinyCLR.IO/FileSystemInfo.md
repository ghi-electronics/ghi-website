---
title: "FileSystemInfo Class"
sidebar_label: "FileSystemInfo"
---

# FileSystemInfo Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Base class for objects that describe a file or directory.

```csharp
public abstract class FileSystemInfo : MarshalByRefObject
```

## Properties

### FullName

```csharp
public virtual string FullName { get; }
```

The full path of the file or directory.

### Extension

```csharp
public string Extension { get; }
```

The extension portion of the name, including the leading period.

### Name

```csharp
public abstract string Name { get; }
```

The name of the file or directory.

### Exists

```csharp
public abstract bool Exists { get; }
```

Whether the file or directory exists.

### Attributes

```csharp
public FileAttributes Attributes { get; }
```

The attributes of the file or directory.

### CreationTime

```csharp
public DateTime CreationTime { get; }
```

The creation time in local time.

### CreationTimeUtc

```csharp
public DateTime CreationTimeUtc { get; }
```

The creation time in UTC.

### LastAccessTime

```csharp
public DateTime LastAccessTime { get; }
```

The last access time in local time.

### LastAccessTimeUtc

```csharp
public DateTime LastAccessTimeUtc { get; }
```

The last access time in UTC.

### LastWriteTime

```csharp
public DateTime LastWriteTime { get; }
```

The last write time in local time.

### LastWriteTimeUtc

```csharp
public DateTime LastWriteTimeUtc { get; }
```

The last write time in UTC.

## Methods

### Delete()

```csharp
public abstract void Delete()
```

Deletes the file or directory.

### Refresh()

```csharp
public void Refresh()
```

Reloads the cached metadata from the underlying file system.

### RefreshIfNull()

```csharp
protected void RefreshIfNull()
```

Loads the cached metadata if it has not been loaded yet.

## Fields

### m_fullPath

```csharp
protected string m_fullPath
```

The fully qualified path of the file or directory.
