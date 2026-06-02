---
title: "GHIElectronics.TinyCLR.System.Device.Spi"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.System.Device.Spi

NuGet package containing **4** types.

## Classes

| Class | Summary |
|---|---|
| [SpiConnectionSettings](./SpiConnectionSettings.md) | Per-device SPI settings in the standard `System.Device.Spi` shape. TinyCLR maps these onto its native SPI driver via `SpiDevice.Create(SpiConnectionSettings)`. |
| [SpiDevice](./SpiDevice.md) | .NET-style SPI device. Standard surface (`Read` / `Write` / `TransferFullDuplex`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.Spi.SpiController`. |

## Enums

| Enum | Summary |
|---|---|
| [DataFlow](./DataFlow.md) | Bit ordering within an SPI frame. |
| [SpiMode](./SpiMode.md) | Standard SPI mode — combinations of clock polarity and phase. |
