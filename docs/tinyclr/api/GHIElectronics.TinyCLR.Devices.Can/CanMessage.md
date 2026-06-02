---
title: "CanMessage Class"
sidebar_label: "CanMessage"
---

# CanMessage Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Can` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Can`

One CAN (or CAN-FD) frame. Set `ArbitrationId`, optionally `ExtendedId` for 29-bit IDs, and the payload via `Data` / `Length`. For CAN-FD, set `FdCan` and optionally `BitRateSwitch`.

```csharp
public class CanMessage
```

## Constructors

### CanMessage()

```csharp
public CanMessage() : this(0, new byte[8], 0, 0, false, false)
```

Constructs an empty 8-byte classic CAN message with ID 0.

### CanMessage(int arbitrationId)

```csharp
public CanMessage(int arbitrationId) : this(arbitrationId, null, 0, 0)
```

Constructs an empty message with the given arbitration ID.

| Parameter | Type | Description |
|---|---|---|
| `arbitrationId` | `int` |  |

### CanMessage(int arbitrationId, byte[] data)

```csharp
public CanMessage(int arbitrationId, byte[] data) : this(arbitrationId, data, 0, data != null ? data.Length : 0)
```

Constructs a message carrying `data` in full.

| Parameter | Type | Description |
|---|---|---|
| `arbitrationId` | `int` |  |
| `data` | `byte[]` |  |

### CanMessage(int arbitrationId, byte[] data, int offset, int count)

```csharp
public CanMessage(int arbitrationId, byte[] data, int offset, int count) : this(arbitrationId, data, offset, count, false, false)
```

Constructs a message from a slice of `data`.

| Parameter | Type | Description |
|---|---|---|
| `arbitrationId` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

### CanMessage(int arbitrationId, byte[] data, int offset, int count, bool isRemoteTransmissionRequesti, bool isExtendedId)

```csharp
public CanMessage(int arbitrationId, byte[] data, int offset, int count, bool isRemoteTransmissionRequesti, bool isExtendedId) : this(arbitrationId, data, offset, count, isRemoteTransmissionRequesti, isExtendedId, false, false)
```

Constructs a message with explicit RTR and extended-ID flags.

| Parameter | Type | Description |
|---|---|---|
| `arbitrationId` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `isRemoteTransmissionRequesti` | `bool` |  |
| `isExtendedId` | `bool` |  |

### CanMessage(int arbitrationId, byte[] data, int offset, int count, bool isRemoteTransmissionRequesti, bool isExtendedId, bool isFdCan)

```csharp
public CanMessage(int arbitrationId, byte[] data, int offset, int count, bool isRemoteTransmissionRequesti, bool isExtendedId, bool isFdCan) : this(arbitrationId, data, offset, count, isRemoteTransmissionRequesti, isExtendedId, isFdCan, false)
```

Constructs a possibly-CAN-FD message.

| Parameter | Type | Description |
|---|---|---|
| `arbitrationId` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `isRemoteTransmissionRequesti` | `bool` |  |
| `isExtendedId` | `bool` |  |
| `isFdCan` | `bool` |  |

### CanMessage(int arbitrationId, byte[] data, int offset, int count, bool isRemoteTransmissionRequesti, bool isExtendedId, bool isFdCan, bool isBitRateSwitch)

```csharp
public CanMessage(int arbitrationId, byte[] data, int offset, int count, bool isRemoteTransmissionRequesti, bool isExtendedId, bool isFdCan, bool isBitRateSwitch)
```

Constructs a fully specified message including bit-rate switch.

| Parameter | Type | Description |
|---|---|---|
| `arbitrationId` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `isRemoteTransmissionRequesti` | `bool` |  |
| `isExtendedId` | `bool` |  |
| `isFdCan` | `bool` |  |
| `isBitRateSwitch` | `bool` |  |

## Properties

### ArbitrationId

```csharp
public int ArbitrationId { get; set; }
```

The CAN arbitration ID. Limited to 11 bits when `ExtendedId` is false, 29 bits otherwise.

### ExtendedId

```csharp
public bool ExtendedId { get; set; }
```

True when `ArbitrationId` is a 29-bit extended identifier.

### Timestamp

```csharp
public DateTime Timestamp { get; set; }
```

For received messages: driver-captured arrival time. For TX: not used.

### BitRateSwitch

```csharp
public bool BitRateSwitch { get; set; }
```

CAN-FD only: switch to data-phase bit timing for the payload.

### ErrorStateIndicator

```csharp
public ErrorStateIndicator ErrorStateIndicator { get; }
```

Reports whether a received message was sent by an error-active or error-passive node.

### RemoteTransmissionRequest

```csharp
public bool RemoteTransmissionRequest { get; set; }
```

True when this is a remote-transmission-request (RTR) frame. Not allowed in CAN-FD.

### Length

```csharp
public int Length { get; set; }
```

Payload length in bytes. 0..8 for classic CAN; for CAN-FD also accepts 12, 16, 20, 24, 32, 48, or 64. Larger classic values are clamped to 8.

### FdCan

```csharp
public bool FdCan { get; set; }
```

True if this is a CAN-FD (flexible-data) frame.

### Data

```csharp
public byte[] Data { get; set; }
```

The payload buffer. Up to 64 bytes for CAN-FD, 8 for classic CAN.
