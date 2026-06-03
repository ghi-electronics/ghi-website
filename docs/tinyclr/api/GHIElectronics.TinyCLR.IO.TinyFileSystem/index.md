---
title: "GHIElectronics.TinyCLR.IO.TinyFileSystem"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.IO.TinyFileSystem

NuGet package containing **7** types.

## Classes

| Class | Summary |
|---|---|
| [FileRef](./FileRef.md) | In memory representation of a file on "disk". This structure tracks the files total size, the clusters that make up the content of the file and the number of currently open Streams on the file. |
| [TinyFileStream](./TinyFileStream.md) | Provides a stream for a file in the Tiny File System. |
| [TinyFileSystem](./TinyFileSystem.md) | Tiny File System provides a basic file system which can be overlayed on any device providing a concrete implementation of the IBlockDriver interface. |
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
