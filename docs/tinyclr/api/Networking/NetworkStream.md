---
title: "NetworkStream Class"
sidebar_label: "NetworkStream"
---

# NetworkStream Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

_No description available._

```csharp
public class NetworkStream : Stream
```

## Constructors

### NetworkStream(Socket socket)

```csharp
public NetworkStream(Socket socket) : this(socket, false)
```

_No description available._

### NetworkStream(Socket socket, bool ownsSocket)

```csharp
public NetworkStream(Socket socket, bool ownsSocket)
```

_No description available._

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

### CanTimeout

```csharp
public override bool CanTimeout { get; }
```

_No description available._

### CanWrite

```csharp
public override bool CanWrite { get; }
```

Gets a value indicating whether the current stream supports writing. _(inherited)_

### ReadTimeout

```csharp
public override int ReadTimeout { get; set; }
```

How long to wait before timing out a read operation. _(inherited)_

### WriteTimeout

```csharp
public override int WriteTimeout { get; set; }
```

How long to wait before timing out a write operation. _(inherited)_

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

### DataAvailable

```csharp
public override bool DataAvailable { get; }
```

_No description available._

## Methods

### Close(int timeout)

```csharp
public void Close(int timeout)
```

_No description available._

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

## Fields

### _socketType

```csharp
protected int _socketType
```

_No description available._

### _remoteEndPoint

```csharp
protected EndPoint _remoteEndPoint
```

_No description available._

### _disposed

```csharp
protected bool _disposed
```

_No description available._
