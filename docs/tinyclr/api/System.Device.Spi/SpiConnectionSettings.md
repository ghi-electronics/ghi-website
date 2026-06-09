---
title: "SpiConnectionSettings Class"
sidebar_label: "SpiConnectionSettings"
---

# SpiConnectionSettings Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `System.Device.Spi`<br/>**Namespace:** `System.Device.Spi`

Per-device SPI settings in the standard `System.Device.Spi` shape. TinyCLR maps these onto its native SPI driver via `SpiDevice.Create(SpiConnectionSettings)`.

```csharp
public sealed class SpiConnectionSettings
```

## Constructors

### SpiConnectionSettings(int busId, int chipSelectLine)

```csharp
public SpiConnectionSettings(int busId, int chipSelectLine)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `busId` | `int` |  |
| `chipSelectLine` | `int` |  |

## Properties

### BusId

```csharp
public int BusId { get; }
```

_No description available._

### ChipSelectLine

```csharp
public int ChipSelectLine { get; set; }
```

The GPIO pin that drives chip-select when `ChipSelectType` is `SpiChipSelectType.Gpio`. _(inherited)_

### ClockFrequency

```csharp
public int ClockFrequency { get; set; }
```

SCK frequency in Hz the controller is asked to use. _(inherited)_

### DataBitLength

```csharp
public int DataBitLength { get; set; }
```

Frame width in bits. Fixed at 8 in this build. _(inherited)_

### DataFlow

```csharp
public DataFlow DataFlow { get; set; }
```

_No description available._

### Mode

```csharp
public SpiMode Mode { get; set; }
```

SPI mode (clock polarity + phase). See `SpiMode`. _(inherited)_
