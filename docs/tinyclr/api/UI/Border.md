---
title: "Border Class"
sidebar_label: "Border"
---

# Border Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class Border : ContentControl
```

## Constructors

### Border()

```csharp
public Border()
```

Legacy alias for `RadiusBorder`. Will be removed. _(inherited)_

## Properties

### BorderBrush

```csharp
public Media.Brush BorderBrush { get; set; }
```

_No description available._

## Methods

### GetBorderThickness(out int left, out int top, out int right, out int bottom)

```csharp
public void GetBorderThickness(out int left, out int top, out int right, out int bottom)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `left` | `out int` |  |
| `top` | `out int` |  |
| `right` | `out int` |  |
| `bottom` | `out int` |  |

### SetBorderThickness(int length)

```csharp
public void SetBorderThickness(int length)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `length` | `int` |  |

### SetBorderThickness(int left, int top, int right, int bottom)

```csharp
public void SetBorderThickness(int left, int top, int right, int bottom)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `left` | `int` |  |
| `top` | `int` |  |
| `right` | `int` |  |
| `bottom` | `int` |  |

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

ArrangeOverride allows for the customization of the positioning of children. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `arrangeWidth` | `int` |  |
| `arrangeHeight` | `int` |  |

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measurement override. Implement your size-to-content logic here. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `availableWidth` | `int` | Available size that parent can give to the child. May be MaxValue(when parent wants to measure to content). This is soft constraint. Child can return bigger size to indicate that it wants bigger space and hope that parent can throw in scrolling... |
| `availableHeight` | `int` |  |
| `desiredWidth` | `out int` |  |
| `desiredHeight` | `out int` |  |

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |
