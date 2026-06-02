---
title: "GHIElectronics.TinyCLR.Devices.I2c"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.I2c

NuGet package containing **15** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.I2c`, `GHIElectronics.TinyCLR.Devices.I2c.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [ErrorReceivedEventArgs](./ErrorReceivedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Arguments for `I2cDevice.ErrorReceived`. |
| [FrameEventArgs](./FrameEventArgs.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Arguments for `I2cDevice.FrameReceived`. |
| [I2cConnectionSettings](./I2cConnectionSettings.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Per-device I²C connection settings: address, bus speed, and master/slave role. |
| [I2cController](./I2cController.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Represents an I²C bus controller. Open a peer with `GetDevice(I2cConnectionSettings)` to transact with a specific slave address. The same controller can serve multiple slaves — settings are re-applied per transfer. |
| [I2cControllerApiWrapper](./I2cControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.I2c.Provider` | Concrete `II2cControllerProvider` backed by the native TinyCLR I²C HAL. |
| [I2cDevice](./I2cDevice.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Represents a single slave on the I²C bus. Master-mode devices use the blocking `Read(byte[])` / `Write(byte[])` / `WriteRead(byte[],byte[])` family; slave-mode devices additionally expose `FrameReceived` and `ErrorReceived` events. |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [I2cTransferResult](./I2cTransferResult.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Outcome of a partial-transfer call (`I2cDevice.ReadPartial(byte[])` and friends). |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [II2cControllerProvider](./II2cControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.I2c.Provider` | Provider contract for an I²C controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [I2cAddressFormat](./I2cAddressFormat.md) | `GHIElectronics.TinyCLR.Devices.I2c` | I²C address width. |
| [I2cError](./I2cError.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Bus errors reported via `I2cDevice.ErrorReceived`. |
| [I2cMode](./I2cMode.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Bus role for an `I2cDevice`. |
| [I2cTransaction](./I2cTransaction.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Master-initiated transaction kind observed by a slave. |
| [I2cTransferStatus](./I2cTransferStatus.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Outcome of an I²C transfer. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [ErrorReceivedEventHandler](./ErrorReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Handler signature for `I2cDevice.ErrorReceived`. |
| [FrameReceivedEventHandler](./FrameReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.I2c` | Handler signature for `I2cDevice.FrameReceived`. |
