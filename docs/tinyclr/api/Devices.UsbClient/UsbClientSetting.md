---
title: "UsbClientSetting Class"
sidebar_label: "UsbClientSetting"
---

# UsbClientSetting Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

The settings used to configure a USB client device.

```csharp
public class UsbClientSetting
```

## Properties

### Mode

```csharp
public UsbClientMode Mode { get; set; }
```

The type of device to emulate.

### ManufactureName

```csharp
public string ManufactureName { get; set; }
```

The manufacturer name.

### ProductName

```csharp
public string ProductName { get; set; }
```

The product name.

### SerialNumber

```csharp
public string SerialNumber { get; set; }
```

The serial number.

### Guid

```csharp
public string Guid { get; set; }
```

The interface GUID, used by WinUsb devices.

### ProductId

```csharp
public ushort ProductId { get; set; }
```

The product id.

### VendorId

```csharp
public ushort VendorId { get; set; }
```

The vendor id.

### BcdUsb

```csharp
public ushort BcdUsb { get; set; }
```

The USB specification release number.

### BcdDevice

```csharp
public ushort BcdDevice { get; set; }
```

The device release number.

### MaxPower

```csharp
public ushort MaxPower { get; set; }
```

The maximum power the device uses, in 2 mA units.

### InterfaceName

```csharp
public string InterfaceName { get; set; }
```

The interface name.
