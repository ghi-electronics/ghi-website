---
title: "AdcChannelMode Enum"
sidebar_label: "AdcChannelMode"
---

# AdcChannelMode Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Adc` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Adc`

How an ADC channel sees its input.

```csharp
public enum AdcChannelMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `SingleEnded` | `0` | Channel input is referenced to ground. |
| `Differential` | `1` | Channel input is the difference between two pins. |
