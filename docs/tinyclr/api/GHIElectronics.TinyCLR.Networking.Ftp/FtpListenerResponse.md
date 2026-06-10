---
title: "FtpListenerResponse Class"
sidebar_label: "FtpListenerResponse"
---

# FtpListenerResponse Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking`

The ftp response

```csharp
public class FtpListenerResponse
```

## Properties

### OutputStream

```csharp
public FtpResponseStream OutputStream { get; }
```

the stream that data would be written to

### StatusCode

```csharp
public FtpStatusCode StatusCode { get; set; }
```

status code set by users
