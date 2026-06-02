---
title: "GHIElectronics.TinyCLR.Devices.Gpio.LowLevel"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Gpio.LowLevel

NuGet package containing **7** types.

## Classes

| Class | Summary |
|---|---|
| [LowLevelController](./LowLevelController.md) | Low-level pin-mux helper. Lets a driver re-route or reconfigure pins at a level finer than the regular `GpioPin` API (slew rate, alternate function, etc.). Mostly used by peripheral library authors; ordinary apps don't need this. |
| [Settings](./Settings.md) | Bundle of low-level pin settings passed to `LowLevelController.TransferFeature`. |

## Enums

| Enum | Summary |
|---|---|
| [AlternateFunction](./AlternateFunction.md) | Alternate-function index selecting which peripheral the pin connects to (platform-specific meaning). |
| [OutputSpeed](./OutputSpeed.md) | Slew-rate / drive-strength setting for output pins. |
| [OutputType](./OutputType.md) | How a GPIO pin's output driver is wired. |
| [PortMode](./PortMode.md) | What role the pin plays in the chip's pin-mux fabric. |
| [PullDirection](./PullDirection.md) | Internal pull resistor selection. |
