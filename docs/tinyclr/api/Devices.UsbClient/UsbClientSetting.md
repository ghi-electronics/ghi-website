---
title: "UsbClientSetting Class"
sidebar_label: "UsbClientSetting"
---

# UsbClientSetting Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`

_No description available._

```csharp
public class UsbClientSetting
```

## Properties

### Mode

```csharp
public UsbClientMode Mode { get; set; }
```

SPI mode (clock polarity + phase). See `SpiMode`. _(inherited)_

### ManufactureName

```csharp
public string ManufactureName { get; set; }
```

_No description available._

### ProductName

```csharp
public string ProductName { get; set; }
```

gets the Product Name / Read "Identity Object" Class Code 0x01 - Attribute ID 7 _(inherited)_

### SerialNumber

```csharp
public string SerialNumber { get; set; }
```

gets the Serial number / Read "Identity Object" Class Code 0x01 - Attribute ID 6 _(inherited)_

### Guid

```csharp
public string Guid { get; set; }
```

_No description available._

### ProductId

```csharp
public ushort ProductId { get; set; }
```

The device's product id. _(inherited)_

### VendorId

```csharp
public ushort VendorId { get; set; }
```

The device's vendor id. _(inherited)_

### BcdUsb

```csharp
public ushort BcdUsb { get; set; }
```

The version of the device. _(inherited)_

### BcdDevice

```csharp
public ushort BcdDevice { get; set; }
```

The version of the device. _(inherited)_

### MaxPower

```csharp
public ushort MaxPower { get; set; }
```

The maximum power consumption in 2mA units. _(inherited)_

### InterfaceName

```csharp
public string InterfaceName { get; set; }
```

_No description available._
