---
title: "Button Class"
sidebar_label: "Button"
---

# Button Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class Button : ContentControl, IDisposable
```

## Constructors

### Button()

```csharp
public Button()
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

Corner radius in pixels for the Scale9Image-rendered bar. _(inherited)_

### IsPressed

```csharp
public bool IsPressed { get; }
```

_No description available._

## Methods

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

### OnButtonDown(ButtonEventArgs e)

```csharp
protected override void OnButtonDown(ButtonEventArgs e)
```

An event reporting a button was pressed. _(inherited)_

### OnButtonUp(ButtonEventArgs e)

```csharp
protected override void OnButtonUp(ButtonEventArgs e)
```

An event reporting a button was released. _(inherited)_

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

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
