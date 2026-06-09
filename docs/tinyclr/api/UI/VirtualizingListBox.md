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

_No description available._

## Properties

### ItemsSource

```csharp
public IList ItemsSource { get; set; }
```

_No description available._

### ItemHeight

```csharp
public int ItemHeight { get; set; }
```

Fixed row height in pixels (all rows use this for virtualization math).

### SelectedIndex

```csharp
public int SelectedIndex { get; set; }
```

The currently selected index. _(inherited)_

### HorizontalOffset

```csharp
public int HorizontalOffset { get; set; }
```

Horizontal offset of the scroll. _(inherited)_

### VerticalOffset

```csharp
public int VerticalOffset { get; set; }
```

Vertical offset of the scroll. _(inherited)_

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

ArrangeOverride allows for the customization of the positioning of children. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `arrangeWidth` | `int` |  |
| `arrangeHeight` | `int` |  |

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

### SelectionChanged

```csharp
public event SelectionChangedEventHandler SelectionChanged
```

_No description available._
