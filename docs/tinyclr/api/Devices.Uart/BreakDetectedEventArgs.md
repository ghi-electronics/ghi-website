---
title: "BreakDetectedEventArgs Class"
sidebar_label: "BreakDetectedEventArgs"
---

# BreakDetectedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`

Arguments for break-condition events (reserved; not raised by the standard controller).

```csharp
public class BreakDetectedEventArgs
```

## Properties

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the break.
