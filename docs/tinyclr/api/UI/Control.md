---
title: "Control Class"
sidebar_label: "Control"
---

# Control Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class Control : UIElement
```

## Properties

### TabIndex

```csharp
public int TabIndex { get; set; }
```

Lower values are visited first by `Input.FocusNavigator`.

### IsTabStop

```csharp
public bool IsTabStop { get; set; }
```

When false, this control is skipped for keyboard focus navigation.

### ShowFocusVisual

```csharp
public bool ShowFocusVisual { get; set; }
```

When true and the control has focus, a focus rectangle is drawn.

### DataContext

```csharp
public object DataContext { get; set; }
```

Optional data context for lightweight binding (e.g. `TextBox.SetTextBinding`).

### Background

```csharp
public Media.Brush Background { get; set; }
```

_No description available._

### Font

```csharp
public System.Drawing.Font Font { get; set; }
```

_No description available._

### Foreground

```csharp
public Media.Brush Foreground { get; set; }
```

_No description available._

## Methods

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

_No description available._

### SolidColorBrush( Colors.Black)

```csharp
protected internal Media.Brush _foreground = new SolidColorBrush(Colors.Black)
```

_No description available._

**Returns** `Media.Brush _foreground = new`

## Fields

### _background

```csharp
protected internal Media.Brush _background
```

_No description available._

### _font

```csharp
protected internal System.Drawing.Font _font
```

_No description available._
