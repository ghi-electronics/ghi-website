---
title: "CursorMovedEventArgs Class"
sidebar_label: "CursorMovedEventArgs"
---

# CursorMovedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The events args for the CursorMoved event.

```csharp
public class CursorMovedEventArgs : EventArgs
```

## Properties

### Which

```csharp
public Cursor Which { get; set; }
```

The index of the changed button.

### NewPosition

```csharp
public Position NewPosition { get; set; }
```

The new state of the button.

### Delta

```csharp
public Position Delta { get; set; }
```

The change from the last position.
