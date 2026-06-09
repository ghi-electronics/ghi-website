---
title: "ListBoxItemCollection Class"
sidebar_label: "ListBoxItemCollection"
---

# ListBoxItemCollection Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class ListBoxItemCollection : ICollection
```

## Constructors

### ListBoxItemCollection(ListBox listBox, UIElementCollection items)

```csharp
public ListBoxItemCollection(ListBox listBox, UIElementCollection items)
```

_No description available._

## Properties

### index]

```csharp
public ListBoxItem this[int index] { get; set; }
```

Indexer for the UIElementCollection. Gets or sets the UIElement stored at the zero-based index of the UIElementCollection. _(inherited)_

### Count

```csharp
public int Count { get; }
```

Gets the number of elements contained in the array. _(inherited)_

### IsSynchronized

```csharp
public bool IsSynchronized { get; }
```

Gets a value indicating whether access to the collection is synchronized (thread-safe). _(inherited)_

### SyncRoot

```csharp
public object SyncRoot { get; }
```

Gets an object that can be used to synchronize access to the collection. _(inherited)_

## Methods

### Add(ListBoxItem item)

```csharp
public int Add(ListBoxItem item)
```

Appends a UIElement to the end of the UIElementCollection. _(inherited)_

**Returns** `int` — The UIElementCollection index at which the UIElement has been added.

### Add(UIElement element)

```csharp
public int Add(UIElement element)
```

Appends a UIElement to the end of the UIElementCollection. _(inherited)_

**Returns** `int` — The UIElementCollection index at which the UIElement has been added.

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_

### Contains(ListBoxItem item)

```csharp
public bool Contains(ListBoxItem item)
```

Determines whether a element is in the UIElementCollection. _(inherited)_

**Returns** `bool`

### IndexOf(ListBoxItem item)

```csharp
public int IndexOf(ListBoxItem item)
```

Returns the zero-based index of the UIElement. If the UIElement is not in the UIElementCollection -1 is returned. If null is passed to the method, the index of the first entry with null is returned. If there is no null entry -1 is returned. _(inherited)_

**Returns** `int`

### Insert(int index, ListBoxItem item)

```csharp
public void Insert(int index, ListBoxItem item)
```

Inserts an element into the UIElementCollection at the specified index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index at which value should be inserted. |
| `item` | `ListBoxItem` |  |

### Remove(ListBoxItem item)

```csharp
public void Remove(ListBoxItem item)
```

Removes the specified element from the UIElementCollection. _(inherited)_

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

Removes the UIElement at the specified index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index of the element to remove. |
