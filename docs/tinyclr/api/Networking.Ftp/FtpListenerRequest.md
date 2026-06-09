---
title: "FtpListenerRequest Class"
sidebar_label: "FtpListenerRequest"
---

# FtpListenerRequest Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking`

The ftp request

```csharp
public class FtpListenerRequest
```

## Properties

### Method

```csharp
public string Method { get; }
```

_No description available._

### QueryString

```csharp
public string QueryString { get; }
```

The parameter of the request command

### InputStream

```csharp
public FtpResponseStream InputStream { get; }
```

The stream that is passed to the response
