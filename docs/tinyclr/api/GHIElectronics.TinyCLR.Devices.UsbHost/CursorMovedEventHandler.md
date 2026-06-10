---
title: "CursorMovedEventHandler Delegate"
sidebar_label: "CursorMovedEventHandler"
---

# CursorMovedEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The delegate for when one of the joystick's cursors moves.

```csharp
public delegate void CursorMovedEventHandler(Joystick sender, CursorMovedEventArgs e);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `Joystick` | The joystick associated with this event. |
| `e` | `CursorMovedEventArgs` | The event arguments. |
