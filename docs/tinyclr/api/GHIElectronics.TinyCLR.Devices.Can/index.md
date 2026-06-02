---
title: "GHIElectronics.TinyCLR.Devices.Can"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Can

NuGet package containing **14** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Can`, `GHIElectronics.TinyCLR.Devices.Can.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [CanBitTiming](./CanBitTiming.md) | `GHIElectronics.TinyCLR.Devices.Can` | Bit-timing parameters for one phase (arbitration or data) of a CAN frame. |
| [CanController](./CanController.md) | `GHIElectronics.TinyCLR.Devices.Can` | Represents a CAN bus controller. Configure bit timing and acceptance filters, `Enable` the controller, then exchange `CanMessage`s. Subscribe to `MessageReceived` for event-driven receive instead of polling `MessagesToRead`. |
| [CanControllerApiWrapper](./CanControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Can.Provider` | Concrete `ICanControllerProvider` backed by the native TinyCLR CAN HAL. |
| [CanMessage](./CanMessage.md) | `GHIElectronics.TinyCLR.Devices.Can` | One CAN (or CAN-FD) frame. Set `ArbitrationId`, optionally `ExtendedId` for 29-bit IDs, and the payload via `Data` / `Length`. For CAN-FD, set `FdCan` and optionally `BitRateSwitch`. |
| [ErrorReceivedEventArgs](./ErrorReceivedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Can` | Arguments for `CanController.ErrorReceived`. |
| [Filter](./Filter.md) | `GHIElectronics.TinyCLR.Devices.Can` | Acceptance-filter configuration for a CAN controller. |
| [MessageReceivedEventArgs](./MessageReceivedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Can` | Arguments for `CanController.MessageReceived`. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [ICanControllerProvider](./ICanControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Can.Provider` | Provider contract for a CAN controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [CanError](./CanError.md) | `GHIElectronics.TinyCLR.Devices.Can` | Categories of error reported via `CanController.ErrorReceived`. |
| [ErrorStateIndicator](./ErrorStateIndicator.md) | `GHIElectronics.TinyCLR.Devices.Can` | CAN-FD error state indicator carried in a received message. |
| [FilterType](./FilterType.md) | `GHIElectronics.TinyCLR.Devices.Can` | How a filter matches arbitration IDs. |
| [IdType](./IdType.md) | `GHIElectronics.TinyCLR.Devices.Can` | CAN identifier width. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [ErrorReceivedEventHandler](./ErrorReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Can` | Handler signature for `CanController.ErrorReceived`. |
| [MessageReceivedEventHandler](./MessageReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Can` | Handler signature for `CanController.MessageReceived`. |
