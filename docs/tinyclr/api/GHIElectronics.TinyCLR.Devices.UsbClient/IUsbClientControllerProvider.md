---
title: "IUsbClientControllerProvider Interface"
sidebar_label: "IUsbClientControllerProvider"
---

# IUsbClientControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`

_No description available._

```csharp
public interface IUsbClientControllerProvider : IDisposable
```

## Properties

### WriteBufferSize

```csharp
int WriteBufferSize { get; set; }
```

Size in bytes of the transmit buffer. _(inherited)_

### ReadBufferSize

```csharp
int ReadBufferSize { get; set; }
```

Size in bytes of the receive buffer. _(inherited)_

### DeviceState

```csharp
DeviceState DeviceState { get; }
```

_No description available._

## Methods

### BytesToRead(int streamIndex)

```csharp
int BytesToRead(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

**Returns** `int`

### BytesToWrite(int streamIndex)

```csharp
int BytesToWrite(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

**Returns** `int`

### Enable()

```csharp
void Enable()
```

Re-enables interrupts after a matching `Disable`. _(inherited)_

### Disable()

```csharp
void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

### SetActiveSetting(UsbClientSetting setting)

```csharp
void SetActiveSetting(UsbClientSetting setting)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `setting` | `UsbClientSetting` |  |

### SetDeviceDescriptor(Configuration.DeviceDescriptor[] deviceDescriptor)

```csharp
void SetDeviceDescriptor(Configuration.DeviceDescriptor[] deviceDescriptor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `deviceDescriptor` | `Configuration.DeviceDescriptor[]` |  |

### SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)

```csharp
void SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `configurationDescriptor` | `Configuration.ConfigurationDescriptor[]` |  |

### SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)

```csharp
void SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `stringDescriptor` | `Configuration.StringDescriptor[]` |  |
| `index` | `uint` |  |

### SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)

```csharp
void SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `genericDescriptor` | `Configuration.GenericDescriptor[]` |  |

### Read(int streamIndex, byte[] data, int offset, int count)

```csharp
int Read(int streamIndex, byte[] data, int offset, int count)
```

Captures a slice of inter-edge intervals after waiting for `waitForState`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### Write(int streamIndex, byte[] data, int offset, int count)

```csharp
int Write(int streamIndex, byte[] data, int offset, int count)
```

Writes `length` bytes; optional trailing break of `breakDuration`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### GetControlPacketSize()

```csharp
int GetControlPacketSize()
```

_No description available._

**Returns** `int`

### GetEndpointMap()

```csharp
ushort GetEndpointMap()
```

_No description available._

**Returns** `ushort`

### ClearReadBuffer(int streamIndex)

```csharp
void ClearReadBuffer(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

### ClearWriteBuffer(int streamIndex)

```csharp
void ClearWriteBuffer(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

### Flush(int streamIndex)

```csharp
void Flush(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

## Events

### DataReceived

```csharp
event DataReceivedEventHandler DataReceived
```

Raised when receive data becomes available. _(inherited)_

### DeviceStateChanged

```csharp
event DeviceStateChangedEventHandler DeviceStateChanged
```

_No description available._
