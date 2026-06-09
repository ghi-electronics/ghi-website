---
title: "WheelMovedEventArgs Class"
sidebar_label: "WheelMovedEventArgs"
---

# WheelMovedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

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
