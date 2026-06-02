---
title: "BaseDevice Class"
sidebar_label: "BaseDevice"
---

# BaseDevice Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Represents a USB device connected.

```csharp
public abstract class BaseDevice : IDisposable
```

## Constructors

### BaseDevice(uint id, byte interfaceIndex, DeviceType type)

```csharp
protected BaseDevice(uint id, byte interfaceIndex, DeviceType type)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `id` | `uint` |  |
| `interfaceIndex` | `byte` |  |
| `type` | `DeviceType` |  |

## Properties

### Connected

```csharp
public bool Connected { get; }
```

Whether or not the device is connected.

### Id

```csharp
public uint Id { get; }
```

The device id.

### InterfaceIndex

```csharp
public byte InterfaceIndex { get; }
```

The logical device interface index.

### Type

```csharp
public DeviceType Type { get; }
```

The device's type.

### VendorId

```csharp
public ushort VendorId { get; }
```

The device's vendor id.

### ProductId

```csharp
public ushort ProductId { get; }
```

The device's product id.

### PortNumber

```csharp
public byte PortNumber { get; }
```

The device's USB port number.

### WorkerInterval

```csharp
public virtual int WorkerInterval { get; set; }
```

How often the internal worker callback is called.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Disconnects and disposes the device.

### CheckEvents(object sender)

```csharp
protected virtual void CheckEvents(object sender)
```

Repeatedly called with a period defined by WorkerInterval. Used to poll the device for data and raise any desired events.

| Parameter | Type | Description |
|---|---|---|
| `sender` | `object` | Always null. |

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Disconnects and disposes the device.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Whether or not this is called from Dispose. |

### CheckObjectState(bool throwOnInvalid)

```csharp
protected bool CheckObjectState(bool throwOnInvalid = true)
```

Verifies that the object is connected and not disposed.

| Parameter | Type | Description |
|---|---|---|
| `throwOnInvalid` | `bool` | If the object is connected or disposed, whether or not to throw an exception. |

**Returns** `bool` — True if the object is connected and not disposed, false otherwise.

## Events

### Disconnected

```csharp
public event DisconnectedEventHandler Disconnected
```

The event is fired when the device disconnects.

## Fields

### disposed

```csharp
protected bool disposed
```

Whether or not the object has been disposed.
