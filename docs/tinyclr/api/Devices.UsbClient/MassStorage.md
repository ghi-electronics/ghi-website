---
title: "MassStorage Class"
sidebar_label: "MassStorage"
---

# MassStorage Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

This device emulates a mass storage. Your Micro Framework device will appear as a virtual mass storage device similar to a USB Drive. This works by exposing the storage connected to this device, such as SD card or USB sticks, to the host.

```csharp
public class MassStorage : RawDevice
```

## Constructors

### MassStorage(UsbClientController usbClientController)

```csharp
public MassStorage(UsbClientController usbClientController) : this(usbClientController, new UsbClientSetting()
```

Creates a new mass storage with default parameters.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` |  |

### MassStorage(UsbClientController usbClientController, UsbClientSetting usbClientSetting)

```csharp
public MassStorage(UsbClientController usbClientController, UsbClientSetting usbClientSetting) : base(usbClientController, usbClientSetting)
```

Creates a new mass storage.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` | USBClient controller. |
| `usbClientSetting` | `UsbClientSetting` | USBClient setting. |

## Properties

### MaximumSupportedLogicalUnits

```csharp
public static int MaximumSupportedLogicalUnits { get; }
```

The maximum number of logical units that any mass storage can support.

### LogicalUnitCount

```csharp
public int LogicalUnitCount { get; }
```

The number of logical units assocaited with this mass storage.

## Methods

### AttachLogicalUnit(IntPtr storage)

```csharp
public void AttachLogicalUnit(IntPtr storage)
```

Attaches a removable storage device.

| Parameter | Type | Description |
|---|---|---|
| `storage` | `IntPtr` | The storage device (hdc )to attach. |

### RemoveLogicalUnit(IntPtr storage)

```csharp
public void RemoveLogicalUnit(IntPtr storage)
```

Remove a removable storage device.

| Parameter | Type | Description |
|---|---|---|
| `storage` | `IntPtr` | The storage device (hdc )to attach. |

### Enable()

```csharp
public override void Enable()
```

Enable a removable storage device.

### Disable()

```csharp
public override void Disable()
```

Disable a removable storage device.
