---
title: "SpiConnectionSettings Class"
sidebar_label: "SpiConnectionSettings"
---

# SpiConnectionSettings Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`

Per-device SPI bus settings: clock, mode, chip select, etc.

```csharp
public class SpiConnectionSettings
```

## Properties

### ChipSelectType

```csharp
public SpiChipSelectType ChipSelectType { get; set; }
```

How the chip-select line is driven (none or via a managed `GpioPin`).

### ChipSelectLine

```csharp
public GpioPin ChipSelectLine { get; set; }
```

The GPIO pin that drives chip-select when `ChipSelectType` is `SpiChipSelectType.Gpio`.

### ClockFrequency

```csharp
public int ClockFrequency { get; set; }
```

SCK frequency in Hz the controller is asked to use.

### DataBitLength

```csharp
public int DataBitLength { get; }
```

Frame width in bits. Fixed at 8 in this build.

### DataFrameFormat

```csharp
public SpiDataFrame DataFrameFormat { get; set; }
```

Bit ordering on the wire.

### Mode

```csharp
public SpiMode Mode { get; set; }
```

SPI mode (clock polarity + phase). See `SpiMode`.

### ChipSelectSetupTime

```csharp
public TimeSpan ChipSelectSetupTime { get; set; }
```

Delay between asserting chip-select and starting the first clock.

### ChipSelectHoldTime

```csharp
public TimeSpan ChipSelectHoldTime { get; set; }
```

Delay between the last clock and deasserting chip-select.

### ChipSelectActiveState

```csharp
public bool ChipSelectActiveState { get; set; }
```

The level that means "selected" — false = active-low (most chips), true = active-high.
