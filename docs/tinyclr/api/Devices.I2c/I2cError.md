---
title: "I2cError Enum"
sidebar_label: "I2cError"
---

# I2cError Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c`

Bus errors reported via `I2cDevice.ErrorReceived`.

```csharp
public enum I2cError
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Overrun` | `0` | Receive overrun. |
| `Bus` | `1` | Generic bus error. |
| `ArbitrationLoss` | `2` | Lost arbitration to another master. |
| `BufferFull` | `3` | Internal buffer full. |
