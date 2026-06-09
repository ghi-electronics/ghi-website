---
title: "OutputSpeed Enum"
sidebar_label: "OutputSpeed"
---

# OutputSpeed Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`

Slew-rate / drive-strength setting for output pins.

```csharp
public enum OutputSpeed
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Low` | `0` | Slowest slew rate, lowest EMI. |
| `Medium` | `1` | Moderate slew rate. |
| `High` | `2` | Fast slew rate. |
| `VeryHigh` | `3` | Maximum slew rate (highest EMI). |
