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

Creates a new Grid.

## Properties

### RowDefinitions

```csharp
public GridLengthCollection RowDefinitions { get; }
```

The row size definitions.

### ColumnDefinitions

```csharp
public GridLengthCollection ColumnDefinitions { get; }
```

The column size definitions.

## Methods

### GetRow(UIElement e)

```csharp
public static int GetRow(UIElement e)
```

Gets the grid row assigned to an element.

**Returns** `int`

### SetRow(UIElement e, int row)

```csharp
public static void SetRow(UIElement e, int row)
```

Assigns an element to a grid row.

### GetColumn(UIElement e)

```csharp
public static int GetColumn(UIElement e)
```

Gets the grid column assigned to an element.

**Returns** `int`

### SetColumn(UIElement e, int column)

```csharp
public static void SetColumn(UIElement e, int column)
```

Assigns an element to a grid column.

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures children and computes row and column sizes.

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

Positions each child within its assigned cell.
