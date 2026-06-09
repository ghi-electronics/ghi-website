---
title: "File Class"
sidebar_label: "File"
---

# File Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public static class File
```

## Methods

### Copy(string sourceFileName, string destFileName)

```csharp
public static void Copy(string sourceFileName, string destFileName)
```

_No description available._

### Copy(string sourceFileName, string destFileName, bool overwrite)

```csharp
public static void Copy(string sourceFileName, string destFileName, bool overwrite)
```

Copies a file to a new file. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `sourceFileName` | `string` | The file to copy. |
| `destFileName` | `string` | The name of the destination file |
| `overwrite` | `bool` | Specifies if the destination should be overwritten if it already exists. Default true. |

### Create(string path)

```csharp
public static FileStream Create(string path)
```

Creates a WebRequest . _(inherited)_

**Returns** `FileStream`

### Create(string path, int bufferSize)

```csharp
public static FileStream Create(string path, int bufferSize)
```

Creates or overwrites a file. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `bufferSize` | `int` | Size of the read/write buffer. 0 for no buffering. |

**Returns** `FileStream` — TinyFileStream that provides stream based access to the file.

### Delete(string path)

```csharp
public static void Delete(string path)
```

Deletes a file from the device. _(inherited)_

### Exists(string path)

```csharp
public static bool Exists(string path)
```

Determines if the specified file exists. _(inherited)_

**Returns** `bool` — true if the file exists otherwise false.

### Open(string path, FileMode mode)

```csharp
public static FileStream Open(string path, FileMode mode)
```

_No description available._

**Returns** `FileStream`

### Open(string path, FileMode mode, FileAccess access)

```csharp
public static FileStream Open(string path, FileMode mode, FileAccess access)
```

Opens a TinyFileStream for the specified file. _(inherited)_

**Returns** `FileStream` — A TinyFileStream which provides stream based access to the file.

### Open(string path, FileMode mode, FileAccess access, FileShare share)

```csharp
public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
```

_No description available._

**Returns** `FileStream`

### GetAttributes(string path)

```csharp
public static FileAttributes GetAttributes(string path)
```

_No description available._

**Returns** `FileAttributes`

### SetAttributes(string path, FileAttributes fileAttributes)

```csharp
public static void SetAttributes(string path, FileAttributes fileAttributes)
```

_No description available._

### OpenRead(string path)

```csharp
public static FileStream OpenRead(string path)
```

_No description available._

**Returns** `FileStream`

### OpenWrite(string path)

```csharp
public static FileStream OpenWrite(string path)
```

_No description available._

**Returns** `FileStream`

### ReadAllBytes(string path)

```csharp
public static byte[] ReadAllBytes(string path)
```

Opens a file, reads the content into a byte array and then closes the file. _(inherited)_

**Returns** `byte[]` — A byte array containing the data from the file.

### WriteAllBytes(string path, byte[] bytes)

```csharp
public static void WriteAllBytes(string path, byte[] bytes)
```

Creates a new file, writes the byte array to the file and then closes it. The file is overwritten if it already exists. _(inherited)_

### Move(string sourceFileName, string destFileName)

```csharp
public static void Move(string sourceFileName, string destFileName)
```

Moves a file from the source to the destination. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `sourceFileName` | `string` | Name of the file to move. |
| `destFileName` | `string` | New name of the file. |
