---
title: "SocketOptionLevel Enum"
sidebar_label: "SocketOptionLevel"
---

# SocketOptionLevel Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Defines socket option levels for the class.

```csharp
public enum SocketOptionLevel
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Socket` | `0xffff` | Indicates socket options apply to the socket itself. |
| `IP` | `ProtocolType.IP` | Indicates socket options apply to IP sockets. |
| `IPv6` | `ProtocolType.IPv6` | Indicates socket options apply to IPv6 sockets. |
| `Tcp` | `ProtocolType.Tcp` | Indicates socket options apply to Tcp sockets. |
| `Udp` | `ProtocolType.Udp` | Indicates socket options apply to Udp sockets. |
