---
title: "I2cConnectionSettings Class"
sidebar_label: "I2cConnectionSettings"
---

# I2cConnectionSettings Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Assembly:** `System.Device.I2c`<br/>**Namespace:** `System.Device.I2c`

Per-device I²C settings in the standard `System.Device.I2c` shape. TinyCLR maps these onto its native I²C driver via `I2cDevice.Create(I2cConnectionSettings)`.

```csharp
public sealed class I2cConnectionSettings
```

## Constructors

### I2cConnectionSettings(int busId, int deviceAddress)

```csharp
public I2cConnectionSettings(int busId, int deviceAddress)
```

Builds a 7-bit settings object with the given role (master/slave). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `busId` | `int` |  |
| `deviceAddress` | `int` |  |

## Properties

### BusId

```csharp
public int BusId { get; }
```

_No description available._

### DeviceAddress

```csharp
public int DeviceAddress { get; set; }
```

_No description available._

### BusSpeed

```csharp
public I2cBusSpeed BusSpeed { get; set; }
```

Bus speed in Hz (e.g. 100_000 for standard, 400_000 for fast mode). _(inherited)_
