---
title: "Slider Class"
sidebar_label: "Slider"
---

# Slider Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Horizontal or vertical value slider with optional tick marks and snap-to intervals. The knob is rendered with the shared Scale9 Button bitmaps so it picks up the theme's surface styling automatically.

```csharp
public class Slider : ContentControl, IDisposable
```

## Constructors

### Slider()

```csharp
public Slider() : this(0, 0)
```

_No description available._

### Slider(int width, int height)

```csharp
public Slider(int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `int` |  |
| `height` | `int` |  |

## Properties

### Alpha

```csharp
public ushort Alpha { get; set; }
```

_No description available._

### RadiusBorder

```csharp
public int RadiusBorder { get; set; }
```

Corner radius in pixels for the Scale9Image-rendered bar. _(inherited)_

### Orientation

```csharp
public Orientation Orientation { get; set; }
```

Logical screen rotation. _(inherited)_

### Minimum

```csharp
public double Minimum { get; set; }
```

_No description available._

### Maximum

```csharp
public double Maximum { get; set; }
```

_No description available._

### Value

```csharp
public double Value { get; set; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_

### KnobSize

```csharp
public int KnobSize { get; set; }
```

Knob size along the slide axis (px).

### TickInterval

```csharp
public int TickInterval { get; set; }
```

Number of tick mark intervals along the track. 0 disables ticks.

### SnapInterval

```csharp
public int SnapInterval { get; set; }
```

Number of snap stops along the track. 0 disables snap (continuous).

### TrackColor

```csharp
public Media.Color TrackColor { get; set; }
```

Color used for the track line and tick marks.

## Methods

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

### OnTouchDown(TouchEventArgs e)

```csharp
protected override void OnTouchDown(TouchEventArgs e)
```

Handles the touch down event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

Handles the touch up event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchMove(TouchEventArgs e)

```csharp
protected override void OnTouchMove(TouchEventArgs e)
```

Handles the touch move event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnButtonDown(ButtonEventArgs e)

```csharp
protected override void OnButtonDown(ButtonEventArgs e)
```

Hardware button support: Left/Right step a horizontal slider, Up/Down step a vertical slider. Step size is one snap interval, or 1% of the range when SnapInterval is 0.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

## Events

### ValueChanged

```csharp
public event ValueChangedEventHandler ValueChanged
```

Raised when the pin transitions on an edge selected by `ValueChangedEdge`. The handler runs on the driver's event thread — keep it short and avoid blocking. _(inherited)_
