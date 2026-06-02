---
title: "GHIElectronics.TinyCLR.Devices.Pwm"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Pwm

NuGet package containing **7** types across **3** namespaces (`GHIElectronics.TinyCLR.Devices.Pwm`, `GHIElectronics.TinyCLR.Devices.Pwm.Provider`, `System.Device.Pwm`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [PwmChannel](./PwmChannel.md) | `GHIElectronics.TinyCLR.Devices.Pwm` | A single PWM channel opened from a `PwmController`. Configure `Polarity` and duty cycle, then call `Start` to begin driving the output. |
| [PwmChannel](./PwmChannel_2.md) | `System.Device.Pwm` |  |
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
| [PwmPulsePolarity](./PwmPulsePolarity_2.md) | `System.Device.Pwm` |  |
