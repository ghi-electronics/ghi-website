---
title: "PinEventTypes Enum"
sidebar_label: "PinEventTypes"
---

# PinEventTypes Enum

**Namespace:** `System.Device.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.System.Device.Gpio`

Edge selector for `GpioController` change notifications. Same shape as .NET IoT.

```csharp
public enum PinEventTypes
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No edge — returned by `GpioController.WaitForEvent(int, PinEventTypes, TimeSpan)` when it times out or is cancelled. |
| `Rising` | `1` | Rising edge (low → high). |
| `Falling` | `2` | Falling edge (high → low). |
