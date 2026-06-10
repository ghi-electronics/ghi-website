---
title: "FileSystemEntry Class"
sidebar_label: "FileSystemEntry"
---

# FileSystemEntry Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO`

Describes a single file or directory returned by a drive provider.

```csharp
public class FileSystemEntry
```

## Properties

### Attributes

```csharp
public FileAttributes Attributes { get; set; }
```

The attributes of the entry.

### CreationTime

```csharp
public DateTime CreationTime { get; set; }
```

The time the entry was created.

### LastAccessTime

```csharp
public DateTime LastAccessTime { get; set; }
```

The time the entry was last accessed.

### LastWriteTime

```csharp
public DateTime LastWriteTime { get; set; }
```

The time the entry was last written.

### Size

```csharp
public long Size { get; set; }
```

The size of the entry in bytes.

### FileName

```csharp
public string FileName { get; set; }
```

The name of the entry.
