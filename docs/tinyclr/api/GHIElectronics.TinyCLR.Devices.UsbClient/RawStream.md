---
title: "RawStream Class"
sidebar_label: "RawStream"
---

# RawStream Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

USB stream for reading and writing data through two endpoints.

```csharp
public class RawStream : Stream
```

## Constructors

### RawStream(int streamIndex, RawDevice parent)

```csharp
public RawStream(int streamIndex, RawDevice parent)
```

Creates a new raw stream.

## Properties

### NullEndpoint

```csharp
public static int NullEndpoint { get; }
```

Represents no endpoint.

### StreamIndex

```csharp
public int StreamIndex { get; }
```

The index of this stream.

### ReadTimeout

```csharp
public override int ReadTimeout { get; set; }
```

How long to wait before timing out a read operation.

### WriteTimeout

```csharp
public override int WriteTimeout { get; set; }
```

How long to wait before timing out a write operation.

### CanRead

```csharp
public override bool CanRead { get; }
```

Whether or not read is allowed from the stream.

### CanSeek

```csharp
public override bool CanSeek { get; }
```

Whether or not seeking is allowed in the stream.

### CanWrite

```csharp
public override bool CanWrite { get; }
```

Whether or not writting is allowed to the stream.

### Length

```csharp
public override long Length { get; }
```

Not supported.

### Position

```csharp
public override long Position { get; set; }
```

Not supported.

### LastWritten

```csharp
public int LastWritten { get; set; }
```

The number of bytes successfully written in the last call to any Write function.

### BytesToRead

```csharp
public int BytesToRead { get; }
```

The number of bytes available to read.

### BytesToWrite

```csharp
public int BytesToWrite { get; }
```

The number of bytes that are in the process of being written.

## Methods

### Seek(long offset, SeekOrigin origin)

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

Not supported.

| Parameter | Type | Description |
|---|---|---|
| `offset` | `long` | Not supported. |
| `origin` | `SeekOrigin` | Not supported. |

**Returns** `long` — Not supported.

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

Not supported.

| Parameter | Type | Description |
|---|---|---|
| `value` | `long` | Not supported. |

### Flush()

```csharp
public override void Flush()
```

Flushs the USB write buffers.

### Read(byte[] buffer, int offset, int count)

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

Reads data from the stream.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer to read into. |
| `offset` | `int` | The offset into the buffer at which to write the data. |
| `count` | `int` | The number of bytes to read. |

**Returns** `int` — The number of bytes read.

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

Writes data to the stream.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer from which to write. |
| `offset` | `int` | The offset into the buffer at which to begin writing. |
| `count` | `int` | The number of bytes to write. |

### Read(byte[] buffer)

```csharp
public int Read(byte[] buffer)
```

Reads data from the stream.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer into which to read. |

**Returns** `int` — The number of bytes read.

### Write(byte[] buffer)

```csharp
public void Write(byte[] buffer)
```

Writes data to the stream.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer from which to write. |

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Disposes the object.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Whether or not this is called from Dispose. |
