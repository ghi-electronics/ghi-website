---
title: "SocketShutdown Enum"
sidebar_label: "SocketShutdown"
---

# SocketShutdown Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Specifies which socket operations to disable when shutting down a socket.

```csharp
public enum SocketShutdown
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Receive` | `0` | Disables receiving on the socket. |
| `Send` | `1` | Disables sending on the socket. |
| `Both` | `2` | Disables both sending and receiving on the socket. |
