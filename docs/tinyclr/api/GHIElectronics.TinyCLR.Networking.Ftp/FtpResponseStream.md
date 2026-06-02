---
title: "FtpResponseStream Class"
sidebar_label: "FtpResponseStream"
---

# FtpResponseStream Class

**Namespace:** `GHIElectronics.TinyCLR.Networking` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

A virtual stream to do the read / write job from / to sockets

```csharp
public class FtpResponseStream : Stream
```

## Constructors

### FtpResponseStream(FtpListenerResponse responese)

```csharp
public FtpResponseStream(FtpListenerResponse responese)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `responese` | `FtpListenerResponse` |  |

### FtpResponseStream(FtpListenerResponse responese, Stream stream)

```csharp
public FtpResponseStream(FtpListenerResponse responese, Stream stream) : this(responese)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `responese` | `FtpListenerResponse` |  |
| `stream` | `Stream` |  |

## Properties

### CanRead

```csharp
public override bool CanRead { get; }
```

Gets a value indicating whether the current stream supports reading. _(inherited)_

### CanSeek

```csharp
public override bool CanSeek { get; }
```

Gets a value indicating whether the current stream supports seeking. _(inherited)_

### CanWrite

```csharp
public override bool CanWrite { get; }
```

Gets a value indicating whether the current stream supports writing. _(inherited)_

### Length

```csharp
public override long Length { get; }
```

Gets length of bytes in the stream. _(inherited)_

### Position

```csharp
public override long Position { get; set; }
```

Gets or sets the current possition in the stream. _(inherited)_

## Methods

### Flush()

```csharp
public override void Flush()
```

Writes unwritten data to the file. _(inherited)_

### Close()

```csharp
public override void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

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

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

Adjusts the length of the array. This can be used to trim the end of the array. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `long` |  |

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

### Write(string s)

```csharp
public void Write(string s)
```

Write a string to the buffer

| Parameter | Type | Description |
|---|---|---|
| `s` | `string` |  |

### Write(FileStream stream)

```csharp
public void Write(FileStream stream)
```

Read data from the stream and write them to the socket

| Parameter | Type | Description |
|---|---|---|
| `stream` | `FileStream` |  |

### ReadTo(FileStream stream)

```csharp
public void ReadTo(FileStream stream)
```

Read data the file stream provided in the paramenter

| Parameter | Type | Description |
|---|---|---|
| `stream` | `FileStream` |  |

### Write(FileSystemInfo info)

```csharp
public void Write(FileSystemInfo info)
```

Write a fileinfo or directoryinfo to the socket

| Parameter | Type | Description |
|---|---|---|
| `info` | `FileSystemInfo` |  |

### Read(out string s)

```csharp
public int Read(out string s)
```

Read the data from internal buffer

| Parameter | Type | Description |
|---|---|---|
| `s` | `out string` |  |

**Returns** `int`
