---
title: "DataGridItem Class"
sidebar_label: "DataGridItem"
---

# DataGridItem Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

The DataGridItem class describes an item in a DataGrid component.

```csharp
public class DataGridItem : IComparable
```

## Constructors

### DataGridItem(object[] data)

```csharp
public DataGridItem(object[] data)
```

Creates a new DataGridItem.

| Parameter | Type | Description |
|---|---|---|
| `data` | `object[]` | Object containing data for each column. |

## Methods

### CompareTo(object obj)

```csharp
public int CompareTo(object obj)
```

IComparable contract. Compares this row against another DataGridItem using column 0. For non-default column comparisons use the typed CompareTo(DataGridItem, int) overload.

**Returns** `int`

### CompareTo(DataGridItem row, int columnIndex)

```csharp
public int CompareTo(DataGridItem row, int columnIndex)
```

Compares this item's column to another DataGridItem's column.

| Parameter | Type | Description |
|---|---|---|
| `row` | `DataGridItem` | DataGridItem object. |
| `columnIndex` | `int` | Column index. |

**Returns** `int` — Number indicating how it should be positioned.

## Fields

### data

```csharp
public object[] data
```

Contains the data for each column within this row.

### dataType

```csharp
public string[] dataType
```

Contains the data type for each column within this row.
