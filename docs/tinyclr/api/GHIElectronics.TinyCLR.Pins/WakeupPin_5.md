---
title: "WakeupPin Class"
sidebar_label: "WakeupPin"
---

# WakeupPin Class

**Namespace:** `GHIElectronics.TinyCLR.Pins` · **Assembly:** `GHIElectronics.TinyCLR.Pins`

Hardware wake-up pin bit flags for `GHIElectronics.TinyCLR.Native.Power.Shutdown(int, System.DateTime)`. OR-combine to allow any of the selected pins to wake the device. Bit position matches the STM32L4 PWR_WAKEUP_PINx slot index (bit N → WKUP(N+1)).

```csharp
public static class WakeupPin
```

## Fields

### PA0

```csharp
public const int PA0
```

PA0 — WKUP1.

### PC13

```csharp
public const int PC13
```

PC13 — WKUP2.

### PE6

```csharp
public const int PE6
```

PE6 — WKUP3.

### PA2

```csharp
public const int PA2
```

PA2 — WKUP4.

### PC5

```csharp
public const int PC5
```

PC5 — WKUP5.
