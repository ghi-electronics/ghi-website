---
title: "StackPanel Class"
sidebar_label: "StackPanel"
---

# StackPanel Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

A panel that stacks its children in a single row or column.

```csharp
public class StackPanel : Panel
```

## Constructors

### StackPanel()

```csharp
public StackPanel() : this(Orientation.Vertical)
```

Initializes a new stack panel that stacks children vertically.

### StackPanel(Orientation orientation)

```csharp
public StackPanel(Orientation orientation)
```

Initializes a new stack panel with the given stacking orientation.

## Properties

### Orientation

```csharp
public Orientation Orientation { get; set; }
```

The direction in which children are stacked.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the panel as the sum of child sizes along the stacking axis.

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

Positions children one after another along the stacking axis.
