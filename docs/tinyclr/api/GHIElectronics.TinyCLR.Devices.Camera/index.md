---
title: "GHIElectronics.TinyCLR.Devices.Camera"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Camera</h1>

**NuGet:** `GHIElectronics.TinyCLR.Devices.Camera`

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
