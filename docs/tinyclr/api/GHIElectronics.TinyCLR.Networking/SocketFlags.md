---
title: "SocketFlags Enum"
sidebar_label: "SocketFlags"
---

# SocketFlags Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Provides constant values for socket messages.

```csharp
public enum SocketFlags
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0x0000` | Use no flags for this call. |
| `OutOfBand` | `0x0001` | Process out-of-band data. |
| `Peek` | `0x0002` | Peek at incoming message. |
| `DontRoute` | `0x0004` | Send without using routing tables. |
| `MaxIOVectorLength` | `0x0010` | The maximum number of buffers that can be used in a single send or receive call. |
| `Truncated` | `0x0100` | Partial send or recv for message. |
| `ControlDataTruncated` | `0x0200` | The control (ancillary) data was truncated. |
| `Broadcast` | `0x0400` | The message was sent or received as a broadcast. |
| `Multicast` | `0x0800` | The message was sent or received as a multicast. |
| `Partial` | `0x8000` | A partial message was sent or received. |
