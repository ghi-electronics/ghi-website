---
title: "GHIElectronics.TinyCLR.Devices.Spi"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Spi

NuGet package containing **9** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Spi`, `GHIElectronics.TinyCLR.Devices.Spi.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [SpiConnectionSettings](./SpiConnectionSettings.md) | `GHIElectronics.TinyCLR.Devices.Spi` | Per-device SPI bus settings: clock, mode, chip select, etc. |
| [SpiController](./SpiController.md) | `GHIElectronics.TinyCLR.Devices.Spi` | Represents an SPI bus controller. Obtain one via `GetDefault` or `FromName(string)`, then create a `SpiDevice` for each chip on the bus via `GetDevice(SpiConnectionSettings)`. |
| [SpiControllerApiWrapper](./SpiControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Spi.Provider` | Concrete `ISpiControllerProvider` backed by the native TinyCLR SPI HAL. |
| [SpiControllerSoftwareProvider](./SpiControllerSoftwareProvider.md) | `GHIElectronics.TinyCLR.Devices.Spi.Provider` | Software (bit-bang) SPI provider. Useful when no hardware SPI peripheral is available on the desired pins, or to escape pin-mux conflicts. Significantly slower than the native hardware provider. |
| [SpiDevice](./SpiDevice.md) | `GHIElectronics.TinyCLR.Devices.Spi` | Represents a single chip on an SPI bus. Each transfer is preceded by a re-apply of `ConnectionSettings`, so multiple devices on the same controller can coexist without manual reconfiguration between calls. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [ISpiControllerProvider](./ISpiControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Spi.Provider` | Provider contract for an SPI controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [SpiChipSelectType](./SpiChipSelectType.md) | `GHIElectronics.TinyCLR.Devices.Spi` | How chip-select is driven. |
| [SpiDataFrame](./SpiDataFrame.md) | `GHIElectronics.TinyCLR.Devices.Spi` | Bit ordering within an SPI byte. |
| [SpiMode](./SpiMode.md) | `GHIElectronics.TinyCLR.Devices.Spi` | Standard SPI modes — combinations of clock polarity (CPOL) and clock phase (CPHA). Mode 0 (CPOL=0, CPHA=0) is the most common. |
