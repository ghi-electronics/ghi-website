---
title: "FileEnum Class"
sidebar_label: "FileEnum"
---

# FileEnum Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Enumerates the file-system entries under a path.

```csharp
public class FileEnum : IEnumerator, IDisposable
```

## Constructors

### FileEnum(string path, FileEnumFlags flags)

```csharp
public FileEnum(string path, FileEnumFlags flags)
```

Creates an enumerator over the entries matching the given flags under the path.

## Methods

### MoveNext()

```csharp
public bool MoveNext()
```

Advances to the next entry.

**Returns** `bool`

### Reset()

```csharp
public void Reset()
```

Resets the enumerator to the start.
