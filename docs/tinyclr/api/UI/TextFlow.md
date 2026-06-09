---
title: "TextFlow Class"
sidebar_label: "TextFlow"
---

# TextFlow Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class TextFlow : UIElement
```

## Constructors

### TextFlow()

```csharp
public TextFlow()
```

_No description available._

## Properties

### ScrollingStyle

```csharp
public ScrollingStyle ScrollingStyle { get; set; }
```

The scrolling style. _(inherited)_

### TextAlignment

```csharp
public TextAlignment TextAlignment { get; set; }
```

_No description available._

### TopLine

```csharp
public int TopLine { get; set; }
```

_No description available._

### LineCount

```csharp
public int LineCount { get; }
```

_No description available._

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

### OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)

```csharp
protected override void OnButtonDown(GHIElectronics.TinyCLR.UI.Input.ButtonEventArgs e)
```

An event reporting a button was pressed. _(inherited)_

### OnRender(Media.DrawingContext dc)

```csharp
public override void OnRender(Media.DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

## Fields

### TextRuns

```csharp
public TextRunCollection TextRuns
```

_No description available._
