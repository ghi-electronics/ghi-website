---
title: "TinyFileSystem Class"
sidebar_label: "TinyFileSystem"
---

# TinyFileSystem Class

**NuGet:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`

Tiny File System provides a basic file system which can be overlayed on any device providing a concrete implementation of the IBlockDriver interface.

```csharp
public class TinyFileSystem : IDisposable
```

## Constructors

### TinyFileSystem(IStorageControllerProvider storageProvider, uint clusterSize)

```csharp
public TinyFileSystem(IStorageControllerProvider storageProvider, uint clusterSize)
```

Creates an instance of TinyFileSystem.

## Methods

### CheckIfFormatted()

```csharp
public bool CheckIfFormatted()
```

Scan the flash module to verify that it is formatted.

**Returns** `bool` — true if formatted else false.

### Mount()

```csharp
public void Mount()
```

Mount an existing file system from a device.

### Format()

```csharp
public void Format()
```

Formats the device.

### Compact()

```csharp
public void Compact()
```

Compacts the file system.

### Copy(string sourceFileName, string destFileName, bool overwrite)

```csharp
public void Copy(string sourceFileName, string destFileName, bool overwrite = true)
```

Copies a file to a new file.

| Parameter | Type | Description |
|---|---|---|
| `sourceFileName` | `string` | The file to copy. |
| `destFileName` | `string` | The name of the destination file |
| `overwrite` | `bool` | Specifies if the destination should be overwritten if it already exists. Default true. |

### Create(string fileName, int bufferSize)

```csharp
public Stream Create(string fileName, int bufferSize = 4096)
```

Creates or overwrites a file.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file to create. |
| `bufferSize` | `int` | Size of the read/write buffer. 0 for no buffering. |

**Returns** `Stream` — TinyFileStream that provides stream based access to the file.

### Delete(string fileName)

```csharp
public void Delete(string fileName)
```

Deletes a file from the device.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file to delete. |

### Exists(string fileName)

```csharp
public bool Exists(string fileName)
```

Determines if the specified file exists.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file to check. |

**Returns** `bool` — true if the file exists otherwise false.

### Move(string sourceFileName, string destFileName)

```csharp
public void Move(string sourceFileName, string destFileName)
```

Moves a file from the source to the destination.

| Parameter | Type | Description |
|---|---|---|
| `sourceFileName` | `string` | Name of the file to move. |
| `destFileName` | `string` | New name of the file. |

### Open(string fileName, FileMode fileMode, int bufferSize)

```csharp
public Stream Open(string fileName, FileMode fileMode, int bufferSize = 4096)
```

Opens a TinyFileStream for the specified file.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file to open. |
| `fileMode` | `FileMode` | Specifies what to do when opening the file. |
| `bufferSize` | `int` | Size of the read/write buffer. 0 for no buffering. |

**Returns** `Stream` — A TinyFileStream which provides stream based access to the file.

### ReadAllBytes(string fileName)

```csharp
public byte[] ReadAllBytes(string fileName)
```

Opens a file, reads the content into a byte array and then closes the file.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file to read. |

**Returns** `byte[]` — A byte array containing the data from the file.

### WriteAllBytes(string fileName, byte[] data)

```csharp
public void WriteAllBytes(string fileName, byte[] data)
```

Creates a new file, writes the byte array to the file and then closes it. The file is overwritten if it already exists.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file to create. |
| `data` | `byte[]` | Bytes to be written to the file. |

### GetFiles()

```csharp
public string[] GetFiles()
```

Returns the names of the files in the file system.

**Returns** `string[]` — An array of the names of the files.

### GetFileSize(string fileName)

```csharp
public long GetFileSize(string fileName)
```

Gets the size of the specified file.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file for which to retrieve the file size. |

**Returns** `long` — Size of the file in bytes.

### GetFileCreationTime(string fileName)

```csharp
public DateTime GetFileCreationTime(string fileName)
```

Gets the creation time of the specified file.

| Parameter | Type | Description |
|---|---|---|
| `fileName` | `string` | Name of the file for which to retrieve the creation time. |

**Returns** `DateTime` — The creation time of the specified file.

### GetStats()

```csharp
public DeviceStats GetStats()
```

Get the current statistics of the file system.

**Returns** `DeviceStats` — Structure with the statistics of the file system.

### Dispose(bool disposing)

```csharp
protected void Dispose(bool disposing)
```

Releases the underlying block driver when `disposing` is true.

### Dispose()

```csharp
public void Dispose()
```

Releases all resources used by the file system.
