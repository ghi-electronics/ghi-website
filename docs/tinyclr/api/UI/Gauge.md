---
title: "Gauge Class"
sidebar_label: "Gauge"
---

# Gauge Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

Analog gauge with calibrated tick marks, optional threshold arc, optional seven-segment digital readout, dial label, and pointer needle. Always square — pass the side length to the constructor. Rendering is cached: the static background (dial face, calibration, threshold, digital number, label) is drawn once into a backing bitmap; only the pointer is redrawn each paint. Any property change marks the background dirty.

```csharp
public class Gauge : Image, IDisposable
```

## Constructors

### Gauge(int side)

```csharp
public Gauge(int side) : base()
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `side` | `int` |  |

## Properties

### Font

```csharp
public Font Font { get; set; }
```

Font used by the text. _(inherited)_

### EnableDigitalNumber

```csharp
public bool EnableDigitalNumber { get; set; }
```

_No description available._

### EnableThreshold

```csharp
public bool EnableThreshold { get; set; }
```

_No description available._

### BackColor

```csharp
public MediaColor BackColor { get; set; }
```

_No description available._

### DialColor

```csharp
public MediaColor DialColor { get; set; }
```

_No description available._

### ForeColor

```csharp
public MediaColor ForeColor { get; set; }
```

_No description available._

### MinValue

```csharp
public float MinValue { get; set; }
```

Smallest raw value accepted by `Write(int, int)`. _(inherited)_

### MaxValue

```csharp
public float MaxValue { get; set; }
```

Largest raw value accepted by `Write(int, int)`. _(inherited)_

### ThresholdPercent

```csharp
public float ThresholdPercent { get; set; }
```

Threshold area around the recommended value, 1–99%.

### RecommendedValue

```csharp
public float RecommendedValue { get; set; }
```

_No description available._

### Value

```csharp
public float Value { get; set; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame.

### Glossiness

```csharp
public float Glossiness { get; set; }
```

Glossiness strength 0..100 (mapped to 0..220 alpha internally).

### NoOfDivisions

```csharp
public int NoOfDivisions { get; set; }
```

_No description available._

### NoOfSubDivisions

```csharp
public int NoOfSubDivisions { get; set; }
```

_No description available._

### DialText

```csharp
public string DialText { get; set; }
```

_No description available._

### EnableTransparentBackground

```csharp
public bool EnableTransparentBackground { get; set; }
```

When true, the dial face is overlapped by a slightly larger ellipse in the back color so the dial appears to float. Costs an extra FillEllipse per redraw.

## Methods

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

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |
