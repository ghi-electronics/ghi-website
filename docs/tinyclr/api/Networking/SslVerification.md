---
title: "SslVerification Enum"
sidebar_label: "SslVerification"
---

# SslVerification Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Security.Authentication`

Specifies how the remote certificate is verified during the SSL handshake.

```csharp
public enum SslVerification
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No certificate verification is performed. |
| `Optional` | `1` | Certificate verification is optional. |
| `Required` | `2` | Certificate verification is required. |
| `VerifyOnce` | `3` | The certificate is verified only once. |
