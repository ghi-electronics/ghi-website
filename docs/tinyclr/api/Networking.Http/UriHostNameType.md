---
title: "UriHostNameType Enum"
sidebar_label: "UriHostNameType"
---

# UriHostNameType Enum

**Namespace:** `System` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Defines host name types for the http and https protocols. method.

```csharp
public enum UriHostNameType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Unknown` | `0` | The type of the host name is not supplied. |
| `Basic` | `1` | The host is set, but the type cannot be determined. |
| `Dns` | `2` | The host name is a domain name system (DNS) style host name. |
| `IPv4` | `3` | The host name is an Internet Protocol (IP) version 4 host address. |
| `IPv6` | `4` | The host name is an Internet Protocol (IP) version 6 host address. |
