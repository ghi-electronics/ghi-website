---
title: "TextBox Class"
sidebar_label: "TextBox"
---

# TextBox Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class TextBox : Control
```

## Constructors

### TextBox()

```csharp
public TextBox()
```

_No description available._

## Properties

### TextAlign

```csharp
public TextAlignment TextAlign { get; set; }
```

_No description available._

### PasswordChar

```csharp
public char PasswordChar { get; set; }
```

_No description available._

### Text

```csharp
public string Text { get; set; }
```

_No description available._

### BorderColor

```csharp
public Color BorderColor { get; set; }
```

_No description available._

### BorderThickness

```csharp
public ushort BorderThickness { get; set; }
```

_No description available._

### PaddingX

```csharp
public ushort PaddingX { get; set; }
```

_No description available._

### PaddingY

```csharp
public ushort PaddingY { get; set; }
```

_No description available._

## Methods

### SetTextBinding(object source, string propertyName, bool twoWay)

```csharp
public void SetTextBinding(object source, string propertyName, bool twoWay = true)
```

One-way or two-way bind `Text` to a CLR property on `source` using reflection. For change notifications implement `INotifyBindablePropertyChanged` on the source.

| Parameter | Type | Description |
|---|---|---|
| `source` | `object` |  |
| `propertyName` | `string` |  |
| `twoWay` | `bool` |  |

### ClearTextBinding()

```csharp
public void ClearTextBinding()
```

_No description available._

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

Handles the touch up event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnButtonDown(ButtonEventArgs e)

```csharp
protected override void OnButtonDown(ButtonEventArgs e)
```

Hardware button support: `HardwareButton.Select` opens the on-screen keyboard, mirroring tap-to-edit behavior.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

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

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

## Events

### TextChanged

```csharp
public event TextChangedEventHandler TextChanged
```

_No description available._

### BindingError

```csharp
public event BindingErrorEventHandler BindingError
```

Raised when a binding pull (source → TextBox) or push (TextBox → source) fails. Default behavior is silent (the framework can't sensibly recover); subscribe here to log or surface the error during development.
