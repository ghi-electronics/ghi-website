---
title: "NetworkStream Class"
sidebar_label: "NetworkStream"
---

# NetworkStream Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Provides the underlying stream of data for network access.

```csharp
public class NetworkStream : Stream
```

## Constructors

### NetworkStream(Socket socket)

```csharp
public NetworkStream(Socket socket) : this(socket, false)
```

Creates a new network stream for the specified socket.

### NetworkStream(Socket socket, bool ownsSocket)

```csharp
public NetworkStream(Socket socket, bool ownsSocket)
```

Creates a new network stream for the specified socket, optionally taking ownership of it.

## Properties

### CanRead

```csharp
public override bool CanRead { get; }
```

Whether the stream supports reading.

### CanSeek

```csharp
public override bool CanSeek { get; }
```

Whether the stream supports seeking; always false.

### CanTimeout

```csharp
public override bool CanTimeout { get; }
```

Whether the stream supports timeouts; always true.

### CanWrite

```csharp
public override bool CanWrite { get; }
```

Whether the stream supports writing.

### ReadTimeout

```csharp
public override int ReadTimeout { get; set; }
```

The amount of time, in milliseconds, that a read operation waits before timing out.

### WriteTimeout

```csharp
public override int WriteTimeout { get; set; }
```

The amount of time, in milliseconds, that a write operation waits before timing out.

### Length

```csharp
public override long Length { get; }
```

Not supported; always throws NotSupportedException.

### Position

```csharp
public override long Position { get; set; }
```

Not supported; always throws NotSupportedException.

### DataAvailable

```csharp
public override bool DataAvailable { get; }
```

Whether data is available on the stream to be read.

## Methods

### Close(int timeout)

```csharp
public void Close(int timeout)
```

Closes the stream after waiting the specified time for data to be sent.

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Releases the resources used by the stream.

### Flush()

```csharp
public override void Flush()
```

Flushes the stream; reserved for future use.

### Read(byte[] buffer, int offset, int count)

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

Reads data from the stream into the buffer and returns the number of bytes read.

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

Not supported; always throws NotSupportedException.

**Returns** `long`

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

Not supported; always throws NotSupportedException.

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

Writes data from the buffer to the stream.

## Fields

### _socketType

```csharp
protected int _socketType
```

The type of the underlying socket.

### _remoteEndPoint

```csharp
protected EndPoint _remoteEndPoint
```

The remote endpoint used for datagram sockets.

### _disposed

```csharp
protected bool _disposed
```

Whether the stream has been disposed.
