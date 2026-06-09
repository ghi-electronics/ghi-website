---
title: "FileStream Class"
sidebar_label: "FileStream"
---

# FileStream Class

**Namespace:** `System.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

A read/write stream backed by a file on a mounted file system. Construct via `File.OpenRead(string)` / `File.OpenWrite(string)` / `File.Create(string)`.

```csharp
public class FileStream : Stream
```

## Constructors

### FileStream(string path, FileMode mode)

```csharp
public FileStream(string path, FileMode mode) : this(path, mode, (mode == FileMode.Append ? FileAccess.Write : FileAccess.ReadWrite), FileShare.Read, FileStream.BufferSizeDefault)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `mode` | `FileMode` |  |

### FileStream(string path, FileMode mode, FileAccess access)

```csharp
public FileStream(string path, FileMode mode, FileAccess access) : this(path, mode, access, FileShare.Read, FileStream.BufferSizeDefault)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `mode` | `FileMode` |  |
| `access` | `FileAccess` |  |

### FileStream(string path, FileMode mode, FileAccess access, FileShare share)

```csharp
public FileStream(string path, FileMode mode, FileAccess access, FileShare share) : this(path, mode, access, share, FileStream.BufferSizeDefault)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `mode` | `FileMode` |  |
| `access` | `FileAccess` |  |
| `share` | `FileShare` |  |

### FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)

```csharp
public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `mode` | `FileMode` |  |
| `access` | `FileAccess` |  |
| `share` | `FileShare` |  |
| `bufferSize` | `int` |  |

## Properties

### CanRead

```csharp
public override bool CanRead { get; }
```

Gets a value indicating whether the current stream supports reading. _(inherited)_

### CanWrite

```csharp
public override bool CanWrite { get; }
```

Gets a value indicating whether the current stream supports writing. _(inherited)_

### CanSeek

```csharp
public override bool CanSeek { get; }
```

Gets a value indicating whether the current stream supports seeking. _(inherited)_

### IsAsync

```csharp
public virtual bool IsAsync { get; }
```

_No description available._

### Length

```csharp
public override long Length { get; }
```

Gets length of bytes in the stream. _(inherited)_

### Name

```csharp
public string Name { get; }
```

The native API name. _(inherited)_

### Position

```csharp
public override long Position { get; set; }
```

Gets or sets the current possition in the stream. _(inherited)_

## Methods

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### Flush()

```csharp
public override void Flush()
```

Writes unwritten data to the file. _(inherited)_

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

Adjusts the length of the array. This can be used to trim the end of the array. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `long` |  |

### Read(byte[] buffer, int offset, int count)

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

Reads a block of bytes from the stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array at which read bytes will be placed. |
| `count` | `int` | The maximun number of bytes to read. |

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

Sets the current position of this stream to a given value. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `offset` | `long` | The offset of the positon relative to the origin. |
| `origin` | `SeekOrigin` | Specified the beginning, end or current postion as a reference point to apply the offset. |

**Returns** `long` — The new postion in the stream.

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

Writes a block of bytes to the file stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array from which to start writing bytes to the stream. |
| `count` | `int` | The number of bytes to write. |
