---
title: "FileEnum Class"
sidebar_label: "FileEnum"
---

# FileEnum Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public class FileEnum : IEnumerator, IDisposable
```

## Constructors

### FileEnum(string path, FileEnumFlags flags)

```csharp
public FileEnum(string path, FileEnumFlags flags)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `flags` | `FileEnumFlags` |  |

## Methods

### MoveNext()

```csharp
public bool MoveNext()
```

Advances the enumerator to the next element of the collection. _(inherited)_

**Returns** `bool`

### Reset()

```csharp
public void Reset()
```

Sets the enumerator to its initial position, which is before the first element in the collection. _(inherited)_
