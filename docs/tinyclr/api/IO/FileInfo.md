---
title: "FileInfo Class"
sidebar_label: "FileInfo"
---

# FileInfo Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public sealed class FileInfo : FileSystemInfo
```

## Constructors

### FileInfo(string fileName)

```csharp
public FileInfo(string fileName)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` |  |

## Properties

### Name

```csharp
public override string Name { get; }
```

The native API name. _(inherited)_

### Length

```csharp
public long Length { get; }
```

Gets length of bytes in the stream. _(inherited)_

### DirectoryName

```csharp
public string DirectoryName { get; }
```

_No description available._

### Directory

```csharp
public DirectoryInfo Directory { get; }
```

_No description available._

### Exists

```csharp
public override bool Exists { get; }
```

_No description available._

## Methods

### Create()

```csharp
public FileStream Create()
```

_No description available._

**Returns** `FileStream`

### Delete()

```csharp
public override void Delete()
```

_No description available._

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`
