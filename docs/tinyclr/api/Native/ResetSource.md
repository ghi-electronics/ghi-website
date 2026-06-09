---
title: "ResetSource Enum"
sidebar_label: "ResetSource"
---

# ResetSource Enum

**Namespace:** `GHIElectronics.TinyCLR.Native` · **Assembly:** `GHIElectronics.TinyCLR.Native`

Reasons reported by `Power.GetResetSource`.

```csharp
public enum ResetSource : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Other` | `0` | Reason not categorized. |
| `PowerOn` | `1` | Cold start (rail came up from zero). |
| `ResetPin` | `2` | Hardware NRST line was asserted. |
| `BrownoutReset` | `4` | Supply rail dipped below the brown-out threshold. |
| `SystemReset` | `8` | Firmware-initiated soft reset (e.g. `Power.Reset`). |
| `WatchdogReset` | `16` | Watchdog timer expired without being kicked. |
| `LowPowerRtc` | `32` | Resumed from low-power state by the RTC alarm. |
| `LowPowerWakeupPin` | `64` | Resumed from low-power state by the wake-up pin. |
