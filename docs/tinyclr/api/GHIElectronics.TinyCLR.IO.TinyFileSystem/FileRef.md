---
title: "FileRef Class"
sidebar_label: "FileRef"
---

# FileRef Class

**NuGet:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`

In memory representation of a file on "disk". This structure tracks the files total size, the clusters that make up the content of the file and the number of currently open Streams on the file.

```csharp
public class FileRef
```

## Methods

### UInt16Array()

```csharp
public UInt16Array blocks = new UInt16Array()
```

The list of clusters that make up the file content. Each block is sequenced in the order that the data occurs in the file. For example, index 0's value is the cluster id of the disk location that storing the data for the first block of file data, index 1 points to the cluster id of the second block of data etc. Block 0 also contains the files meta data in the form of a FileClusterBlock, subsequent block will be in the form of DataClusterBlocks. As a space optimization the FileClusterBlock also contain the initial data in the file.

**Returns** `UInt16Array blocks = new`

## Fields

### objId

```csharp
public ushort objId
```

Unique object id of the file.

### fileSize

```csharp
public int fileSize
```

Size of the file in bytes.

### openCount

```csharp
public byte openCount
```

Number of open streams on the file.
