---
title: "GHIElectronics.TinyCLR.Devices.Gpio"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Gpio NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [GpioController](./GpioController.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | Represents a GPIO controller — the hardware peripheral that owns a set of individually addressable pins. Use `GetDefault` to obtain the device's primary controller, then `OpenPin(int)` to acquire pins for input or output. |
| [GpioControllerApiWrapper](./GpioControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Gpio.Provider` | Concrete `IGpioControllerProvider` backed by the native TinyCLR GPIO HAL. Constructed internally by `GpioController`; you don't normally need to use this type directly. |
| [GpioPin](./GpioPin.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | A single GPIO pin opened from a `GpioController`. Configure the direction with `SetDriveMode(GpioPinDriveMode)`, then drive it with `Write(GpioPinValue)` or sample it with `Read`. Subscribe to `ValueChanged` for edge-triggered notifications on inputs. |
| [GpioPinValueChangedEventArgs](./GpioPinValueChangedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | Arguments for the `GpioPin.ValueChanged` event. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IGpioControllerProvider](./IGpioControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Gpio.Provider` | Provider contract for a GPIO controller. Most users call `GpioController` / `GpioPin` directly; implement this interface only when supplying a custom or virtual controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [GpioPinDriveMode](./GpioPinDriveMode.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | Electrical drive mode applied to a `GpioPin`. Not every mode is available on every pin — call `GpioPin.IsDriveModeSupported(GpioPinDriveMode)` before `GpioPin.SetDriveMode(GpioPinDriveMode)` when in doubt. |
| [GpioPinEdge](./GpioPinEdge.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | Which edges trigger the `GpioPin.ValueChanged` event. The flags can be combined to fire on both edges. |
| [GpioPinValue](./GpioPinValue.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | Logical level of a `GpioPin`. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [GpioPinValueChangedEventHandler](./GpioPinValueChangedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Gpio` | Handler invoked when a `GpioPin` configured as an input observes a level change matching its `GpioPin.ValueChangedEdge`. |
