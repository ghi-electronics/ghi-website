---
title: "Interrupt Class"
sidebar_label: "Interrupt"
---

# Interrupt Class

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

CPU interrupt mask. Wrap a tight critical section in `Disable`/`Enable` to prevent context switches and hardware interrupts from running during it. Keep the disabled window short — while interrupts are off, RTOS threads cannot preempt and ISR latencies grow.

```csharp
public static class Interrupt
```

## Methods

### Enable()

```csharp
public static extern void Enable()
```

Re-enables interrupts after a matching `Disable`.

### Disable()

```csharp
public static extern void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`.

### IsDisabled()

```csharp
public static extern bool IsDisabled()
```

True when interrupts are currently masked.

**Returns** `bool`
