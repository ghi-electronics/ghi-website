---
title: "CursorMovedEventHandler Delegate"
sidebar_label: "CursorMovedEventHandler"
---

# CursorMovedEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The delegate for when the mouse's cursor moves.

```csharp
public delegate void CursorMovedEventHandler(Mouse sender, CursorMovedEventArgs e);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `Mouse` | The mouse associated with this event. |
| `e` | `CursorMovedEventArgs` | The event arguments. |
