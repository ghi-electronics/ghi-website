---
title: "Grid Class"
sidebar_label: "Grid"
---

# Grid Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Row/column layout with pixel, auto, and star sizing (WPF-style subset). Use `GetRow` / `SetRow` and `GetColumn` / `SetColumn` on children.

```csharp
public class Grid : Panel
```

## Constructors

### Grid()

```csharp
public Grid()
```

_No description available._

## Properties

### RowDefinitions

```csharp
public GridLengthCollection RowDefinitions { get; }
```

_No description available._

### ColumnDefinitions

```csharp
public GridLengthCollection ColumnDefinitions { get; }
```

_No description available._

## Methods

### GetRow(UIElement e)

```csharp
public static int GetRow(UIElement e)
```

_No description available._

**Returns** `int`

### SetRow(UIElement e, int row)

```csharp
public static void SetRow(UIElement e, int row)
```

_No description available._

### GetColumn(UIElement e)

```csharp
public static int GetColumn(UIElement e)
```

_No description available._

**Returns** `int`

### SetColumn(UIElement e, int column)

```csharp
public static void SetColumn(UIElement e, int column)
```

_No description available._

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
