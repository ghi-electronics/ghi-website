---
title: "UsbClientControllerApiWrapper Class"
sidebar_label: "UsbClientControllerApiWrapper"
---

# UsbClientControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient.Provider`

_No description available._

```csharp
public class UsbClientControllerApiWrapper : IUsbClientControllerProvider
```

## Constructors

### UsbClientControllerApiWrapper(NativeApi api)

```csharp
public UsbClientControllerApiWrapper(NativeApi api)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` |  |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor. _(inherited)_

### DeviceState

```csharp
public DeviceState DeviceState { get; }
```

_No description available._

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

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### BytesToRead(int streamIndex)

```csharp
public int BytesToRead(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

**Returns** `int`

### BytesToWrite(int streamIndex)

```csharp
public int BytesToWrite(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

**Returns** `int`

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

### SetActiveSetting(UsbClientSetting setting)

```csharp
public extern void SetActiveSetting(UsbClientSetting setting)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `setting` | `UsbClientSetting` |  |

### Read(int streamIndex, byte[] data, int offset, int count)

```csharp
public extern int Read(int streamIndex, byte[] data, int offset, int count)
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
public extern int Write(int streamIndex, byte[] data, int offset, int count)
```

Writes `length` bytes; optional trailing break of `breakDuration`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### Flush(int streamIndex)

```csharp
public extern void Flush(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

### ClearReadBuffer(int streamIndex)

```csharp
public extern void ClearReadBuffer(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

### ClearWriteBuffer(int streamIndex)

```csharp
public extern void ClearWriteBuffer(int streamIndex)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `streamIndex` | `int` |  |

### GetControlPacketSize()

```csharp
public extern int GetControlPacketSize()
```

_No description available._

**Returns** `int`

### GetEndpointMap()

```csharp
public extern ushort GetEndpointMap()
```

_No description available._

**Returns** `ushort`

### SetDeviceDescriptor(Configuration.DeviceDescriptor[] deviceDescriptor)

```csharp
public extern void SetDeviceDescriptor(Configuration.DeviceDescriptor[] deviceDescriptor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `deviceDescriptor` | `Configuration.DeviceDescriptor[]` |  |

### SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)

```csharp
public extern void SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `configurationDescriptor` | `Configuration.ConfigurationDescriptor[]` |  |

### SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)

```csharp
public extern void SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `stringDescriptor` | `Configuration.StringDescriptor[]` |  |
| `index` | `uint` |  |

### SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)

```csharp
public extern void SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `genericDescriptor` | `Configuration.GenericDescriptor[]` |  |

## Events

### DataReceived

```csharp
public event DataReceivedEventHandler DataReceived
```

Raised when receive data becomes available. _(inherited)_

### DeviceStateChanged

```csharp
public event DeviceStateChangedEventHandler DeviceStateChanged
```

_No description available._
