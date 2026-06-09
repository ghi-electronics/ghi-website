---
title: "FileSystemInfo Class"
sidebar_label: "FileSystemInfo"
---

# FileSystemInfo Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public abstract class FileSystemInfo : MarshalByRefObject
```

## Properties

### FullName

```csharp
public virtual string FullName { get; }
```

_No description available._

### Extension

```csharp
public string Extension { get; }
```

_No description available._

### Name

```csharp
public abstract string Name { get; }
```

The native API name. _(inherited)_

### Exists

```csharp
public abstract bool Exists { get; }
```

_No description available._

### Attributes

```csharp
public FileAttributes Attributes { get; }
```

The attributes of the endpoint. _(inherited)_

### CreationTime

```csharp
public DateTime CreationTime { get; }
```

_No description available._

### CreationTimeUtc

```csharp
public DateTime CreationTimeUtc { get; }
```

_No description available._

### LastAccessTime

```csharp
public DateTime LastAccessTime { get; }
```

_No description available._

### LastAccessTimeUtc

```csharp
public DateTime LastAccessTimeUtc { get; }
```

_No description available._

### LastWriteTime

```csharp
public DateTime LastWriteTime { get; }
```

_No description available._

### LastWriteTimeUtc

```csharp
public DateTime LastWriteTimeUtc { get; }
```

_No description available._

## Methods

### Delete()

```csharp
public abstract void Delete()
```

_No description available._

### Refresh()

```csharp
public void Refresh()
```

Marks the cached chart surface stale. Call after mutating `Items` or any styling property to force a re-render on the next paint. _(inherited)_

### RefreshIfNull()

```csharp
protected void RefreshIfNull()
```

_No description available._

## Fields

### m_fullPath

```csharp
protected string m_fullPath
```

_No description available._
