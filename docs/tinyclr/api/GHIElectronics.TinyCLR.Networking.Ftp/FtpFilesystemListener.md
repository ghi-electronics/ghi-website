---
title: "FtpFilesystemListener Class"
sidebar_label: "FtpFilesystemListener"
---

# FtpFilesystemListener Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Ftp`

An FTP listener that serves files from a real filesystem directory under a virtual root.

```csharp
public class FtpFilesystemListener : FtpListener
```

## Constructors

### FtpFilesystemListener(String virtualRoot, String filesystemRoot)

```csharp
public FtpFilesystemListener(String virtualRoot, String filesystemRoot) : this(virtualRoot, filesystemRoot, true)
```

Creates a listener that maps the virtual root to the filesystem directory, allowing uploads.

### FtpFilesystemListener(String virtualRoot, String filesystemRoot, bool uploadsAllowed)

```csharp
public FtpFilesystemListener(String virtualRoot, String filesystemRoot, bool uploadsAllowed)
```

Creates a listener that maps the virtual root to the filesystem directory, optionally allowing uploads.

## Properties

### FilesystemRoot

```csharp
public String FilesystemRoot { get; set; }
```

The filesystem directory whose contents are served.

### VirtualRoot

```csharp
public String VirtualRoot { get; set; }
```

The virtual root path that clients see, mapped onto the filesystem directory.

### UploadsAllowed

```csharp
public bool UploadsAllowed { get; set; }
```

Whether clients are allowed to upload files.

## Methods

### Start()

```csharp
public override void Start()
```

Start the listener _(inherited)_

### Stop()

```csharp
public override void Stop()
```

Stop the listener _(inherited)_
