---
title: "SystemClock Enum"
sidebar_label: "SystemClock"
---

# SystemClock Enum

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

Core-clock profile.

```csharp
public enum SystemClock : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `High` | `0` | Standard high-speed clock. |
| `Low` | `1` | Reduced clock for lower power draw. |
| `Overclock` | `2` | Overclocked profile (may exceed datasheet spec). |
