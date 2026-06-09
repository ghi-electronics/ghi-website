---
title: "GpioPinEdge Enum"
sidebar_label: "GpioPinEdge"
---

# GpioPinEdge Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`

Which edges trigger the `GpioPin.ValueChanged` event. The flags can be combined to fire on both edges.

```csharp
public enum GpioPinEdge
```

## Fields

| Name | Value | Description |
|---|---|---|
| `FallingEdge` | `1` | Fire when the input transitions from high to low. |
| `RisingEdge` | `2` | Fire when the input transitions from low to high. |
