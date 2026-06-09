---
title: "WaitForEventResult Struct"
sidebar_label: "WaitForEventResult"
---

# WaitForEventResult Struct

**Namespace:** `System.Device.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.System.Device.Gpio`

Result of a `GpioController.WaitForEvent(int, PinEventTypes, TimeSpan)` call. Same shape as .NET IoT.

```csharp
public struct WaitForEventResult
```

## Fields

### EventTypes

```csharp
public PinEventTypes EventTypes
```

The edge that occurred, or `PinEventTypes.None` if the wait timed out or was cancelled.

### TimedOut

```csharp
public bool TimedOut
```

True if the wait elapsed (or was cancelled) before the event occurred.
