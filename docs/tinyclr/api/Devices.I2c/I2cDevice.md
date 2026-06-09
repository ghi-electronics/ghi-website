---
title: "I2cDevice Class"
sidebar_label: "I2cDevice"
---

# I2cDevice Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c` · **Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`

Represents a single slave on the I²C bus. Master-mode devices use the blocking `Read(byte[])` / `Write(byte[])` / `WriteRead(byte[],byte[])` family; slave-mode devices additionally expose `FrameReceived` and `ErrorReceived` events.

```csharp
public class I2cDevice : IDisposable
```

## Properties

### ConnectionSettings

```csharp
public I2cConnectionSettings ConnectionSettings { get; }
```

The per-device connection settings.

### Controller

```csharp
public I2cController Controller { get; }
```

The `I2cController` that owns this device.

### WriteBufferSize

```csharp
public int WriteBufferSize { get; }
```

Slave-mode only: size in bytes of the controller's outgoing buffer.

### ReadBufferSize

```csharp
public int ReadBufferSize { get; }
```

Slave-mode only: size in bytes of the controller's incoming buffer.

### BytesToWrite

```csharp
public int BytesToWrite { get; }
```

Slave-mode only: bytes currently queued to transmit.

### BytesToRead

```csharp
public int BytesToRead { get; }
```

Slave-mode only: bytes currently available to read.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases device-level resources.

### Read(byte[] buffer)

```csharp
public void Read(byte[] buffer)
```

Reads `buffer`.Length bytes from the slave.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

### Write(byte[] buffer)

```csharp
public void Write(byte[] buffer)
```

Writes `buffer`.Length bytes to the slave.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

### WriteRead(byte[] writeBuffer, byte[] readBuffer)

```csharp
public void WriteRead(byte[] writeBuffer, byte[] readBuffer)
```

Performs a register-style write-then-read transaction.

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` |  |
| `readBuffer` | `byte[]` |  |

### Read(byte[] buffer, int offset, int length)

```csharp
public void Read(byte[] buffer, int offset, int length)
```

Reads `length` bytes into `buffer` starting at `offset`.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

### Write(byte[] buffer, int offset, int length)

```csharp
public void Write(byte[] buffer, int offset, int length)
```

Writes `length` bytes from `buffer` starting at `offset`.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

### WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)

```csharp
public void WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)
```

Performs a write-then-read transaction with explicit slice offsets and lengths. Throws when the slave NACKs or the transfer is otherwise incomplete (master mode only).

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` |  |
| `writeOffset` | `int` |  |
| `writeLength` | `int` |  |
| `readBuffer` | `byte[]` |  |
| `readOffset` | `int` |  |
| `readLength` | `int` |  |

### ReadPartial(byte[] buffer)

```csharp
public I2cTransferResult ReadPartial(byte[] buffer)
```

Like `Read(byte[])` but returns a status + count instead of throwing on a partial transfer.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

**Returns** `I2cTransferResult`

### WritePartial(byte[] buffer)

```csharp
public I2cTransferResult WritePartial(byte[] buffer)
```

Like `Write(byte[])` but returns a status + count instead of throwing on a partial transfer.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

**Returns** `I2cTransferResult`

### WriteReadPartial(byte[] writeBuffer, byte[] readBuffer)

```csharp
public I2cTransferResult WriteReadPartial(byte[] writeBuffer, byte[] readBuffer)
```

Like `WriteRead(byte[],byte[])` but returns a status + counts.

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` |  |
| `readBuffer` | `byte[]` |  |

**Returns** `I2cTransferResult`

### ReadPartial(byte[] buffer, int offset, int length)

```csharp
public I2cTransferResult ReadPartial(byte[] buffer, int offset, int length)
```

Partial read with explicit slice offsets and lengths.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

**Returns** `I2cTransferResult`

### WritePartial(byte[] buffer, int offset, int length)

```csharp
public I2cTransferResult WritePartial(byte[] buffer, int offset, int length)
```

Partial write with explicit slice offsets and lengths.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

**Returns** `I2cTransferResult`

### WriteReadPartial(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)

```csharp
public I2cTransferResult WriteReadPartial(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)
```

Partial write-then-read with explicit slice offsets and lengths.

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` |  |
| `writeOffset` | `int` |  |
| `writeLength` | `int` |  |
| `readBuffer` | `byte[]` |  |
| `readOffset` | `int` |  |
| `readLength` | `int` |  |

**Returns** `I2cTransferResult` — A `I2cTransferResult` with the transfer status and byte counts.

### ClearWriteBuffer()

```csharp
public void ClearWriteBuffer()
```

Slave-mode only: empties the controller's outgoing buffer.

### ClearReadBuffer()

```csharp
public void ClearReadBuffer()
```

Slave-mode only: empties the controller's incoming buffer.

## Events

### FrameReceived

```csharp
public event FrameReceivedEventHandler FrameReceived
```

Slave-mode only: raised when a master start/stop or data frame is observed addressed to this slave.

### ErrorReceived

```csharp
public event ErrorReceivedEventHandler ErrorReceived
```

Slave-mode only: raised when the controller detects a bus error (overrun, arbitration loss, etc.).
