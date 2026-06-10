---
title: "Dropdown Class"
sidebar_label: "Dropdown"
---

# Dropdown Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

A collapsible list that shows the selected option and expands on tap.

```csharp
public class Dropdown : ListBox, IDisposable
```

## Constructors

### Dropdown()

```csharp
public Dropdown() : base()
```

Creates a new Dropdown.

## Properties

### Alpha

```csharp
public ushort Alpha { get; set; }
```

Opacity (0-255) used when drawing the dropdown images.

### RadiusBorder

```csharp
public int RadiusBorder { get; set; }
```

Corner radius used by the nine-slice dropdown images.

### MaxOpenHeight

```csharp
public int MaxOpenHeight { get; set; }
```

Optional cap on the expanded list height. When set to a positive value the open dropdown is clamped to this height and overflow scrolls through the inherited ScrollViewer. Default 0 = no clamp (legacy behavior).

### Options

```csharp
public ArrayList Options { get; set; }
```

The list of selectable options shown when the dropdown is open.

## Methods

### OnButtonDown(ButtonEventArgs e)

```csharp
protected override void OnButtonDown(ButtonEventArgs e)
```

Hardware button support: `HardwareButton.Select` toggles the dropdown open/closed (parity with touch). `HardwareButton.Back` closes an open dropdown. Up/Down navigation comes free from `ListBox`.

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Draws the dropdown's text field and chevron button.

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by the dropdown.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the dropdown's bitmap resources and event subscriptions.
