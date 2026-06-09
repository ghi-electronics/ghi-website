---
title: "UartControllerApiWrapper Class"
sidebar_label: "UartControllerApiWrapper"
---

# UartControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart.Provider`

Concrete `IUartControllerProvider` backed by the native TinyCLR UART HAL.

```csharp
public sealed class UartControllerApiWrapper : IUartControllerProvider
```

## Constructors

### UartControllerApiWrapper(NativeApi api)

```csharp
public UartControllerApiWrapper(NativeApi api)
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

### IsRequestToSendEnabled

```csharp
public extern bool IsRequestToSendEnabled { get; set; }
```

Drives the RTS line when hardware handshaking is enabled. _(inherited)_

### ClearToSendState

```csharp
public extern bool ClearToSendState { get; }
```

Current state of the CTS line. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### Enable()

```csharp
public extern void Enable()
```

Re-enables interrupts after a matching `Disable`. _(inherited)_

### Disable()

```csharp
public extern void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

### SetActiveSettings(int baudRate, int dataBits, UartParity parity, UartStopBitCount stopBits, UartHandshake handshaking, bool enableDePin, bool invertTxPolarity, bool invertRxPolarity, bool invertBinaryData, bool swapTxRxPin, bool invertDePolarity)

```csharp
public extern void SetActiveSettings(int baudRate, int dataBits, UartParity parity, UartStopBitCount stopBits, UartHandshake handshaking, bool enableDePin, bool invertTxPolarity, bool invertRxPolarity, bool invertBinaryData, bool swapTxRxPin, bool invertDePolarity)
```

Applies a complete set of serial settings. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `baudRate` | `int` |  |
| `dataBits` | `int` |  |
| `parity` | `UartParity` |  |
| `stopBits` | `UartStopBitCount` |  |
| `handshaking` | `UartHandshake` |  |
| `enableDePin` | `bool` |  |
| `invertTxPolarity` | `bool` |  |
| `invertRxPolarity` | `bool` |  |
| `invertBinaryData` | `bool` |  |
| `swapTxRxPin` | `bool` |  |
| `invertDePolarity` | `bool` |  |

### Flush()

```csharp
public extern void Flush()
```

Writes unwritten data to the file. _(inherited)_

### Read(byte[] buffer, int offset, int length)

```csharp
public extern int Read(byte[] buffer, int offset, int length)
```

Reads a block of bytes from the stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array at which read bytes will be placed. |
| `length` | `int` |  |

**Returns** `int`

### Write(byte[] buffer, int offset, int length, TimeSpan breakDuration)

```csharp
public extern int Write(byte[] buffer, int offset, int length, TimeSpan breakDuration)
```

Writes `length` bytes; optional trailing break of `breakDuration`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |
| `breakDuration` | `TimeSpan` |  |

**Returns** `int`

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

### ClearToSendChanged

```csharp
public event ClearToSendChangedEventHandler ClearToSendChanged
```

Raised when CTS changes state. _(inherited)_

### DataReceived

```csharp
public event DataReceivedEventHandler DataReceived
```

Raised when receive data becomes available. _(inherited)_

### ErrorReceived

```csharp
public event ErrorReceivedEventHandler ErrorReceived
```

Raised when a frame/parity/overrun error is detected. _(inherited)_
