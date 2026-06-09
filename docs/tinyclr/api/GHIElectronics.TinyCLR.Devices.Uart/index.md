---
title: "GHIElectronics.TinyCLR.Devices.Uart"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Uart NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [BreakDetectedEventArgs](./BreakDetectedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Arguments for break-condition events (reserved; not raised by the standard controller). |
| [ClearToSendChangedEventArgs](./ClearToSendChangedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Arguments for `UartController.ClearToSendChanged`. |
| [DataReceivedEventArgs](./DataReceivedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Arguments for `UartController.DataReceived`. |
| [ErrorReceivedEventArgs](./ErrorReceivedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Arguments for `UartController.ErrorReceived`. |
| [UartController](./UartController.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Represents a UART (serial) port. Configure via `SetActiveSettings(UartSetting)`, then `Enable` the port and exchange bytes through `Read(byte[])` / `Write(byte[])`. Subscribe to `DataReceived` for event-driven receive instead of polling `BytesToRead`. |
| [UartControllerApiWrapper](./UartControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Uart.Provider` | Concrete `IUartControllerProvider` backed by the native TinyCLR UART HAL. |
| [UartSetting](./UartSetting.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Aggregate configuration for a UART port — passed to `UartController.SetActiveSettings(UartSetting)`. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IUartControllerProvider](./IUartControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Uart.Provider` | Provider contract for a UART controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [UartError](./UartError.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Categories of error reported via `UartController.ErrorReceived`. |
| [UartHandshake](./UartHandshake.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Flow-control policy. |
| [UartParity](./UartParity.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Parity bit policy for a UART frame. |
| [UartStopBitCount](./UartStopBitCount.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Number of stop bits per frame. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [ClearToSendChangedEventHandler](./ClearToSendChangedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Handler signature for `UartController.ClearToSendChanged`. |
| [DataReceivedEventHandler](./DataReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Handler signature for `UartController.DataReceived`. |
| [ErrorReceivedEventHandler](./ErrorReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Uart` | Handler signature for `UartController.ErrorReceived`. |
