---
title: "GHIElectronics.TinyCLR.Devices.Adc"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Adc

NuGet package containing **5** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Adc`, `GHIElectronics.TinyCLR.Devices.Adc.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [AdcChannel](./AdcChannel.md) | `GHIElectronics.TinyCLR.Devices.Adc` | A single ADC channel opened from an `AdcController`. Call `ReadValue` for raw codes or `ReadRatio` for a 0.0–1.0 normalized reading. |
| [AdcController](./AdcController.md) | `GHIElectronics.TinyCLR.Devices.Adc` | Represents an ADC peripheral. Open a channel via `OpenChannel(int)` to take samples; use `MinValue`/`MaxValue` to know the raw-code range for the configured resolution. |
| [AdcControllerApiWrapper](./AdcControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Adc.Provider` | Concrete `IAdcControllerProvider` backed by the native TinyCLR ADC HAL. Constructed internally by `AdcController`; you don't normally need to use this type directly. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IAdcControllerProvider](./IAdcControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Adc.Provider` | Provider contract for an ADC controller. Most users call `AdcController` / `AdcChannel` directly; implement this interface only when supplying a custom or virtual ADC. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [AdcChannelMode](./AdcChannelMode.md) | `GHIElectronics.TinyCLR.Devices.Adc` | How an ADC channel sees its input. |
