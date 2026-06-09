---
title: "FtpFilesystemListener Class"
sidebar_label: "FtpFilesystemListener"
---

# FtpFilesystemListener Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Ftp`

_No description available._

```csharp
public class FtpFilesystemListener : FtpListener
```

## Constructors

### FtpFilesystemListener(String virtualRoot, String filesystemRoot)

```csharp
public FtpFilesystemListener(String virtualRoot, String filesystemRoot) : this(virtualRoot, filesystemRoot, true)
```

_No description available._

### FtpFilesystemListener(String virtualRoot, String filesystemRoot, bool uploadsAllowed)

```csharp
public FtpFilesystemListener(String virtualRoot, String filesystemRoot, bool uploadsAllowed)
```

_No description available._

## Properties

### FilesystemRoot

```csharp
public String FilesystemRoot { get; set; }
```

_No description available._

### VirtualRoot

```csharp
public String VirtualRoot { get; set; }
```

_No description available._

### UploadsAllowed

```csharp
public bool UploadsAllowed { get; set; }
```

_No description available._

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
