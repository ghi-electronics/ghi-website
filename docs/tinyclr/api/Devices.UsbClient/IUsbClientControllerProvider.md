---
title: "IUsbClientControllerProvider Interface"
sidebar_label: "IUsbClientControllerProvider"
---

# IUsbClientControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient.Provider`

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

**Returns** `int`

### BytesToWrite(int streamIndex)

```csharp
int BytesToWrite(int streamIndex)
```

_No description available._

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

### SetDeviceDescriptor(Configuration.DeviceDescriptor[] deviceDescriptor)

```csharp
void SetDeviceDescriptor(Configuration.DeviceDescriptor[] deviceDescriptor)
```

_No description available._

### SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)

```csharp
void SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)
```

_No description available._

### SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)

```csharp
void SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)
```

_No description available._

### SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)

```csharp
void SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)
```

_No description available._

### Read(int streamIndex, byte[] data, int offset, int count)

```csharp
int Read(int streamIndex, byte[] data, int offset, int count)
```

Captures a slice of inter-edge intervals after waiting for `waitForState`. _(inherited)_

**Returns** `int`

### Write(int streamIndex, byte[] data, int offset, int count)

```csharp
int Write(int streamIndex, byte[] data, int offset, int count)
```

Writes `length` bytes; optional trailing break of `breakDuration`. _(inherited)_

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

### ClearWriteBuffer(int streamIndex)

```csharp
void ClearWriteBuffer(int streamIndex)
```

_No description available._

### Flush(int streamIndex)

```csharp
void Flush(int streamIndex)
```

_No description available._

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
