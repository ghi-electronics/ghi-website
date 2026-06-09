---
title: "I2cTransferStatus Enum"
sidebar_label: "I2cTransferStatus"
---

# I2cTransferStatus Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c` · **Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`

Outcome of an I²C transfer.

```csharp
public enum I2cTransferStatus
```

## Fields

| Name | Value | Description |
|---|---|---|
| `FullTransfer` | `0` | All requested bytes were transferred successfully. |
| `PartialTransfer` | `1` | Some, but not all, requested bytes were transferred. |
| `SlaveAddressNotAcknowledged` | `2` | The slave did not acknowledge its address. |
| `ClockStretchTimeout` | `3` | The slave held the clock low past the configured timeout. |
