---
title: "IFileSystemEntryFinder Interface"
sidebar_label: "IFileSystemEntryFinder"
---

# IFileSystemEntryFinder Interface

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO`

Iterates over the entries returned by a drive provider's search.

```csharp
public interface IFileSystemEntryFinder
```

## Methods

### GetNext()

```csharp
FileSystemEntry GetNext()
```

Returns the next entry, or null when there are no more.

**Returns** `FileSystemEntry`

### Close()

```csharp
void Close()
```

Closes the finder and releases its resources.
