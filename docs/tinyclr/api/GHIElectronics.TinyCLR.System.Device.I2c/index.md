---
title: "GHIElectronics.TinyCLR.System.Device.I2c"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.System.Device.I2c NuGet</h1>

:::info
The standard, .NET-compatible `System.Device.I2c` API for TinyCLR. It ships inside the **[GHIElectronics.TinyCLR.Devices.I2c](../GHIElectronics.TinyCLR.Devices.I2c/index.md)** NuGet — there is no separate package to install.
:::

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [I2cConnectionSettings](./I2cConnectionSettings.md) | `System.Device.I2c` | Per-device I²C settings in the standard `System.Device.I2c` shape. TinyCLR maps these onto its native I²C driver via `I2cDevice.Create(I2cConnectionSettings)`. |
| [I2cDevice](./I2cDevice.md) | `System.Device.I2c` | .NET-style I²C device. Standard surface (`Read` / `Write` / `WriteRead`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.I2c.I2cController`. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [I2cBusSpeed](./I2cBusSpeed.md) | `System.Device.I2c` | Standard .NET-style I²C bus speed selector. |
