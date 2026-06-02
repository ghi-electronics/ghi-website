---
title: "GHIElectronics.TinyCLR.IO.TinyFileSystem"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.IO.TinyFileSystem

NuGet package containing **16** types.

## Classes

| Class | Summary |
|---|---|
| [FileRef](./FileRef.md) | In memory representation of a file on "disk". This structure tracks the files total size, the clusters that make up the content of the file and the number of currently open Streams on the file. |
| [TinyFileStream](./TinyFileStream.md) | Provides a stream for a file in the Tiny File System. |
| [TinyFileSystem](./TinyFileSystem.md) |  |
| [TinyFileSystem](./TinyFileSystem_2.md) |  |
| [TinyFileSystem](./TinyFileSystem_3.md) | Markers used to indicate the state of the a cluster or sector on the disk In the case of a sector, this is just the first cluster on the disk which has the additional possible state of having the FormattedSector marker. |
| [TinyFileSystem](./TinyFileSystem_4.md) |  |
| [TinyFileSystem](./TinyFileSystem_5.md) |  |
| [TinyFileSystem](./TinyFileSystem_6.md) |  |
| [TinyFileSystem](./TinyFileSystem_7.md) | Tiny File System provides a basic file system which can be overlayed on any device providing a concrete implementation of the IBlockDriver interface. |
| [TinyFileSystem](./TinyFileSystem_8.md) |  |
| [TinyFileSystem](./TinyFileSystem_9.md) |  |
| [TinyFileSystem](./TinyFileSystem_10.md) |  |
| [UInt16Array](./UInt16Array.md) | Dynamically growing array of UInt16 (ushort) elements. |
| [Utilities](./Utilities.md) | General utility functions. |

## Structs

| Struct | Summary |
|---|---|
| [DeviceStats](./DeviceStats.md) | Statistics for the device |

## Interfaces

| Interface | Summary |
|---|---|
| [IBlockDriver](./IBlockDriver.md) | Interface to abstract the file system from the physical device. |
