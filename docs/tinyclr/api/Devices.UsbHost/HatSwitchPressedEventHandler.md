---
title: "HatSwitchPressedEventHandler Delegate"
sidebar_label: "HatSwitchPressedEventHandler"
---

# HatSwitchPressedEventHandler Delegate

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The delegate for when the joystick's hat switch is pressed.

```csharp
public delegate void HatSwitchPressedEventHandler(Joystick sender, HatSwitchPressedEventArgs e);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `Joystick` | The joystick associated with this event. |
| `e` | `HatSwitchPressedEventArgs` | The event arguments. |
