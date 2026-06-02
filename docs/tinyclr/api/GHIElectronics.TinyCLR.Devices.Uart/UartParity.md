---
title: "UartParity Enum"
sidebar_label: "UartParity"
---

# UartParity Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`

Parity bit policy for a UART frame.

```csharp
public enum UartParity
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No parity bit transmitted. |
| `Odd` | `1` | Odd parity. |
| `Even` | `2` | Even parity. |
| `Mark` | `3` | Mark parity (parity bit always 1). |
| `Space` | `4` | Space parity (parity bit always 0). |
