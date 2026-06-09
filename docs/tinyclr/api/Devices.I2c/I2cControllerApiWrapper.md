---
title: "I2cControllerApiWrapper Class"
sidebar_label: "I2cControllerApiWrapper"
---

# I2cControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c.Provider`

Concrete `II2cControllerProvider` backed by the native TinyCLR I²C HAL.

```csharp
public sealed class I2cControllerApiWrapper : II2cControllerProvider
```

## Constructors

### I2cControllerApiWrapper(NativeApi api)

```csharp
public I2cControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` |  |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### WriteBufferSize

```csharp
public extern int WriteBufferSize { get; set; }
```

Size in bytes of the transmit buffer. _(inherited)_

### ReadBufferSize

```csharp
public extern int ReadBufferSize { get; set; }
```

Size in bytes of the receive buffer. _(inherited)_

### BytesToWrite

```csharp
public extern int BytesToWrite { get; }
```

The number of bytes that are in the process of being written. _(inherited)_

### BytesToRead

```csharp
public extern int BytesToRead { get; }
```

The number of bytes available to read. _(inherited)_

### Timeout

```csharp
public TimeSpan Timeout { get; set; }
```

Gets or sets the length of time, in milliseconds, before the request times out. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### SetActiveSettings(I2cConnectionSettings connectionSettings)

```csharp
public extern void SetActiveSettings(I2cConnectionSettings connectionSettings)
```

Applies a complete set of serial settings (baud, framing, handshake, polarity). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `connectionSettings` | `I2cConnectionSettings` |  |

### WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, out int written, out int read)

```csharp
public extern I2cTransferStatus WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, out int written, out int read)
```

Performs a write-then-read transaction. _(inherited)_

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

### ClearWriteBuffer()

```csharp
public extern void ClearWriteBuffer()
```

Empties the transmit buffer. _(inherited)_

### ClearReadBuffer()

```csharp
public extern void ClearReadBuffer()
```

Empties the receive buffer. _(inherited)_

## Events

### FrameReceived

```csharp
public event FrameReceivedEventHandler FrameReceived
```

Slave-mode only: raised when a master frame addressed to this slave is observed. _(inherited)_

### ErrorReceived

```csharp
public event ErrorReceivedEventHandler ErrorReceived
```

Raised when a frame/parity/overrun error is detected. _(inherited)_
