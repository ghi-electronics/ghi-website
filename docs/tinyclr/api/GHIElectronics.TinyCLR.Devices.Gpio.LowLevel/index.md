---
title: "GHIElectronics.TinyCLR.Devices.Gpio.LowLevel"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Gpio.LowLevel NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [LowLevelController](./LowLevelController.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | Low-level pin-mux helper. Lets a driver re-route or reconfigure pins at a level finer than the regular `GpioPin` API (slew rate, alternate function, etc.). Mostly used by peripheral library authors; ordinary apps don't need this. |
| [Settings](./Settings.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | Bundle of low-level pin settings passed to `LowLevelController.TransferFeature`. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [AlternateFunction](./AlternateFunction.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | Alternate-function index selecting which peripheral the pin connects to (platform-specific meaning). |
| [OutputSpeed](./OutputSpeed.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | Slew-rate / drive-strength setting for output pins. |
| [OutputType](./OutputType.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | How a GPIO pin's output driver is wired. |
| [PortMode](./PortMode.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | What role the pin plays in the chip's pin-mux fabric. |
| [PullDirection](./PullDirection.md) | `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` | Internal pull resistor selection. |
