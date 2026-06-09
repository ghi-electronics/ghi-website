---
title: "I2cTransaction Enum"
sidebar_label: "I2cTransaction"
---

# I2cTransaction Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c`

Master-initiated transaction kind observed by a slave.

```csharp
public enum I2cTransaction
```

## Fields

| Name | Value | Description |
|---|---|---|
| `MasterWrite` | `0` | Master is writing to this slave. |
| `MasterRead` | `1` | Master is reading from this slave. |
| `MasterStop` | `2` | Master issued a stop condition. |
