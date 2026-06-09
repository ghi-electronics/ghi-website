---
title: "RawDevice Class"
sidebar_label: "RawDevice"
---

# RawDevice Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

Represent a USB device.

```csharp
public class RawDevice
```

## Constructors

### RawDevice(UsbClientController usbClientController, UsbClientSetting usbClientSetting)

```csharp
public RawDevice(UsbClientController usbClientController, UsbClientSetting usbClientSetting)
```

Creates a new raw device.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` | UsbClient controller. |
| `usbClientSetting` | `UsbClientSetting` | UsbClient setting |

## Properties

### MaxEndpoint

```csharp
public static int MaxEndpoint { get; }
```

The maximum number of endpoints.

### MaxStreams

```csharp
public static int MaxStreams { get; }
```

The maximum number of streams.

### VendorId

```csharp
public ushort VendorId { get; }
```

The vendor id of the device.

### ProductId

```csharp
public ushort ProductId { get; }
```

The product id of the device.

### BcdUsb

```csharp
public ushort BcdUsb { get; }
```

The version of the device.

### BcdDevice

```csharp
public ushort BcdDevice { get; }
```

The version of the device.

### MaximumPower

```csharp
public ushort MaximumPower { get; }
```

The maximum power the device might need.

### Manufacturer

```csharp
public string Manufacturer { get; }
```

The manufacturer of the device.

### Product

```csharp
public string Product { get; }
```

The product name.

### SerialNumber

```csharp
public string SerialNumber { get; }
```

The serial number of the device.

### DeviceState

```csharp
public DeviceState DeviceState { get; }
```

_No description available._

## Methods

### ReserveNewEndpoint()

```csharp
public int ReserveNewEndpoint()
```

Gets the next available endpoint.

**Returns** `int` — The endpoint number.

### ReserveNewEndpoint(int endpoint)

```csharp
public void ReserveNewEndpoint(int endpoint)
```

Reserves the given endpoint.

| Parameter | Type | Description |
|---|---|---|
| `endpoint` | `int` | The specific endpoint number to reserve. |

### AddDescriptor(Configuration.Descriptor descriptor)

```csharp
public void AddDescriptor(Configuration.Descriptor descriptor)
```

Adds a descriptor to the device.

| Parameter | Type | Description |
|---|---|---|
| `descriptor` | `Configuration.Descriptor` | The descriptor to add. |

### AddInterface(Configuration.UsbInterface usbInterface, string interfaceString)

```csharp
public byte AddInterface(Configuration.UsbInterface usbInterface, string interfaceString)
```

Adds an interface to the device.

| Parameter | Type | Description |
|---|---|---|
| `usbInterface` | `Configuration.UsbInterface` | The interface. |
| `interfaceString` | `string` | The interface name. |

**Returns** `byte` — The assigned interface index.

### Enable()

```csharp
public virtual void Enable()
```

Re-enables interrupts after a matching `Disable`. _(inherited)_

### Disable()

```csharp
public virtual void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### CreateStream(int writeEndpoint, int readEndpoint)

```csharp
public RawStream CreateStream(int writeEndpoint, int readEndpoint)
```

Creates a steam for reading and writing to the device.

| Parameter | Type | Description |
|---|---|---|
| `writeEndpoint` | `int` | The write endpoint. Use RawStream.NullEndpoint if not available. |
| `readEndpoint` | `int` | The read endpoint. Use RawStream.NullEndpoint if not available. |

**Returns** `RawStream` — The new stream.

### SetInterfaceMap(byte interfaceIndex, byte data1, byte data2, byte data3)

```csharp
public void SetInterfaceMap(byte interfaceIndex, byte data1, byte data2, byte data3)
```

_No description available._

### CreateStream(int index, RawDevice parent)

```csharp
protected virtual RawStream CreateStream(int index, RawDevice parent)
```

Creates a new instance of the stream type for this device type.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The index of the stream |
| `parent` | `RawDevice` | The owning raw device. |

**Returns** `RawStream` — The new stream.

## Events

### DeviceStateChanged

```csharp
public event DeviceStateChangedEventHandler DeviceStateChanged
```

_No description available._

## Fields

### MAX_POWER

```csharp
public const ushort MAX_POWER
```

_No description available._

### GHI_VID

```csharp
public const ushort GHI_VID
```

_No description available._
