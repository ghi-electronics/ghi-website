---
title: "DataGrid Class"
sidebar_label: "DataGrid"
---

# DataGrid Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The DataGrid component is a list-based component that provides a grid of rows and columns.

```csharp
public class DataGrid : ContentControl
```

## Constructors

### DataGrid(int width, int rowHeight, int rowCount, Font font)

```csharp
public DataGrid(int width, int rowHeight, int rowCount, Font font)
```

Creates a new DataGrid component.

| Parameter | Type | Description |
|---|---|---|
| `width` | `int` | width |
| `rowHeight` | `int` | rowHeight |
| `rowCount` | `int` | rowCount |
| `font` | `Font` | font |

## Properties

### RowCount

```csharp
public int RowCount { get; set; }
```

Number of rows displayed.

### Font

```csharp
public new Font Font { get; set; }
```

Font used by the text.

### RowHeight

```csharp
public int RowHeight { get; set; }
```

Row height.

### SelectedIndex

```csharp
public int SelectedIndex { get; set; }
```

The currently selected index.

### NumItems

```csharp
public int NumItems { get; }
```

Number of items in the DataGrid.

### TappableCells

```csharp
public bool TappableCells { get; set; }
```

Indicates whether items trigger cell tap events or not.

### Draggable

```csharp
public bool Draggable { get; set; }
```

Indicates whether or not the item list can be dragged up and down.

### ShowHeaders

```csharp
public bool ShowHeaders { get; set; }
```

Indicates whether the headers are shown.

### SortableHeaders

```csharp
public bool SortableHeaders { get; set; }
```

Indicates whether the headers are sortable.

### HeadersBackColor

```csharp
public Media.Color HeadersBackColor { get; set; }
```

Headers background color.

### HeadersFontColor

```csharp
public Media.Color HeadersFontColor { get; set; }
```

Headers font color.

### ItemsBackColor

```csharp
public Media.Color ItemsBackColor { get; set; }
```

Items background color.

### ItemsAltBackColor

```csharp
public Media.Color ItemsAltBackColor { get; set; }
```

Items alternate background color.

### ItemsFontColor

```csharp
public Media.Color ItemsFontColor { get; set; }
```

Items font color.

### SelectedItemBackColor

```csharp
public Media.Color SelectedItemBackColor { get; set; }
```

Selected item background color.

### SelectedItemFontColor

```csharp
public Media.Color SelectedItemFontColor { get; set; }
```

Selected item font color.

### GridColor

```csharp
public Media.Color GridColor { get; set; }
```

Grid color.

### ShowScrollbar

```csharp
public bool ShowScrollbar { get; set; }
```

Indicates whether the scrollbar is shown.

### ScrollbarWidth

```csharp
public int ScrollbarWidth { get; set; }
```

Scrollbar width.

### ScrollbarBackColor

```csharp
public Media.Color ScrollbarBackColor { get; set; }
```

Scrollbar background color.

### ScrollbarScrubberColor

```csharp
public Media.Color ScrollbarScrubberColor { get; set; }
```

Scrollbar scrubber color.

### MaxIgnoredTouchMoves

```csharp
public int MaxIgnoredTouchMoves { get; set; }
```

Touch senstitive.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### TriggerTapCellEvent(object sender, TapCellEventArgs args)

```csharp
public void TriggerTapCellEvent(object sender, TapCellEventArgs args)
```

Triggers a tap cell event.

| Parameter | Type | Description |
|---|---|---|
| `sender` | `object` | Object associated with this event. |
| `args` | `TapCellEventArgs` | Tap cell event arguments. |

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics.

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

### OnTouchDown(TouchEventArgs e)

```csharp
protected override void OnTouchDown(TouchEventArgs e)
```

Handles the touch down event.

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

Handles the touch up event.

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchMove(TouchEventArgs e)

```csharp
protected override void OnTouchMove(TouchEventArgs e)
```

Handles the touch move event.

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### AddColumn(DataGridColumn dataGridColumn)

```csharp
public void AddColumn(DataGridColumn dataGridColumn)
```

Adds a column.

| Parameter | Type | Description |
|---|---|---|
| `dataGridColumn` | `DataGridColumn` | dataGridColumn |

### AddColumnAt(int index, DataGridColumn dataGridColumn)

```csharp
public void AddColumnAt(int index, DataGridColumn dataGridColumn)
```

Adds a column at a specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |
| `dataGridColumn` | `DataGridColumn` | dataGridColumn |

### RemoveColumn(DataGridColumn dataGridColumn)

```csharp
public void RemoveColumn(DataGridColumn dataGridColumn)
```

Removes a column.

| Parameter | Type | Description |
|---|---|---|
| `dataGridColumn` | `DataGridColumn` | dataGridColumn |

### RemoveColumnAt(int index)

```csharp
public void RemoveColumnAt(int index)
```

Removes a column at a specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |

### AddItem(DataGridItem dataGridItem)

```csharp
public void AddItem(DataGridItem dataGridItem)
```

Adds an item.

| Parameter | Type | Description |
|---|---|---|
| `dataGridItem` | `DataGridItem` | dataGridItem |

### AddItemAt(int index, DataGridItem dataGridItem)

```csharp
public void AddItemAt(int index, DataGridItem dataGridItem)
```

Adds an item at a specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |
| `dataGridItem` | `DataGridItem` | dataGridItem |

### RemoveItem(DataGridItem dataGridItem)

```csharp
public void RemoveItem(DataGridItem dataGridItem)
```

Removes an item.

| Parameter | Type | Description |
|---|---|---|
| `dataGridItem` | `DataGridItem` | dataGridItem |

### RemoveItemAt(int index)

```csharp
public void RemoveItemAt(int index)
```

Removes an item a specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |

### ScrollUp(int amount)

```csharp
public void ScrollUp(int amount)
```

Scroll the rows up by a specified amount.

| Parameter | Type | Description |
|---|---|---|
| `amount` | `int` | amount |

### ScrollDown(int amount)

```csharp
public void ScrollDown(int amount)
```

Scroll the rows down by a specified amount.

| Parameter | Type | Description |
|---|---|---|
| `amount` | `int` | amount |

### ScrollTo(int index)

```csharp
public void ScrollTo(int index)
```

Scroll the rows to a specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |

### SetRowData(int index, object[] data)

```csharp
public void SetRowData(int index, object[] data)
```

Sets new row data.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |
| `data` | `object[]` | Data object array. |

### GetRowData(int index)

```csharp
public object[] GetRowData(int index)
```

Gets row data.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | index |

**Returns** `object[]` — Data object array.

### SetCellData(int columnIndex, int rowIndex, object data)

```csharp
public void SetCellData(int columnIndex, int rowIndex, object data)
```

Sets a cell's data.

| Parameter | Type | Description |
|---|---|---|
| `columnIndex` | `int` | columnIndex |
| `rowIndex` | `int` | rowIndex |
| `data` | `object` | data |

### GetCellData(int columnIndex, int rowIndex)

```csharp
public object GetCellData(int columnIndex, int rowIndex)
```

Get a cell's data.

| Parameter | Type | Description |
|---|---|---|
| `columnIndex` | `int` | columnIndex |
| `rowIndex` | `int` | rowIndex |

**Returns** `object`

### Sort(int columnIndex)

```csharp
public void Sort(int columnIndex)
```

Sorts the items on a specified column index.

| Parameter | Type | Description |
|---|---|---|
| `columnIndex` | `int` |  |

### Clear()

```csharp
public void Clear()
```

Clears all items including their data and resets the data grid.

## Events

### TapCellEvent

```csharp
public event OnTapCell TapCellEvent
```

Tap grid event.
