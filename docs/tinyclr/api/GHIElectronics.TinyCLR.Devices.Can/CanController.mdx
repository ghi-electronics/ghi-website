---
title: "CanController Class"
sidebar_label: "CanController"
---

# CanController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Can`

Represents a CAN bus controller. Configure bit timing and acceptance filters, `Enable` the controller, then exchange `CanMessage`s. Subscribe to `MessageReceived` for event-driven receive instead of polling `MessagesToRead`.

```csharp
public class CanController : IDisposable
```

## Properties

### Provider

```csharp
public ICanControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### WriteBufferSize

```csharp
public int WriteBufferSize { get; set; }
```

Size of the transmit message queue.

### ReadBufferSize

```csharp
public int ReadBufferSize { get; set; }
```

Size of the receive message queue.

### MessagesToWrite

```csharp
public int MessagesToWrite { get; }
```

Messages currently queued for transmission.

### MessagesToRead

```csharp
public int MessagesToRead { get; }
```

Messages currently available to read.

### CanWriteMessage

```csharp
public bool CanWriteMessage { get; }
```

True when the transmit queue has room.

### CanReadMessage

```csharp
public bool CanReadMessage { get; }
```

True when at least one received message is available.

### WriteErrorCount

```csharp
public int WriteErrorCount { get; }
```

Current transmit error counter (TEC).

### ReadErrorCount

```csharp
public int ReadErrorCount { get; }
```

Current receive error counter (REC).

### SourceClock

```csharp
public int SourceClock { get; }
```

Source clock feeding the CAN prescaler, in Hz. Used to compute bit timing.

### Filter

```csharp
public Filter Filter { get; }
```

Acceptance filter configuration for this controller.

## Methods

### GetDefault()

```csharp
public static CanController GetDefault()
```

Returns the default CAN controller for this device.

**Returns** `CanController`

### FromName(string name)

```csharp
public static CanController FromName(string name)
```

Returns a CAN controller identified by its native API name.

**Returns** `CanController`

### FromProvider(ICanControllerProvider provider)

```csharp
public static CanController FromProvider(ICanControllerProvider provider)
```

Creates a controller from a custom `ICanControllerProvider`.

**Returns** `CanController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### Enable()

```csharp
public void Enable()
```

Powers on the controller. Call after configuring timing and filters.

### Disable()

```csharp
public void Disable()
```

Powers off the controller.

### WriteMessage(CanMessage message)

```csharp
public bool WriteMessage(CanMessage message)
```

Queues a single message for transmission. Returns true on success.

**Returns** `bool`

### WriteMessages(CanMessage[] messages, int offset, int count)

```csharp
public int WriteMessages(CanMessage[] messages, int offset, int count)
```

Queues a slice of `messages` for transmission.

**Returns** `int` — Number of messages successfully queued.

### ReadMessage(out CanMessage message)

```csharp
public bool ReadMessage(out CanMessage message)
```

Dequeues a single received message. Returns true if one was available.

**Returns** `bool`

### ReadMessages(CanMessage[] messages, int offset, int count)

```csharp
public int ReadMessages(CanMessage[] messages, int offset, int count)
```

Dequeues up to `count` received messages into `messages`.

**Returns** `int` — Number of messages actually read.

### SetNominalBitTiming(CanBitTiming bitTiming)

```csharp
public void SetNominalBitTiming(CanBitTiming bitTiming)
```

Configures the arbitration-phase bit timing (used for the whole frame in classic CAN).

### SetDataBitTiming(CanBitTiming bitTiming)

```csharp
public void SetDataBitTiming(CanBitTiming bitTiming)
```

Configures the data-phase bit timing for CAN-FD frames with bit-rate switching.

### ClearWriteBuffer()

```csharp
public void ClearWriteBuffer()
```

Empties the transmit queue.

### ClearReadBuffer()

```csharp
public void ClearReadBuffer()
```

Empties the receive queue.

## Events

### MessageReceived

```csharp
public event MessageReceivedEventHandler MessageReceived
```

Raised when one or more messages have arrived. Call `ReadMessage` from the handler.

### ErrorReceived

```csharp
public event ErrorReceivedEventHandler ErrorReceived
```

Raised when the controller detects a bus error or enters bus-off.
