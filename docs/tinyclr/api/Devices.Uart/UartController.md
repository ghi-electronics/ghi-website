---
title: "UartController Class"
sidebar_label: "UartController"
---

# UartController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`

Represents a UART (serial) port. Configure via `SetActiveSettings(UartSetting)`, then `Enable` the port and exchange bytes through `Read(byte[])` / `Write(byte[])`. Subscribe to `DataReceived` for event-driven receive instead of polling `BytesToRead`.

```csharp
public class UartController : IDisposable
```

## Properties

### Provider

```csharp
public IUartControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### WriteBufferSize

```csharp
public int WriteBufferSize { get; set; }
```

Size in bytes of the transmit buffer.

### ReadBufferSize

```csharp
public int ReadBufferSize { get; set; }
```

Size in bytes of the receive buffer.

### BytesToWrite

```csharp
public int BytesToWrite { get; }
```

Bytes currently queued for transmission.

### BytesToRead

```csharp
public int BytesToRead { get; }
```

Bytes currently available to read.

### IsRequestToSendEnabled

```csharp
public bool IsRequestToSendEnabled { get; set; }
```

Drives the RTS line when hardware handshaking is enabled.

### ClearToSendState

```csharp
public bool ClearToSendState { get; }
```

Current state of the CTS line.

## Methods

### GetDefault()

```csharp
public static UartController GetDefault()
```

Returns the default UART controller for this device.

**Returns** `UartController`

### FromName(string name)

```csharp
public static UartController FromName(string name)
```

Returns a UART controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `UartController`

### FromProvider(IUartControllerProvider provider)

```csharp
public static UartController FromProvider(IUartControllerProvider provider)
```

Creates a controller from a custom `IUartControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IUartControllerProvider` |  |

**Returns** `UartController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### Enable()

```csharp
public void Enable()
```

Powers on the port. Call after `SetActiveSettings(UartSetting)`.

### Disable()

```csharp
public void Disable()
```

Powers off the port.

### SetActiveSettings(UartSetting setting)

```csharp
public void SetActiveSettings(UartSetting setting)
```

Applies a complete set of serial settings (baud, framing, handshake, polarity).

| Parameter | Type | Description |
|---|---|---|
| `setting` | `UartSetting` | Settings to apply. |

### Flush()

```csharp
public void Flush()
```

Blocks until all buffered TX bytes have been shifted out.

### Read(byte[] buffer)

```csharp
public int Read(byte[] buffer)
```

Reads up to `buffer`.Length bytes; returns the count actually read.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

**Returns** `int`

### Read(byte[] buffer, int offset, int length)

```csharp
public int Read(byte[] buffer, int offset, int length)
```

Reads up to `length` bytes into `buffer` at `offset`.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

**Returns** `int` — Number of bytes actually read (may be less than requested).

### Write(byte[] buffer)

```csharp
public int Write(byte[] buffer)
```

Writes `buffer`.Length bytes.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

**Returns** `int`

### Write(byte[] buffer, int offset, int length)

```csharp
public int Write(byte[] buffer, int offset, int length)
```

Writes `length` bytes from `buffer` at `offset`.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `length` | `int` |  |

**Returns** `int`

### Write(byte[] buffer, int offset, int length, TimeSpan breakDuration)

```csharp
public int Write(byte[] buffer, int offset, int length, TimeSpan breakDuration)
```

Writes a slice and optionally follows it with a break condition. A non-zero `breakDuration` flushes the TX FIFO first.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Source buffer. |
| `offset` | `int` | Starting offset. |
| `length` | `int` | Number of bytes to write. |
| `breakDuration` | `TimeSpan` | Length of the break condition to assert after the write; `TimeSpan.Zero` means no break. |

**Returns** `int` — Number of bytes actually queued.

### ClearWriteBuffer()

```csharp
public void ClearWriteBuffer()
```

Empties the transmit buffer.

### ClearReadBuffer()

```csharp
public void ClearReadBuffer()
```

Empties the receive buffer.

## Events

### ClearToSendChanged

```csharp
public event ClearToSendChangedEventHandler ClearToSendChanged
```

Raised when the CTS input changes state.

### DataReceived

```csharp
public event DataReceivedEventHandler DataReceived
```

Raised when receive data is available. `DataReceivedEventArgs.Count` gives the number of bytes that have just been buffered; call `Read(byte[])` from the handler to consume them.

### ErrorReceived

```csharp
public event ErrorReceivedEventHandler ErrorReceived
```

Raised when the controller detects a frame, parity, or buffer error.
