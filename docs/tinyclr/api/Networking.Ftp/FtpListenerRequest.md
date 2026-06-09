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

When overridden in a descendant class, gets or sets the protocol method to use in this request. _(inherited)_

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
