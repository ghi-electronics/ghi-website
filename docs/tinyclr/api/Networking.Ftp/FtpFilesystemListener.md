---
title: "FtpFilesystemListener Class"
sidebar_label: "FtpFilesystemListener"
---

# FtpFilesystemListener Class

**Namespace:** `GHIElectronics.TinyCLR.Networking.Ftp` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

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

| Parameter | Type | Description |
|---|---|---|
| `virtualRoot` | `String` |  |
| `filesystemRoot` | `String` |  |

### FtpFilesystemListener(String virtualRoot, String filesystemRoot, bool uploadsAllowed)

```csharp
public FtpFilesystemListener(String virtualRoot, String filesystemRoot, bool uploadsAllowed)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `virtualRoot` | `String` |  |
| `filesystemRoot` | `String` |  |
| `uploadsAllowed` | `bool` |  |

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

Starts the timer. _(inherited)_

### Stop()

```csharp
public override void Stop()
```

Stops the timer. _(inherited)_
