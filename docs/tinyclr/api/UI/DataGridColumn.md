---
title: "DataGridColumn Class"
sidebar_label: "DataGridColumn"
---

# DataGridColumn Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

Column descriptor for `DataGrid`.

```csharp
public class DataGridColumn
```

## Constructors

### DataGridColumn(string label, int width)

```csharp
public DataGridColumn(string label, int width)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `label` | `string` |  |
| `width` | `int` |  |

## Properties

### Label

```csharp
public string Label { get; set; }
```

Display label for the column header.

### Width

```csharp
public int Width { get; set; }
```

Column width in pixels.

### Order

```csharp
public DataGrid.Order Order { get; set; }
```

Default sort order applied when the column header is tapped.

## Methods

### ToggleOrder()

```csharp
public void ToggleOrder()
```

Toggles between ASC and DESC.
