---
title: "CanError Enum"
sidebar_label: "CanError"
---

# CanError Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Can` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Can`

Categories of error reported via `CanController.ErrorReceived`.

```csharp
public enum CanError
```

## Fields

| Name | Value | Description |
|---|---|---|
| `ReadBufferOverrun` | `0` | Receive overrun. |
| `ReadBufferFull` | `1` | Receive buffer full; subsequent messages will be dropped. |
| `BusOff` | `2` | Controller has entered bus-off state and stopped transmitting. |
| `Passive` | `3` | Controller has entered error-passive state. |
