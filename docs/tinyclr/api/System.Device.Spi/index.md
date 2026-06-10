---
title: "System.Device.Spi"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">System.Device.Spi</h1>

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`

:::info
The standard, .NET-compatible `System.Device.Spi` API for TinyCLR. It ships inside the **[GHIElectronics.TinyCLR.Devices.Spi](../GHIElectronics.TinyCLR.Devices.Spi/index.md)** NuGet — there is no separate package to install.
:::

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [SpiConnectionSettings](./SpiConnectionSettings.md) | `System.Device.Spi` | Per-device SPI settings in the standard `System.Device.Spi` shape. TinyCLR maps these onto its native SPI driver via `SpiDevice.Create(SpiConnectionSettings)`. |
| [SpiDevice](./SpiDevice.md) | `System.Device.Spi` | .NET-style SPI device. Standard surface (`Read` / `Write` / `TransferFullDuplex`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.Spi.SpiController`. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DataFlow](./DataFlow.md) | `System.Device.Spi` | Bit ordering within an SPI frame. |
| [SpiMode](./SpiMode.md) | `System.Device.Spi` | Standard SPI mode — combinations of clock polarity and phase. |
