---
title: "IUartControllerProvider Interface"
sidebar_label: "IUartControllerProvider"
---

# IUartControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart.Provider`

Provider contract for a UART controller.

```csharp
public interface IUartControllerProvider : IDisposable
```

## Properties

### WriteBufferSize

```csharp
int WriteBufferSize { get; set; }
```

Size in bytes of the transmit buffer.

### ReadBufferSize

```csharp
int ReadBufferSize { get; set; }
```

Size in bytes of the receive buffer.

### BytesToWrite

```csharp
int BytesToWrite { get; }
```

Bytes currently queued for transmission.

### BytesToRead

```csharp
int BytesToRead { get; }
```

Bytes currently available to read.

### IsRequestToSendEnabled

```csharp
bool IsRequestToSendEnabled { get; set; }
```

Drives the RTS line when hardware handshaking is enabled.

### ClearToSendState

```csharp
bool ClearToSendState { get; }
```

Current state of the CTS line.

## Methods

### Enable()

```csharp
void Enable()
```

Powers on the port.

### Disable()

```csharp
void Disable()
```

Powers off the port.

### SetActiveSettings(int baudRate, int dataBits, UartParity parity, UartStopBitCount stopBits, UartHandshake handshaking, bool enableDePin, bool invertTxPolarity, bool invertRxPolarity, bool invertBinaryData, bool swapTxRxPin, bool invertDePolarity)

```csharp
void SetActiveSettings(int baudRate, int dataBits, UartParity parity, UartStopBitCount stopBits, UartHandshake handshaking, bool enableDePin, bool invertTxPolarity, bool invertRxPolarity, bool invertBinaryData, bool swapTxRxPin, bool invertDePolarity)
```

Applies a complete set of serial settings.

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
void Flush()
```

Blocks until all buffered TX bytes have been shifted out.

### Read(byte[] buffer, int offset, int length)

```csharp
int Read(byte[] buffer, int offset, int length)
```

Reads up to `length` bytes; returns the count actually read.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

**Returns** `int`

### Write(byte[] buffer, int offset, int length, TimeSpan breakDuration)

```csharp
int Write(byte[] buffer, int offset, int length, TimeSpan breakDuration)
```

Writes `length` bytes; optional trailing break of `breakDuration`.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |
| `breakDuration` | `TimeSpan` |  |

**Returns** `int`

### ClearWriteBuffer()

```csharp
void ClearWriteBuffer()
```

Empties the transmit buffer.

### ClearReadBuffer()

```csharp
void ClearReadBuffer()
```

Empties the receive buffer.

## Events

### ClearToSendChanged

```csharp
event ClearToSendChangedEventHandler ClearToSendChanged
```

Raised when CTS changes state.

### DataReceived

```csharp
event DataReceivedEventHandler DataReceived
```

Raised when receive data becomes available.

### ErrorReceived

```csharp
event ErrorReceivedEventHandler ErrorReceived
```

Raised when a frame/parity/overrun error is detected.
