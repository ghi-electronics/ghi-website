---
title: "ScrollViewer Class"
sidebar_label: "ScrollViewer"
---

# ScrollViewer Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

A container that lets a single child be scrolled horizontally and vertically within a smaller viewport.

```csharp
public class ScrollViewer : ContentControl
```

## Constructors

### ScrollViewer()

```csharp
public ScrollViewer()
```

Initializes a new instance of the `ScrollViewer` class.

## Properties

### HorizontalOffset

```csharp
public int HorizontalOffset { get; set; }
```

The current horizontal scroll offset, clamped to the scrollable range.

### VerticalOffset

```csharp
public int VerticalOffset { get; set; }
```

The current vertical scroll offset, clamped to the scrollable range.

### ExtentHeight

```csharp
public int ExtentHeight { get; }
```

The full height of the scrollable content.

### ExtentWidth

```csharp
public int ExtentWidth { get; }
```

The full width of the scrollable content.

### LineWidth

```csharp
public int LineWidth { get; set; }
```

The horizontal distance scrolled by one line step.

### LineHeight

```csharp
public int LineHeight { get; set; }
```

The vertical distance scrolled by one line step.

### ScrollingStyle

```csharp
public ScrollingStyle ScrollingStyle { get; set; }
```

Whether hardware-button scrolling advances by line or by page.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the child against the viewer's alignment and records its extent.

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

Positions the child according to the current scroll offsets.

### LineDown()

```csharp
public void LineDown()
```

Scrolls down by one line.

### LineLeft()

```csharp
public void LineLeft()
```

Scrolls left by one line.

### LineRight()

```csharp
public void LineRight()
```

Scrolls right by one line.

### LineUp()

```csharp
public void LineUp()
```

Scrolls up by one line.

### PageDown()

```csharp
public void PageDown()
```

Scrolls down by one page (the viewport height).

### PageLeft()

```csharp
public void PageLeft()
```

Scrolls left by one page (the viewport width).

### PageRight()

```csharp
public void PageRight()
```

Scrolls right by one page (the viewport width).

### PageUp()

```csharp
public void PageUp()
```

Scrolls up by one page (the viewport height).

### OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)

```csharp
protected override void OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)
```

Handles directional hardware buttons by scrolling by line or page.

## Events

### ScrollChanged

```csharp
public event ScrollChangedEventHandler ScrollChanged
```

Raised when the scroll offset changes.
