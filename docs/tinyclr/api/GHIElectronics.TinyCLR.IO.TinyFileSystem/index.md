---
title: "GHIElectronics.TinyCLR.IO.TinyFileSystem"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.IO.TinyFileSystem</h1>

**NuGet:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [FileRef](./FileRef.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | In memory representation of a file on "disk". This structure tracks the files total size, the clusters that make up the content of the file and the number of currently open Streams on the file. |
| [TinyFileStream](./TinyFileStream.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | Provides a stream for a file in the Tiny File System. |
| [TinyFileSystem](./TinyFileSystem.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | Tiny File System provides a basic file system which can be overlayed on any device providing a concrete implementation of the IBlockDriver interface. |
| [UInt16Array](./UInt16Array.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | Dynamically growing array of UInt16 (ushort) elements. |
| [Utilities](./Utilities.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | General utility functions. |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [DeviceStats](./DeviceStats.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | Statistics for the device |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IBlockDriver](./IBlockDriver.md) | `GHIElectronics.TinyCLR.IO.TinyFileSystem` | Interface to abstract the file system from the physical device. |
