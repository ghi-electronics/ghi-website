---
title: "ICanControllerProvider Interface"
sidebar_label: "ICanControllerProvider"
---

# ICanControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Can.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Can`

Provider contract for a CAN controller.

```csharp
public interface ICanControllerProvider : IDisposable
```

## Properties

### WriteBufferSize

```csharp
int WriteBufferSize { get; set; }
```

Size of the transmit message queue.

### ReadBufferSize

```csharp
int ReadBufferSize { get; set; }
```

Size of the receive message queue.

### MessagesToWrite

```csharp
int MessagesToWrite { get; }
```

Messages currently queued for transmission.

### MessagesToRead

```csharp
int MessagesToRead { get; }
```

Messages currently available to read.

### CanWriteMessage

```csharp
bool CanWriteMessage { get; }
```

True when the transmit queue has room.

### CanReadMessage

```csharp
bool CanReadMessage { get; }
```

True when at least one received message is available.

### WriteErrorCount

```csharp
int WriteErrorCount { get; }
```

Current transmit error counter (TEC).

### ReadErrorCount

```csharp
int ReadErrorCount { get; }
```

Current receive error counter (REC).

### SourceClock

```csharp
int SourceClock { get; }
```

Source clock feeding the CAN prescaler, in Hz.

## Methods

### Enable()

```csharp
void Enable()
```

Powers on the controller.

### Disable()

```csharp
void Disable()
```

Powers off the controller.

### WriteMessages(CanMessage[] messages, int offset, int count)

```csharp
int WriteMessages(CanMessage[] messages, int offset, int count)
```

Queues a slice of messages for transmission. Returns count actually queued.

| Parameter | Type | Description |
|---|---|---|
| `messages` | `CanMessage[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### ReadMessages(CanMessage[] messages, int offset, int count)

```csharp
int ReadMessages(CanMessage[] messages, int offset, int count)
```

Dequeues up to `count` received messages. Returns count actually read.

| Parameter | Type | Description |
|---|---|---|
| `messages` | `CanMessage[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### SetNominalBitTiming(CanBitTiming bitTiming)

```csharp
void SetNominalBitTiming(CanBitTiming bitTiming)
```

Configures arbitration-phase bit timing.

| Parameter | Type | Description |
|---|---|---|
| `bitTiming` | `CanBitTiming` |  |

### SetDataBitTiming(CanBitTiming bitTiming)

```csharp
void SetDataBitTiming(CanBitTiming bitTiming)
```

Configures CAN-FD data-phase bit timing.

| Parameter | Type | Description |
|---|---|---|
| `bitTiming` | `CanBitTiming` |  |

### AddFilter(Filter.IdType idType, Filter.FilterType filterType, uint id1, uint id2)

```csharp
void AddFilter(Filter.IdType idType, Filter.FilterType filterType, uint id1, uint id2)
```

Installs an acceptance filter.

| Parameter | Type | Description |
|---|---|---|
| `idType` | `Filter.IdType` |  |
| `filterType` | `Filter.FilterType` |  |
| `id1` | `uint` |  |
| `id2` | `uint` |  |

### RejectRemoteFrame(Filter.IdType idType)

```csharp
void RejectRemoteFrame(Filter.IdType idType)
```

Filters out RTR frames of the given ID width.

| Parameter | Type | Description |
|---|---|---|
| `idType` | `Filter.IdType` |  |

### ClearFilter()

```csharp
void ClearFilter()
```

Removes every installed filter.

### ClearWriteBuffer()

```csharp
void ClearWriteBuffer()
```

Empties the transmit queue.

### ClearReadBuffer()

```csharp
void ClearReadBuffer()
```

Empties the receive queue.

## Events

### MessageReceived

```csharp
event MessageReceivedEventHandler MessageReceived
```

Raised when messages arrive.

### ErrorReceived

```csharp
event ErrorReceivedEventHandler ErrorReceived
```

Raised when a bus error or state change is observed.
