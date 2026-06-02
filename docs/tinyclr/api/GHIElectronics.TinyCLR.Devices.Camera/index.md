---
title: "GHIElectronics.TinyCLR.Devices.Camera"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Camera

NuGet package containing **6** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Camera`, `GHIElectronics.TinyCLR.Devices.Camera.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [CameraController](./CameraController.md) | `GHIElectronics.TinyCLR.Devices.Camera` | Represents a DCMI / parallel camera interface. Configure timing via `SetActiveSettings`, `Enable` the capture engine, then call `Capture(byte[], int)` to read a frame into a buffer. |
| [CameraControllerApiWrapper](./CameraControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Camera.Provider` | Concrete `ICameraControllerProvider` backed by the native TinyCLR camera HAL. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [ICameraControllerProvider](./ICameraControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Camera.Provider` | Provider contract for a camera controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [CaptureRate](./CaptureRate.md) | `GHIElectronics.TinyCLR.Devices.Camera` | Frame-dropping policy for the capture engine. |
| [ExtendedDataMode](./ExtendedDataMode.md) | `GHIElectronics.TinyCLR.Devices.Camera` | Camera-to-SoC parallel data bus width. |
| [SynchronizationMode](./SynchronizationMode.md) | `GHIElectronics.TinyCLR.Devices.Camera` | How the camera frames its data. |
