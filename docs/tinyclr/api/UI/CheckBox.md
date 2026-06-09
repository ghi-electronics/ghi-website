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

_No description available._

### Alpha

```csharp
public ushort Alpha { get; set; }
```

_No description available._

### RadiusBorder

```csharp
public ushort RadiusBorder { get; set; }
```

_No description available._

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
