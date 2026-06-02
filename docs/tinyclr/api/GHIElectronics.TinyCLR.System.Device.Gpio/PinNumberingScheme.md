---
title: "PinNumberingScheme Enum"
sidebar_label: "PinNumberingScheme"
---

# PinNumberingScheme Enum

**Namespace:** `System.Device.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.System.Device.Gpio`

How `GpioController` interprets pin numbers — TinyCLR uses `Logical`.

```csharp
public enum PinNumberingScheme
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Logical` | `0` | Driver-relative logical pin index. |
| `Board` | `1` | Physical board header pin number. |
| `Bcm` | `2` | Broadcom SoC pin number (Raspberry Pi convention). |
