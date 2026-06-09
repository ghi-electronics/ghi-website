---
title: "TouchEventArgs Class"
sidebar_label: "TouchEventArgs"
---

# TouchEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

_No description available._

```csharp
public class TouchEventArgs : InputEventArgs
```

## Constructors

### TouchEventArgs(InputDevice inputDevice, DateTime timestamp, TouchInput[] touches)

```csharp
public TouchEventArgs(InputDevice inputDevice, DateTime timestamp, TouchInput[] touches) : base(inputDevice, timestamp)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `inputDevice` | `InputDevice` |  |
| `timestamp` | `DateTime` |  |
| `touches` | `TouchInput[]` |  |

## Methods

### GetPosition(UIElement relativeTo, int touchIndex, out int x, out int y)

```csharp
public void GetPosition(UIElement relativeTo, int touchIndex, out int x, out int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `relativeTo` | `UIElement` |  |
| `touchIndex` | `int` |  |
| `x` | `out int` |  |
| `y` | `out int` |  |

## Fields

### Touches

```csharp
public TouchInput[] Touches
```

_No description available._
