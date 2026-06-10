---
title: "GHIElectronics.TinyCLR.Devices.Dac"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">Devices.Dac Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [DacChannel](./DacChannel.md) | `GHIElectronics.TinyCLR.Devices.Dac` | A single DAC channel opened from a `DacController`. Call `WriteValue(int)` for raw codes or `WriteValue(double)` for a 0.0–1.0 ratio of the output range. |
| [DacController](./DacController.md) | `GHIElectronics.TinyCLR.Devices.Dac` | Represents a DAC peripheral. Open a channel via `OpenChannel(int)` to drive analog output; use `MinValue`/`MaxValue` to know the raw-code range for the configured resolution. |
| [DacControllerApiWrapper](./DacControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Dac.Provider` | Concrete `IDacControllerProvider` backed by the native TinyCLR DAC HAL. Constructed internally by `DacController`; you don't normally need to use this type directly. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IDacControllerProvider](./IDacControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Dac.Provider` | Provider contract for a DAC controller. Most users call `DacController` / `DacChannel` directly; implement this interface only when supplying a custom or virtual DAC. |
