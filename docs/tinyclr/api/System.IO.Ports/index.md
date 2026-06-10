---
title: "System.IO.Ports"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">System.IO.Ports</h1>

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`

:::info
The standard, .NET-compatible `System.IO.Ports` API for TinyCLR. It ships inside the **[GHIElectronics.TinyCLR.Devices.Uart](../GHIElectronics.TinyCLR.Devices.Uart/index.md)** NuGet — there is no separate package to install.
:::

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [SerialDataReceivedEventArgs](./SerialDataReceivedEventArgs.md) | `System.IO.Ports` | Arguments for the data-received event. |
| [SerialErrorReceivedEventArgs](./SerialErrorReceivedEventArgs.md) | `System.IO.Ports` | Arguments for the error-received event. |
| [SerialPinChangedEventArgs](./SerialPinChangedEventArgs.md) | `System.IO.Ports` | Arguments for the pin-changed event. |
| [SerialPort](./SerialPort.md) | `System.IO.Ports` | .NET-style serial port. Same surface as `System.IO.Ports.SerialPort`; internally routes through TinyCLR's `GHIElectronics.TinyCLR.Devices.Uart.UartController`. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [Handshake](./Handshake.md) | `System.IO.Ports` | Flow-control method. |
| [Parity](./Parity.md) | `System.IO.Ports` | Parity-checking scheme. |
| [SerialData](./SerialData.md) | `System.IO.Ports` | Type of data received on the serial port. |
| [SerialError](./SerialError.md) | `System.IO.Ports` | Errors that can occur on the serial port. |
| [SerialPin](./SerialPin.md) | `System.IO.Ports` | Serial control-pin changes that can raise the pin-changed event. |
| [StopBits](./StopBits.md) | `System.IO.Ports` | Number of stop bits per frame. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [SerialDataReceivedEventHandler](./SerialDataReceivedEventHandler.md) | `System.IO.Ports` | Handler for the `SerialPort.DataReceived` event. |
| [SerialErrorReceivedEventHandler](./SerialErrorReceivedEventHandler.md) | `System.IO.Ports` | Handler for the `SerialPort.ErrorReceived` event. |
| [SerialPinChangedEventHandler](./SerialPinChangedEventHandler.md) | `System.IO.Ports` | Handler for the `SerialPort.PinChanged` event. |
