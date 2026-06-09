---
title: "DataGridItemComparer Class"
sidebar_label: "DataGridItemComparer"
---

# DataGridItemComparer Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The DataGridItemComparer class allows comparison between DataGridItems.

```csharp
public class DataGridItemComparer : IComparer
```

## Properties

### ColumnIndex

```csharp
public int ColumnIndex { get; set; }
```

Column index to compare.

## Methods

### Compare(object x, object y)

```csharp
public int Compare(object x, object y)
```

Compare two DataGridRow objects.

| Parameter | Type | Description |
|---|---|---|
| `x` | `object` |  |
| `y` | `object` |  |

**Returns** `int`
