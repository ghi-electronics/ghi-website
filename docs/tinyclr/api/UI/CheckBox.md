---
title: "CheckBox Class"
sidebar_label: "CheckBox"
---

# CheckBox Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class CheckBox : ContentControl, IDisposable
```

## Constructors

### CheckBox()

```csharp
public CheckBox() : base()
```

_No description available._

## Properties

### Name

```csharp
public string Name { get; set; }
```

The native API name. _(inherited)_

### Alpha

```csharp
public ushort Alpha { get; set; }
```

_No description available._

### RadiusBorder

```csharp
public ushort RadiusBorder { get; set; }
```

Corner radius in pixels for the Scale9Image-rendered bar. _(inherited)_

### IsChecked

```csharp
public bool IsChecked { get; set; }
```

_No description available._

## Methods

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

Handles the touch up event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchDown(TouchEventArgs e)

```csharp
protected override void OnTouchDown(TouchEventArgs e)
```

Handles the touch down event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnButtonUp(ButtonEventArgs e)

```csharp
protected override void OnButtonUp(ButtonEventArgs e)
```

An event reporting a button was released. _(inherited)_

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

### Click

```csharp
public event RoutedEventHandler Click
```

Fires when the user commits the current selection — either by tapping a ListBoxItem or by pressing `HardwareButton.Select` while the ListBox has focus. The event source is the committed `ListBoxItem`. _(inherited)_

### Checked

```csharp
public event RoutedEventHandler Checked
```

_No description available._

### Unchecked

```csharp
public event RoutedEventHandler Unchecked
```

_No description available._
