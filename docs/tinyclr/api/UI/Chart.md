---
title: "Chart Class"
sidebar_label: "Chart"
---

# Chart Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Simple line / bar chart. The rendered surface is cached and only rebuilt when `Refresh` is called or the control's render size changes — so calling Invalidate on the parent each frame does not redo the chart math.

```csharp
public class Chart : Image, IDisposable
```

## Constructors

### Chart(int width, int height)

```csharp
public Chart(int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `int` |  |
| `height` | `int` |  |

## Properties

### DivisionAxisX

```csharp
public int DivisionAxisX { get; set; }
```

_No description available._

### DivisionAxisY

```csharp
public int DivisionAxisY { get; set; }
```

_No description available._

### Font

```csharp
public Font Font { get; set; }
```

Font used by the text. _(inherited)_

### AxisPen

```csharp
public Media.Pen AxisPen { get; set; }
```

_No description available._

### ChartPen

```csharp
public Media.Pen ChartPen { get; set; }
```

_No description available._

### EllipseColor

```csharp
public Media.SolidColorBrush EllipseColor { get; set; }
```

_No description available._

### DivisionColor

```csharp
public Media.SolidColorBrush DivisionColor { get; set; }
```

_No description available._

### TextColor

```csharp
public Media.SolidColorBrush TextColor { get; set; }
```

_No description available._

### BackgroundColor

```csharp
public Media.SolidColorBrush BackgroundColor { get; set; }
```

_No description available._

### RadiusPoint

```csharp
public int RadiusPoint { get; set; }
```

_No description available._

### ChartTitle

```csharp
public string ChartTitle { get; set; }
```

_No description available._

### Items

```csharp
public ArrayList Items { get; set; }
```

_No description available._

### Mode

```csharp
public ChartMode Mode { get; set; }
```

SPI mode (clock polarity + phase). See `SpiMode`. _(inherited)_

## Methods

### Refresh()

```csharp
public void Refresh()
```

Marks the cached chart surface stale. Call after mutating `Items` or any styling property to force a re-render on the next paint.

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

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
