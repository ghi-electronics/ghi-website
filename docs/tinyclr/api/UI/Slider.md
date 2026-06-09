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

_No description available._

### Orientation

```csharp
public Orientation Orientation { get; set; }
```

_No description available._

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

_No description available._

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

_No description available._

### OnTouchDown(TouchEventArgs e)

```csharp
protected override void OnTouchDown(TouchEventArgs e)
```

_No description available._

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

_No description available._

### OnTouchMove(TouchEventArgs e)

```csharp
protected override void OnTouchMove(TouchEventArgs e)
```

_No description available._

### OnButtonDown(ButtonEventArgs e)

```csharp
protected override void OnButtonDown(ButtonEventArgs e)
```

Hardware button support: Left/Right step a horizontal slider, Up/Down step a vertical slider. Step size is one snap interval, or 1% of the range when SnapInterval is 0.

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._

## Events

### ValueChanged

```csharp
public event ValueChangedEventHandler ValueChanged
```

_No description available._
