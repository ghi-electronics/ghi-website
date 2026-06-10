---
title: "RadioButton Class"
sidebar_label: "RadioButton"
---

# RadioButton Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

A selectable button that is mutually exclusive with other buttons sharing its group name.

```csharp
public class RadioButton : ContentControl, IDisposable
```

## Constructors

### RadioButton()

```csharp
public RadioButton() : this(string.Empty)
```

Initializes a new radio button with no group name.

### RadioButton(string groupName)

```csharp
public RadioButton(string groupName) : base()
```

Initializes a new radio button belonging to the given group.

## Properties

### Name

```csharp
public string Name { get; set; }
```

The identifying name of this button within its group.

### Alpha

```csharp
public ushort Alpha { get; set; }
```

The opacity applied when rendering the button.

### RadiusBorder

```csharp
public int RadiusBorder { get; set; }
```

Corner radius in pixels for the Scale9-rendered background.

### ShowBackground

```csharp
public bool ShowBackground { get; set; }
```

Whether the bitmap background is drawn behind the button.

### Value

```csharp
public string Value { get; set; }
```

The button's value when checked, or an empty string when unchecked.

### Checked

```csharp
public bool Checked { get; set; }
```

Whether the button is currently selected.

### GroupName

```csharp
public string GroupName { get; set; }
```

The name of the group this button belongs to.

### OutlineUnselectColor

```csharp
public GHIElectronics.TinyCLR.UI.Media.Color OutlineUnselectColor { get; set; }
```

The outline color of the indicator when the button is unchecked.

### SelectedOutlineColor

```csharp
public GHIElectronics.TinyCLR.UI.Media.Color SelectedOutlineColor { get; set; }
```

The outline color of the indicator when the button is checked.

### SelectedColor

```csharp
public GHIElectronics.TinyCLR.UI.Media.Color SelectedColor { get; set; }
```

The fill color of the indicator when the button is checked.

## Methods

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the radio button background and its checked/unchecked indicator.

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

Handles a touch release by clicking and toggling the button.

### OnTouchDown(TouchEventArgs e)

```csharp
protected override void OnTouchDown(TouchEventArgs e)
```

Handles a touch press; the click is performed on release instead.

### OnButtonUp(ButtonEventArgs e)

```csharp
protected override void OnButtonUp(ButtonEventArgs e)
```

Handles the Select hardware button by clicking and toggling the button.

### Toggle()

```csharp
public void Toggle()
```

Toggles the checked state, unselecting any other button in the group.

### Dispose()

```csharp
public void Dispose()
```

Releases the bitmap resources used by the radio button.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the bitmap resources used by the radio button.

## Events

### Click

```csharp
public event RoutedEventHandler Click
```

Raised when the button is clicked.
