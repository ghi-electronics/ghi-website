---
title: "II2cControllerProvider Interface"
sidebar_label: "II2cControllerProvider"
---

# II2cControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`

Provider contract for an I²C controller.

```csharp
public interface II2cControllerProvider : IDisposable
```

## Properties

### WriteBufferSize

```csharp
int WriteBufferSize { get; set; }
```

Slave-mode only: size in bytes of the controller's outgoing buffer.

### ReadBufferSize

```csharp
int ReadBufferSize { get; set; }
```

Slave-mode only: size in bytes of the controller's incoming buffer.

### BytesToWrite

```csharp
int BytesToWrite { get; }
```

Slave-mode only: bytes currently queued to transmit.

### BytesToRead

```csharp
int BytesToRead { get; }
```

Slave-mode only: bytes currently available to read.

### Timeout

```csharp
TimeSpan Timeout { get; set; }
```

Maximum time the controller will block on a single transfer.

## Methods

### ClearWriteBuffer()

```csharp
void ClearWriteBuffer()
```

Slave-mode only: empties the controller's outgoing buffer.

### ClearReadBuffer()

```csharp
void ClearReadBuffer()
```

Slave-mode only: empties the controller's incoming buffer.

### SetActiveSettings(I2cConnectionSettings connectionSettings)

```csharp
void SetActiveSettings(I2cConnectionSettings connectionSettings)
```

Applies the given settings before the next transfer.

| Parameter | Type | Description |
|---|---|---|
| `connectionSettings` | `I2cConnectionSettings` |  |

### WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, out int written, out int read)

```csharp
I2cTransferStatus WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, out int written, out int read)
```

Performs a write-then-read transaction.

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` |  |
| `writeOffset` | `int` |  |
| `writeLength` | `int` |  |
| `readBuffer` | `byte[]` |  |
| `readOffset` | `int` |  |
| `readLength` | `int` |  |
| `written` | `out int` |  |
| `read` | `out int` |  |

**Returns** `I2cTransferStatus`

## Events

### FrameReceived

```csharp
event FrameReceivedEventHandler FrameReceived
```

Slave-mode only: raised when a master frame addressed to this slave is observed.

### ErrorReceived

```csharp
event ErrorReceivedEventHandler ErrorReceived
```

Slave-mode only: raised when the controller detects a bus error.
