---
title: "GHIElectronics.TinyCLR.Devices.Rtc"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Rtc

NuGet package containing **5** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Rtc`, `GHIElectronics.TinyCLR.Devices.Rtc.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [RtcController](./RtcController.md) | `GHIElectronics.TinyCLR.Devices.Rtc` | Real-time clock controller. Tracks calendar time across power cycles when backed by a coin cell, and exposes a small region of battery-backed RAM via `WriteBackupMemory(byte[])` / `ReadBackupMemory(byte[])`. |
| [RtcControllerApiWrapper](./RtcControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Rtc.Provider` | Concrete `IRtcControllerProvider` backed by the native TinyCLR RTC HAL. |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [RtcDateTime](./RtcDateTime.md) | `GHIElectronics.TinyCLR.Devices.Rtc` | RTC-native calendar time representation. Mirrors the underlying hardware registers — most app code should round-trip through `ToDateTime` / `FromDateTime(DateTime)` rather than touching fields directly. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IRtcControllerProvider](./IRtcControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Rtc.Provider` | Provider contract for an RTC controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [BatteryChargeMode](./BatteryChargeMode.md) | `GHIElectronics.TinyCLR.Devices.Rtc` | Trickle-charge setting applied to the RTC backup battery. |
