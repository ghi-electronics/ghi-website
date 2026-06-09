---
title: "ScrollViewer Class"
sidebar_label: "ScrollViewer"
---

# ScrollViewer Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class ScrollViewer : ContentControl
```

## Constructors

### ScrollViewer()

```csharp
public ScrollViewer()
```

_No description available._

## Properties

### HorizontalOffset

```csharp
public int HorizontalOffset { get; set; }
```

_No description available._

### VerticalOffset

```csharp
public int VerticalOffset { get; set; }
```

_No description available._

### ExtentHeight

```csharp
public int ExtentHeight { get; }
```

_No description available._

### ExtentWidth

```csharp
public int ExtentWidth { get; }
```

_No description available._

### LineWidth

```csharp
public int LineWidth { get; set; }
```

_No description available._

### LineHeight

```csharp
public int LineHeight { get; set; }
```

_No description available._

### ScrollingStyle

```csharp
public ScrollingStyle ScrollingStyle { get; set; }
```

_No description available._

## Methods

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

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

ArrangeOverride allows for the customization of the final sizing and positioning of children. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `arrangeWidth` | `int` | Final width |
| `arrangeHeight` | `int` | Final height |

### LineDown()

```csharp
public void LineDown()
```

_No description available._

### LineLeft()

```csharp
public void LineLeft()
```

_No description available._

### LineRight()

```csharp
public void LineRight()
```

_No description available._

### LineUp()

```csharp
public void LineUp()
```

_No description available._

### PageDown()

```csharp
public void PageDown()
```

_No description available._

### PageLeft()

```csharp
public void PageLeft()
```

_No description available._

### PageRight()

```csharp
public void PageRight()
```

_No description available._

### PageUp()

```csharp
public void PageUp()
```

_No description available._

### OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)

```csharp
protected override void OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)
```

An event reporting a button was pressed. _(inherited)_

## Events

### ScrollChanged

```csharp
public event ScrollChangedEventHandler ScrollChanged
```

_No description available._
