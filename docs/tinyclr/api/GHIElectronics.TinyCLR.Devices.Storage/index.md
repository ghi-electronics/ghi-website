---
title: "GHIElectronics.TinyCLR.Devices.Storage"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Storage

NuGet package containing **4** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Storage`, `GHIElectronics.TinyCLR.Devices.Storage.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [StorageController](./StorageController.md) | `GHIElectronics.TinyCLR.Devices.Storage` | Represents a block-storage device — internal flash, external SPI/SD flash, SD/MMC, or USB mass-storage. Use `Hdc` to mount the controller with the file-system stack, or call the provider's Read/Write/Erase methods directly for raw block access. |
| [StorageControllerApiWrapper](./StorageControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Storage.Provider` | Concrete `IStorageControllerProvider` backed by the native TinyCLR storage HAL. |
| [StorageDescriptor](./StorageDescriptor.md) | `GHIElectronics.TinyCLR.Devices.Storage` | Describes a storage medium's geometry and capabilities. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IStorageControllerProvider](./IStorageControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Storage.Provider` | Provider contract for a block-storage controller. |
