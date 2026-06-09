---
title: "RawDevice Class"
sidebar_label: "RawDevice"
---

# RawDevice Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Provides low level access functionalities for the connected USB device. This is useful if there is not already a predefined driver for that device.

```csharp
public class RawDevice : BaseDevice
```

## Methods

### OpenPipe(Descriptors.Endpoint endpoint)

```csharp
public RawDevice.Pipe OpenPipe(Descriptors.Endpoint endpoint)
```

Opens a new communication pipe.

| Parameter | Type | Description |
|---|---|---|
| `endpoint` | `Descriptors.Endpoint` | The descriptor for the communication endpoint. |

**Returns** `RawDevice.Pipe` — The new pipe.

### SendSetupPacket(byte requestType, byte request, ushort value, ushort index)

```csharp
public void SendSetupPacket(byte requestType, byte request, ushort value, ushort index)
```

Sends a USB setup packet.

| Parameter | Type | Description |
|---|---|---|
| `requestType` | `byte` | The request type, recipient, and direction. |
| `request` | `byte` | The request to make. |
| `value` | `ushort` | The value of the request. |
| `index` | `ushort` | The index of the request. |

### SendSetupPacket(byte requestType, byte request, ushort value, ushort index, byte[] data, int dataOffset, int dataCount)

```csharp
public void SendSetupPacket(byte requestType, byte request, ushort value, ushort index, byte[] data, int dataOffset, int dataCount)
```

Sends a USB setup packet.

| Parameter | Type | Description |
|---|---|---|
| `requestType` | `byte` | The request type, recipient, and direction. |
| `request` | `byte` | The request to make. |
| `value` | `ushort` | The value of the request. |
| `index` | `ushort` | The index of the request. |
| `data` | `byte[]` | The data to receive. |
| `dataOffset` | `int` | The offset into data at which to receive the data. |
| `dataCount` | `int` | The number of bytes to receive into data starting at offset. |

### GetDeviceDescriptor()

```csharp
public Descriptors.Device GetDeviceDescriptor()
```

Gets the device descriptor.

**Returns** `Descriptors.Device` — The device descriptor.

### GetConfigurationDescriptor(byte configurationIndex)

```csharp
public Descriptors.Configuration GetConfigurationDescriptor(byte configurationIndex)
```

Gets the configuration descriptor.

| Parameter | Type | Description |
|---|---|---|
| `configurationIndex` | `byte` | The configuration index. |

**Returns** `Descriptors.Configuration` — The configuration descriptor.

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Disconnects and disposes the device.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Whether or not this is called from Dispose. |
