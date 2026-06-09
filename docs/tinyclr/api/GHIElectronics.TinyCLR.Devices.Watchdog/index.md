---
title: "GHIElectronics.TinyCLR.Devices.Watchdog"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Watchdog NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [WatchdogController](./WatchdogController.md) | `GHIElectronics.TinyCLR.Devices.Watchdog` | Independent watchdog timer. `Enable(uint)` with a timeout and call `Reset` periodically — if the timer ever expires without being reset, the chip reboots. Useful as a failsafe against firmware lockups. |
| [WatchdogControllerApiWrapper](./WatchdogControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Watchdog.Provider` | Concrete `IWatchdogControllerProvider` backed by the native TinyCLR HAL. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IWatchdogControllerProvider](./IWatchdogControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Watchdog.Provider` | Provider contract for a watchdog controller. |
