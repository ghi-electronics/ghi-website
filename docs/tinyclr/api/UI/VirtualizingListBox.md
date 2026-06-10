---
title: "VirtualizingListBox Class"
sidebar_label: "VirtualizingListBox"
---

# VirtualizingListBox Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Large homogeneous lists: recycles a small pool of rows while preserving full scroll extent. Set `ItemsSource` to an `IList` (e.g. `ArrayList`); each item is shown via `ToString()`.

```csharp
public class VirtualizingListBox : Control, IDisposable
```

## Constructors

### VirtualizingListBox()

```csharp
public VirtualizingListBox()
```

Initializes a new instance of the `VirtualizingListBox` class.

## Properties

### ItemsSource

```csharp
public IList ItemsSource { get; set; }
```

The list of items shown in the list box; each item is displayed via its `ToString()`.

### ItemHeight

```csharp
public int ItemHeight { get; set; }
```

Fixed row height in pixels (all rows use this for virtualization math).

### SelectedIndex

```csharp
public int SelectedIndex { get; set; }
```

The index of the currently selected item, or -1 if none is selected.

### HorizontalOffset

```csharp
public int HorizontalOffset { get; set; }
```

The current horizontal scroll offset of the list.

### VerticalOffset

```csharp
public int VerticalOffset { get; set; }
```

The current vertical scroll offset of the list.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the inner scroll viewer to determine the desired size.

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

Arranges the inner scroll viewer to fill the list box.

### Dispose()

```csharp
public void Dispose()
```

Detaches the list box's event handlers for deterministic teardown.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Detaches the list box's event handlers for deterministic teardown.

## Events

### SelectionChanged

```csharp
public event SelectionChangedEventHandler SelectionChanged
```

Raised when the selected item changes.
