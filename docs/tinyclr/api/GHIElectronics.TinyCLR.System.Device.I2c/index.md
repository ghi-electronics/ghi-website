---
title: "GHIElectronics.TinyCLR.System.Device.I2c"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.System.Device.I2c

NuGet package containing **3** types.

## Classes

| Class | Summary |
|---|---|
| [I2cConnectionSettings](./I2cConnectionSettings.md) | Per-device I²C settings in the standard `System.Device.I2c` shape. TinyCLR maps these onto its native I²C driver via `I2cDevice.Create(I2cConnectionSettings)`. |
| [I2cDevice](./I2cDevice.md) | .NET-style I²C device. Standard surface (`Read` / `Write` / `WriteRead`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.I2c.I2cController`. |

## Enums

| Enum | Summary |
|---|---|
| [I2cBusSpeed](./I2cBusSpeed.md) | Standard .NET-style I²C bus speed selector. |
