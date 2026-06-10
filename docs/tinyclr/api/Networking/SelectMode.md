---
title: "SelectMode Enum"
sidebar_label: "SelectMode"
---

# SelectMode Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Specifies the mode for polling the status of a socket.

```csharp
public enum SelectMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `SelectRead` | `0` | Poll the read status of a socket. |
| `SelectWrite` | `1` | Poll the write status of a socket. |
| `SelectError` | `2` | Poll the error status of a socket. |
