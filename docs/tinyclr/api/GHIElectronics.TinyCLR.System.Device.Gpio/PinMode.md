---
title: "PinMode Enum"
sidebar_label: "PinMode"
---

# PinMode Enum

**Namespace:** `System.Device.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.System.Device.Gpio`

Drive mode applied to a GPIO pin. Mirrors .NET IoT's `System.Device.Gpio.PinMode`.

```csharp
public enum PinMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Input` | `0` | High-impedance input. |
| `Output` | `1` | Push-pull output. |
| `InputPullUp` | `2` | Input with internal pull-up. |
| `InputPullDown` | `3` | Input with internal pull-down. |
| `OutputOpenDrain` | `4` | Open-drain output. |
