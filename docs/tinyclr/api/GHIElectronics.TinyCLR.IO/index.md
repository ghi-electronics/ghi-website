---
title: "GHIElectronics.TinyCLR.IO"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.IO NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Directory](./Directory.md) | `System.IO` | Static helpers for directory management — create, delete, enumerate, get current directory. |
| [DirectoryInfo](./DirectoryInfo.md) | `System.IO` |  |
| [DriveInfo](./DriveInfo.md) | `System.IO` | Information about a mounted volume — total/available space, type, root path. |
| [File](./File.md) | `System.IO` |  |
| [FileEnum](./FileEnum.md) | `System.IO` |  |
| [FileEnumerator](./FileEnumerator.md) | `System.IO` |  |
| [FileInfo](./FileInfo.md) | `System.IO` |  |
| [FileStream](./FileStream.md) | `System.IO` | A read/write stream backed by a file on a mounted file system. Construct via `File.OpenRead(string)` / `File.OpenWrite(string)` / `File.Create(string)`. |
| [FileSystem](./FileSystem.md) | `GHIElectronics.TinyCLR.IO` | Mounts and unmounts file systems on top of a `GHIElectronics.TinyCLR.Devices.Storage.StorageController`. Pass the controller's `Hdc` to `Mount(IntPtr)` to make its content accessible via `System.IO.File` / `System.IO.Directory`. |
| [FileSystemEntry](./FileSystemEntry.md) | `GHIElectronics.TinyCLR.IO` |  |
| [FileSystemInfo](./FileSystemInfo.md) | `System.IO` |  |
| [Path](./Path.md) | `System.IO` |  |
| [TextReader](./TextReader.md) | `System.IO` |  |
| [TextWriter](./TextWriter.md) | `System.IO` |  |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IDriveProvider](./IDriveProvider.md) | `GHIElectronics.TinyCLR.IO` |  |
| [IFileStream](./IFileStream.md) | `GHIElectronics.TinyCLR.IO` |  |
| [IFileSystemEntryFinder](./IFileSystemEntryFinder.md) | `GHIElectronics.TinyCLR.IO` |  |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DriveType](./DriveType.md) | `System.IO` | Classification of a mounted volume. |
| [FileAccess](./FileAccess.md) | `System.IO` |  |
| [FileAttributes](./FileAttributes.md) | `System.IO` |  |
| [FileEnumFlags](./FileEnumFlags.md) | `System.IO` |  |
| [FileMode](./FileMode.md) | `System.IO` |  |
| [FileShare](./FileShare.md) | `System.IO` |  |
