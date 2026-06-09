---
title: "Power Class"
sidebar_label: "Power"
---

# Power Class

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

Power-management entry points: `Reset` for a soft reset, `Sleep()` for low-power stop with wake-up, `Shutdown` for power-off with RTC/pin wake-up, and `SetSystemClock` for dynamic clock scaling.

```csharp
public static class Power
```

## Methods

### Reset()

```csharp
public static void Reset()
```

Soft-resets the device, re-running the app afterward.

### Sleep()

```csharp
public static void Sleep()
```

Enters Sleep3 (deepest sleep). Wakes on any GPIO EXTI interrupt.

### Sleep(DateTime wakeupTime)

```csharp
public static void Sleep(DateTime wakeupTime)
```

Enters Sleep3 with an optional wake time. Pass `DateTime.MaxValue` for "pin only".

| Parameter | Type | Description |
|---|---|---|
| `wakeupTime` | `DateTime` |  |

### Shutdown(int wakeupPins, DateTime wakeupTime)

```csharp
public static void Shutdown(int wakeupPins, DateTime wakeupTime)
```

Powers off until either one of the selected wake-up pins asserts or the RTC alarm fires.

| Parameter | Type | Description |
|---|---|---|
| `wakeupPins` | `int` | OR-combined wake-up pin bit mask. Each SoC's pin-package exposes a `WakeupPin` class (e.g. `SC20260.WakeupPin.PA0`) with one `int` constant per pin its hardware can wake on; OR them together to allow any of those pins to wake the device. Pass `0` for RTC-only wake. A bit not routed to this SoC's wake-up peripheral throws `ArgumentException`. Example: `Power.Shutdown(SC20260.WakeupPin.PA0 \| SC20260.WakeupPin.PA2, t)`. |
| `wakeupTime` | `DateTime` | Wall-clock time at which the RTC should wake the device, or `DateTime.MaxValue` for "pin only". |

### SetSystemClock(SystemClock clock, bool persist)

```csharp
public static extern void SetSystemClock(SystemClock clock, bool persist)
```

Switches the core-clock profile. `persist` stores the choice across resets.

| Parameter | Type | Description |
|---|---|---|
| `clock` | `SystemClock` |  |
| `persist` | `bool` |  |

### GetSystemClock()

```csharp
public static extern SystemClock GetSystemClock()
```

Returns the current core-clock profile.

**Returns** `SystemClock`

### Reset(bool runCoreAfter)

```csharp
public static extern void Reset(bool runCoreAfter)
```

Soft-resets the device. When `runCoreAfter` is true, the app re-runs after reset; otherwise the device boots to bootloader.

| Parameter | Type | Description |
|---|---|---|
| `runCoreAfter` | `bool` |  |

### GetResetSource()

```csharp
public static extern ResetSource GetResetSource()
```

Returns the reason for the most recent reset.

**Returns** `ResetSource`

## Fields

### WakeupEdge

```csharp
public static WakeupEdge WakeupEdge
```

Polarity used by `Shutdown` when waking from a pin event. Applies to every pin set in the wake-up bit mask.
