---
title: "GpioPinDriveMode Enum"
sidebar_label: "GpioPinDriveMode"
---

# GpioPinDriveMode Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`

Electrical drive mode applied to a `GpioPin`. Not every mode is available on every pin — call `GpioPin.IsDriveModeSupported(GpioPinDriveMode)` before `GpioPin.SetDriveMode(GpioPinDriveMode)` when in doubt.

```csharp
public enum GpioPinDriveMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Input` | `0` | High-impedance input with no internal resistor. |
| `Output` | `1` | Push-pull output. The pin actively drives both high and low. |
| `InputPullUp` | `2` | Input with the internal pull-up resistor enabled. |
| `InputPullDown` | `3` | Input with the internal pull-down resistor enabled. |
| `OutputOpenDrain` | `4` | Open-drain output: the pin actively pulls low and floats when set high. |
