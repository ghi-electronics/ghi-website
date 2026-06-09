---
title: "GHIElectronics.TinyCLR.System.Device.Gpio"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.System.Device.Gpio NuGet</h1>

:::info
The standard, .NET-compatible `System.Device.Gpio` API for TinyCLR. It ships inside the **[GHIElectronics.TinyCLR.Devices.Gpio](../GHIElectronics.TinyCLR.Devices.Gpio/index.md)** NuGet — there is no separate package to install.
:::

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [GpioController](./GpioController.md) | `System.Device.Gpio` | .NET IoT-style GPIO controller. Same surface as `System.Device.Gpio.GpioController`; internally routes through TinyCLR's GPIO HAL via `TinyClrGpioDriver`. |
| [GpioDriver](./GpioDriver.md) | `System.Device.Gpio` | Abstract GPIO driver per .NET IoT. Implemented by `TinyClrGpioDriver` for TinyCLR hardware. |
| [LibGpiodDriver](./LibGpiodDriver.md) | `System.Device.Gpio.Drivers` | Alias of `TinyClrGpioDriver` for source-compatibility with Linux .NET IoT samples that reference `LibGpiodDriver`. |
| [PinValueChangedEventArgs](./PinValueChangedEventArgs.md) | `System.Device.Gpio` | Arguments for the .NET IoT pin-change callback. |
| [TinyClrGpioDriver](./TinyClrGpioDriver.md) | `System.Device.Gpio` | TinyCLR-backed implementation of `GpioDriver`. Routes `GpioController` calls to `GHIElectronics.TinyCLR.Devices.Gpio.GpioController`. |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [WaitForEventResult](./WaitForEventResult.md) | `System.Device.Gpio` | Result of a `GpioController.WaitForEvent(int, PinEventTypes, TimeSpan)` call. Same shape as .NET IoT. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [PinEventTypes](./PinEventTypes.md) | `System.Device.Gpio` | Edge selector for `GpioController` change notifications. Same shape as .NET IoT. |
| [PinMode](./PinMode.md) | `System.Device.Gpio` | Drive mode applied to a GPIO pin. Mirrors .NET IoT's `System.Device.Gpio.PinMode`. |
| [PinNumberingScheme](./PinNumberingScheme.md) | `System.Device.Gpio` | How `GpioController` interprets pin numbers — TinyCLR uses `Logical`. |
| [PinValue](./PinValue.md) | `System.Device.Gpio` | Logical pin level. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [PinChangeEventHandler](./PinChangeEventHandler.md) | `System.Device.Gpio` | Callback signature for .NET IoT pin-change notifications. |
