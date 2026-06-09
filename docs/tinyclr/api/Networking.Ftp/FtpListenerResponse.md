---
title: "FtpListenerResponse Class"
sidebar_label: "FtpListenerResponse"
---

# FtpListenerResponse Class

**Namespace:** `GHIElectronics.TinyCLR.Networking` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

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
