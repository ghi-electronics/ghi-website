---
title: "WheelMovedEventArgs Class"
sidebar_label: "WheelMovedEventArgs"
---

# WheelMovedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The events args for the WheelMoved event.

```csharp
public class WheelMovedEventArgs : EventArgs
```

## Properties

### NewPosition

```csharp
public int NewPosition { get; set; }
```

The new position of the wheel.

### Delta

```csharp
public int Delta { get; set; }
```

The change from the last position.
