---
title: "GHIElectronics.TinyCLR.Devices.Display"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Display

NuGet package containing **8** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Display`, `GHIElectronics.TinyCLR.Devices.Display.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [DisplayController](./DisplayController.md) | `GHIElectronics.TinyCLR.Devices.Display` | Represents the framebuffer / panel controller. After supplying timing via `SetConfiguration(DisplayControllerSettings)` and calling `Enable`, push pixels with `DrawBuffer` / `DrawPixel` — or mount the controller into the higher-level drawing/UI stack via `Hdc`. |
| [DisplayControllerApiWrapper](./DisplayControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Display.Provider` | Concrete `IDisplayControllerProvider` backed by the native TinyCLR display HAL. |
| [DisplayControllerSettings](./DisplayControllerSettings.md) | `GHIElectronics.TinyCLR.Devices.Display` | Common settings for any display controller (size, color format, orientation). |
| [ParallelDisplayControllerSettings](./ParallelDisplayControllerSettings.md) | `GHIElectronics.TinyCLR.Devices.Display` | Timing settings for a parallel RGB panel. Values come from the panel's datasheet. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IDisplayControllerProvider](./IDisplayControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Display.Provider` | Provider contract for a display controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DisplayDataFormat](./DisplayDataFormat.md) | `GHIElectronics.TinyCLR.Devices.Display` | Pixel encoding written to the framebuffer. |
| [DisplayInterface](./DisplayInterface.md) | `GHIElectronics.TinyCLR.Devices.Display` | Physical bus connecting the SoC to the panel. |
| [DisplayOrientation](./DisplayOrientation.md) | `GHIElectronics.TinyCLR.Devices.Display` | Logical screen rotation applied to drawing operations. |
