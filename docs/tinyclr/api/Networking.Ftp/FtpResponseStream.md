---
title: "FtpResponseStream Class"
sidebar_label: "FtpResponseStream"
---

# FtpResponseStream Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking`

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

### FtpResponseStream(FtpListenerResponse responese, Stream stream)

```csharp
public FtpResponseStream(FtpListenerResponse responese, Stream stream) : this(responese)
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

### CanWrite

```csharp
public override bool CanWrite { get; }
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

## Methods

### Flush()

```csharp
public override void Flush()
```

_No description available._

### Close()

```csharp
public override void Close()
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

### Write(string s)

```csharp
public void Write(string s)
```

Write a string to the buffer

### Write(FileStream stream)

```csharp
public void Write(FileStream stream)
```

Read data from the stream and write them to the socket

### ReadTo(FileStream stream)

```csharp
public void ReadTo(FileStream stream)
```

Read data the file stream provided in the paramenter

### Write(FileSystemInfo info)

```csharp
public void Write(FileSystemInfo info)
```

Write a fileinfo or directoryinfo to the socket

### Read(out string s)

```csharp
public int Read(out string s)
```

Read the data from internal buffer

**Returns** `int`
