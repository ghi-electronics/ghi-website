---
title: "GHIElectronics.TinyCLR.System.Device.Spi"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.System.Device.Spi NuGet</h1>

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
