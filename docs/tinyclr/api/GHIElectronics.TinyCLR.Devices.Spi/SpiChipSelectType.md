---
title: "SpiChipSelectType Enum"
sidebar_label: "SpiChipSelectType"
---

# SpiChipSelectType Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`

How chip-select is driven.

```csharp
public enum SpiChipSelectType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No chip-select line is asserted by the controller. |
| `Gpio` | `1` | Chip-select is driven by a user-supplied `GpioPin`. |
