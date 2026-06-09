---
title: "RadioButton Class"
sidebar_label: "RadioButton"
---

# RadioButton Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class RadioButton : ContentControl, IDisposable
```

## Constructors

### RadioButton()

```csharp
public RadioButton() : this(string.Empty)
```

_No description available._

### RadioButton(string groupName)

```csharp
public RadioButton(string groupName) : base()
```

_No description available._

## Properties

### Name

```csharp
public string Name { get; set; }
```

_No description available._

### Alpha

```csharp
public ushort Alpha { get; set; }
```

_No description available._

### RadiusBorder

```csharp
public int RadiusBorder { get; set; }
```

_No description available._

### ShowBackground

```csharp
public bool ShowBackground { get; set; }
```

_No description available._

### Value

```csharp
public string Value { get; set; }
```

_No description available._

### Checked

```csharp
public bool Checked { get; set; }
```

_No description available._

### GroupName

```csharp
public string GroupName { get; set; }
```

_No description available._

### OutlineUnselectColor

```csharp
public GHIElectronics.TinyCLR.UI.Media.Color OutlineUnselectColor { get; set; }
```

_No description available._

### SelectedOutlineColor

```csharp
public GHIElectronics.TinyCLR.UI.Media.Color SelectedOutlineColor { get; set; }
```

_No description available._

### SelectedColor

```csharp
public GHIElectronics.TinyCLR.UI.Media.Color SelectedColor { get; set; }
```

_No description available._

## Methods

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

_No description available._

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

_No description available._

### OnTouchDown(TouchEventArgs e)

```csharp
protected override void OnTouchDown(TouchEventArgs e)
```

_No description available._

### OnButtonUp(ButtonEventArgs e)

```csharp
protected override void OnButtonUp(ButtonEventArgs e)
```

An event reporting a button was released. _(inherited)_

### Toggle()

```csharp
public void Toggle()
```

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._

## Events

### Click

```csharp
public event RoutedEventHandler Click
```

_No description available._
