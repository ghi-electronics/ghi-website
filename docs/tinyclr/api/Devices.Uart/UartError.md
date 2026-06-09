---
title: "UartError Enum"
sidebar_label: "UartError"
---

# UartError Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart`

Categories of error reported via `UartController.ErrorReceived`.

```csharp
public enum UartError
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Frame` | `0` | Stop bit not detected at the expected time. |
| `Overrun` | `1` | Receive overrun — incoming byte arrived before the previous one was consumed. |
| `BufferFull` | `2` | Internal buffer full; subsequent bytes will be dropped. |
| `ReceiveParity` | `3` | Parity bit did not match. |
