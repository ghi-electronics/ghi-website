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

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

_No description available._

### DeviceState

```csharp
public DeviceState DeviceState { get; }
```

_No description available._

### WriteBufferSize

```csharp
public extern int WriteBufferSize { get; set; }
```

_No description available._

### ReadBufferSize

```csharp
public extern int ReadBufferSize { get; set; }
```

_No description available._

## Methods

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._

### BytesToRead(int streamIndex)

```csharp
public int BytesToRead(int streamIndex)
```

_No description available._

**Returns** `int`

### BytesToWrite(int streamIndex)

```csharp
public int BytesToWrite(int streamIndex)
```

_No description available._

**Returns** `int`

### Enable()

```csharp
public extern void Enable()
```

_No description available._

### Disable()

```csharp
public extern void Disable()
```

_No description available._

### SetActiveSetting(UsbClientSetting setting)

```csharp
public extern void SetActiveSetting(UsbClientSetting setting)
```

_No description available._

### Read(int streamIndex, byte[] data, int offset, int count)

```csharp
public extern int Read(int streamIndex, byte[] data, int offset, int count)
```

_No description available._

**Returns** `int`

### Write(int streamIndex, byte[] data, int offset, int count)

```csharp
public extern int Write(int streamIndex, byte[] data, int offset, int count)
```

_No description available._

**Returns** `int`

### Flush(int streamIndex)

```csharp
public extern void Flush(int streamIndex)
```

_No description available._

### ClearReadBuffer(int streamIndex)

```csharp
public extern void ClearReadBuffer(int streamIndex)
```

_No description available._

### ClearWriteBuffer(int streamIndex)

```csharp
public extern void ClearWriteBuffer(int streamIndex)
```

_No description available._

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

### SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)

```csharp
public extern void SetConfigurationDescriptor(Configuration.ConfigurationDescriptor[] configurationDescriptor)
```

_No description available._

### SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)

```csharp
public extern void SetStringDescriptor(Configuration.StringDescriptor[] stringDescriptor, uint index)
```

_No description available._

### SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)

```csharp
public extern void SetGenericDescriptor(Configuration.GenericDescriptor[] genericDescriptor)
```

_No description available._

## Events

### DataReceived

```csharp
public event DataReceivedEventHandler DataReceived
```

_No description available._

### DeviceStateChanged

```csharp
public event DeviceStateChangedEventHandler DeviceStateChanged
```

_No description available._
