---
title: "CanControllerApiWrapper Class"
sidebar_label: "CanControllerApiWrapper"
---

# CanControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Can.Provider`

Concrete `ICanControllerProvider` backed by the native TinyCLR CAN HAL.

```csharp
public sealed class CanControllerApiWrapper : ICanControllerProvider
```

## Constructors

### CanControllerApiWrapper(NativeApi api)

```csharp
public CanControllerApiWrapper(NativeApi api)
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

### MessagesToWrite

```csharp
public extern int MessagesToWrite { get; }
```

Messages currently queued for transmission. _(inherited)_

### MessagesToRead

```csharp
public extern int MessagesToRead { get; }
```

Messages currently available to read. _(inherited)_

### CanWriteMessage

```csharp
public extern bool CanWriteMessage { get; }
```

True when the transmit queue has room. _(inherited)_

### CanReadMessage

```csharp
public extern bool CanReadMessage { get; }
```

True when at least one received message is available. _(inherited)_

### WriteErrorCount

```csharp
public extern int WriteErrorCount { get; }
```

Current transmit error counter (TEC). _(inherited)_

### ReadErrorCount

```csharp
public extern int ReadErrorCount { get; }
```

Current receive error counter (REC). _(inherited)_

### SourceClock

```csharp
public extern int SourceClock { get; }
```

Source clock feeding the CAN prescaler, in Hz. _(inherited)_

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

### WriteMessages(CanMessage[] messages, int offset, int count)

```csharp
public extern int WriteMessages(CanMessage[] messages, int offset, int count)
```

Queues a slice of messages for transmission. Returns count actually queued. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `messages` | `CanMessage[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### ReadMessages(CanMessage[] messages, int offset, int count)

```csharp
public extern int ReadMessages(CanMessage[] messages, int offset, int count)
```

Dequeues up to `count` received messages. Returns count actually read. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `messages` | `CanMessage[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### SetNominalBitTiming(CanBitTiming bitTiming)

```csharp
public extern void SetNominalBitTiming(CanBitTiming bitTiming)
```

Configures arbitration-phase bit timing. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `bitTiming` | `CanBitTiming` |  |

### SetDataBitTiming(CanBitTiming bitTiming)

```csharp
public extern void SetDataBitTiming(CanBitTiming bitTiming)
```

Configures CAN-FD data-phase bit timing. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `bitTiming` | `CanBitTiming` |  |

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

### AddFilter(Filter.IdType idType, Filter.FilterType filterType, uint id1, uint id2)

```csharp
public extern void AddFilter(Filter.IdType idType, Filter.FilterType filterType, uint id1, uint id2)
```

Installs an acceptance filter. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `idType` | `Filter.IdType` |  |
| `filterType` | `Filter.FilterType` |  |
| `id1` | `uint` |  |
| `id2` | `uint` |  |

### RejectRemoteFrame(Filter.IdType idType)

```csharp
public extern void RejectRemoteFrame(Filter.IdType idType)
```

Filters out RTR frames of the given ID width. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `idType` | `Filter.IdType` |  |

### ClearFilter()

```csharp
public extern void ClearFilter()
```

Removes every installed filter. _(inherited)_

## Events

### MessageReceived

```csharp
public event MessageReceivedEventHandler MessageReceived
```

Raised when messages arrive. _(inherited)_

### ErrorReceived

```csharp
public event ErrorReceivedEventHandler ErrorReceived
```

Raised when a frame/parity/overrun error is detected. _(inherited)_
