---
title: "FtpListenerContext Class"
sidebar_label: "FtpListenerContext"
---

# FtpListenerContext Class

**Namespace:** `GHIElectronics.TinyCLR.Networking` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

A Context containing an ftp request and a response scratch that should be completed by listeners

```csharp
public class FtpListenerContext
```

## Properties

### Request

```csharp
public FtpListenerRequest Request { get; }
```

The request of this context

### User

```csharp
public UserInfo User { get; }
```

The user who made the request

### Response

```csharp
public FtpListenerResponse Response { get; }
```

The response of this context
