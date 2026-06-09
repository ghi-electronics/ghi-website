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

_No description available._

### CanSeek

```csharp
public override bool CanSeek { get; }
```

_No description available._

### CanTimeout

```csharp
public override bool CanTimeout { get; }
```

_No description available._

### CanWrite

```csharp
public override bool CanWrite { get; }
```

_No description available._

### ReadTimeout

```csharp
public override int ReadTimeout { get; set; }
```

_No description available._

### WriteTimeout

```csharp
public override int WriteTimeout { get; set; }
```

_No description available._

### Length

```csharp
public override long Length { get; }
```

_No description available._

### Position

```csharp
public override long Position { get; set; }
```

_No description available._

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

_No description available._

### Flush()

```csharp
public override void Flush()
```

_No description available._

### Read(byte[] buffer, int offset, int count)

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

_No description available._

**Returns** `long`

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

_No description available._

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

_No description available._

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
