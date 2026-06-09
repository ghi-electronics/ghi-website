---
title: "ListBox Class"
sidebar_label: "ListBox"
---

# ListBox Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class ListBox : ContentControl
```

## Constructors

### ListBox()

```csharp
public ListBox()
```

_No description available._

## Properties

### Items

```csharp
public ListBoxItemCollection Items { get; }
```

_No description available._

### SelectedIndex

```csharp
public int SelectedIndex { get; set; }
```

The currently selected index. _(inherited)_

### SelectedItem

```csharp
public ListBoxItem SelectedItem { get; set; }
```

_No description available._

### HorizontalOffset

```csharp
public int HorizontalOffset { get; set; }
```

Horizontal offset of the scroll.

### VerticalOffset

```csharp
public int VerticalOffset { get; set; }
```

Vertical offset of the scroll.

### ExtentHeight

```csharp
public int ExtentHeight { get; }
```

Extent height of the scroll area.

### ExtentWidth

```csharp
public int ExtentWidth { get; }
```

Extent width of the scroll area.

### ScrollingStyle

```csharp
public ScrollingStyle ScrollingStyle { get; set; }
```

The scrolling style.

## Methods

### ScrollIntoView(ListBoxItem item)

```csharp
public void ScrollIntoView(ListBoxItem item)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `item` | `ListBoxItem` |  |

### OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)

```csharp
protected override void OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)
```

An event reporting a button was pressed. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs` |  |

## Events

### Click

```csharp
public event RoutedEventHandler Click
```

Fires when the user commits the current selection — either by tapping a ListBoxItem or by pressing `HardwareButton.Select` while the ListBox has focus. The event source is the committed `ListBoxItem`.

### SelectionChanged

```csharp
public event SelectionChangedEventHandler SelectionChanged
```

_No description available._

### ScrollChanged

```csharp
public event ScrollChangedEventHandler ScrollChanged
```

Event handler if the scroll changes.
