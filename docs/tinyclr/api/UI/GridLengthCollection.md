---
title: "GridLengthCollection Class"
sidebar_label: "GridLengthCollection"
---

# GridLengthCollection Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Notifying GridLength collection. Every mutation invalidates the owning Grid's measure pass so layout stays in sync without callers having to remember to call InvalidateMeasure() manually.

```csharp
public sealed class GridLengthCollection
```

## Properties

### Count

```csharp
public int Count { get; }
```

Gets the number of elements contained in the array. _(inherited)_

### index]

```csharp
public GridLength this[int index] { get; set; }
```

Indexer for the UIElementCollection. Gets or sets the UIElement stored at the zero-based index of the UIElementCollection. _(inherited)_

## Methods

### Add(GridLength item)

```csharp
public void Add(GridLength item)
```

Appends a UIElement to the end of the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `item` | `GridLength` |  |

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_

### Insert(int index, GridLength item)

```csharp
public void Insert(int index, GridLength item)
```

Inserts an element into the UIElementCollection at the specified index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index at which value should be inserted. |
| `item` | `GridLength` |  |

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

Removes the UIElement at the specified index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index of the element to remove. |
