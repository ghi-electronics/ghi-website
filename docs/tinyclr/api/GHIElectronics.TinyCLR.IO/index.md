---
title: "GHIElectronics.TinyCLR.IO"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.IO</h1>

**NuGet:** `GHIElectronics.TinyCLR.IO`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Directory](./Directory.md) | `System.IO` | Static helpers for directory management — create, delete, enumerate, get current directory. |
| [DirectoryInfo](./DirectoryInfo.md) | `System.IO` | Provides information about a directory and the means to create or delete it. |
| [DriveInfo](./DriveInfo.md) | `System.IO` | Information about a mounted volume — total/available space, type, root path. |
| [File](./File.md) | `System.IO` | Static helpers for file management — copy, move, delete, exists, open. Mirrors the .NET BCL `System.IO.File` API for the file-system mount points registered via `GHIElectronics.TinyCLR.IO.FileSystem`. |
| [FileEnum](./FileEnum.md) | `System.IO` | Enumerates the file-system entries under a path. |
| [FileEnumerator](./FileEnumerator.md) | `System.IO` | Provides an enumerable over the entries of a directory. |
| [FileInfo](./FileInfo.md) | `System.IO` | Provides information about a file and the means to create or delete it. |
| [FileStream](./FileStream.md) | `System.IO` | A read/write stream backed by a file on a mounted file system. Construct via `File.OpenRead(string)` / `File.OpenWrite(string)` / `File.Create(string)`. |
| [FileSystem](./FileSystem.md) | `GHIElectronics.TinyCLR.IO` | Mounts and unmounts file systems on top of a `GHIElectronics.TinyCLR.Devices.Storage.StorageController`. Pass the controller's `Hdc` to `Mount(IntPtr)` to make its content accessible via `System.IO.File` / `System.IO.Directory`. |
| [FileSystemEntry](./FileSystemEntry.md) | `GHIElectronics.TinyCLR.IO` | Describes a single file or directory returned by a drive provider. |
| [FileSystemInfo](./FileSystemInfo.md) | `System.IO` | Base class for objects that describe a file or directory. |
| [Path](./Path.md) | `System.IO` | Static helpers for path-string manipulation — Combine, GetExtension, GetFileName, etc. |
| [TextReader](./TextReader.md) | `System.IO` | Base class for reading a sequential series of characters. |
| [TextWriter](./TextWriter.md) | `System.IO` | Base class for writing a sequential series of characters. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IDriveProvider](./IDriveProvider.md) | `GHIElectronics.TinyCLR.IO` | Backing store for a mounted drive that the IO library calls into. |
| [IFileStream](./IFileStream.md) | `GHIElectronics.TinyCLR.IO` | A low-level file stream supplied by a drive provider. |
| [IFileSystemEntryFinder](./IFileSystemEntryFinder.md) | `GHIElectronics.TinyCLR.IO` | Iterates over the entries returned by a drive provider's search. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DriveType](./DriveType.md) | `System.IO` | Classification of a mounted volume. |
| [FileAccess](./FileAccess.md) | `System.IO` | Specifies the access a file can be opened with. |
| [FileAttributes](./FileAttributes.md) | `System.IO` | Attributes that can be set on a file or directory. |
| [FileEnumFlags](./FileEnumFlags.md) | `System.IO` | Selects which kinds of entries a file enumeration returns. |
| [FileMode](./FileMode.md) | `System.IO` | Specifies how the operating system should open a file. |
| [FileShare](./FileShare.md) | `System.IO` | Controls the access other openers may have to a file that is already open. |
