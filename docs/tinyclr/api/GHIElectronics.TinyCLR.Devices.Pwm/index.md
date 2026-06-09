---
title: "GHIElectronics.TinyCLR.Devices.Pwm"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Pwm NuGet</h1>

:::tip
This NuGet also includes the standard, .NET-compatible **`System.Device.Pwm`** API — see **[GHIElectronics.TinyCLR.System.Device.Pwm](../GHIElectronics.TinyCLR.System.Device.Pwm/index.md)**.
:::

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [PwmChannel](./PwmChannel.md) | `GHIElectronics.TinyCLR.Devices.Pwm` | A single PWM channel opened from a `PwmController`. Configure `Polarity` and duty cycle, then call `Start` to begin driving the output. |
| [PwmController](./PwmController.md) | `GHIElectronics.TinyCLR.Devices.Pwm` | Represents a PWM peripheral. Set the frequency via `SetDesiredFrequency(double)`, open one or more channels with `OpenChannel(int)`, then drive each channel's duty cycle. |
| [PwmControllerApiWrapper](./PwmControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Pwm.Provider` | Concrete `IPwmControllerProvider` backed by the native TinyCLR PWM HAL. Constructed internally by `PwmController`; you don't normally need to use this type directly. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IPwmControllerProvider](./IPwmControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Pwm.Provider` | Provider contract for a PWM controller. Most users call `PwmController` / `PwmChannel` directly; implement this interface only when supplying a custom or virtual PWM. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [PwmPulsePolarity](./PwmPulsePolarity.md) | `GHIElectronics.TinyCLR.Devices.Pwm` | Defines which level represents the "active" portion of the PWM pulse. |
