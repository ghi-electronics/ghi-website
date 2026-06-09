---
title: "UIElementCollection Class"
sidebar_label: "UIElementCollection"
---

# UIElementCollection Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

A UIElementCollection is a ordered collection of UIElements.

```csharp
public class UIElementCollection : ICollection
```

## Constructors

### UIElementCollection(UIElement owner)

```csharp
public UIElementCollection(UIElement owner)
```

_No description available._

## Properties

### Count

```csharp
public virtual int Count { get; }
```

Gets the number of elements contained in the array. _(inherited)_

### IsSynchronized

```csharp
public virtual bool IsSynchronized { get; }
```

Gets a value indicating whether access to the collection is synchronized (thread-safe). _(inherited)_

### SyncRoot

```csharp
public virtual object SyncRoot { get; }
```

Gets an object that can be used to synchronize access to the collection. _(inherited)_

### Capacity

```csharp
public virtual int Capacity { get; set; }
```

Gets or sets the number of elements that the UIElementCollection can contain.

### index]

```csharp
public UIElement this[int index] { get; set; }
```

Indexer for the UIElementCollection. Gets or sets the UIElement stored at the zero-based index of the UIElementCollection.

## Methods

### CopyTo(Array array, int index)

```csharp
public void CopyTo(Array array, int index)
```

Copies the UIElement collection to the specified array starting at the specified index.

### CopyTo(UIElement[] array, int index)

```csharp
public virtual void CopyTo(UIElement[] array, int index)
```

Strongly typed version of CopyTo Copies the collection into the Array.

### Add(UIElement element)

```csharp
public int Add(UIElement element)
```

Appends a UIElement to the end of the UIElementCollection.

**Returns** `int` — The UIElementCollection index at which the UIElement has been added.

### IndexOf(UIElement element)

```csharp
public int IndexOf(UIElement element)
```

Returns the zero-based index of the UIElement. If the UIElement is not in the UIElementCollection -1 is returned. If null is passed to the method, the index of the first entry with null is returned. If there is no null entry -1 is returned.

**Returns** `int`

### Remove(UIElement element)

```csharp
public void Remove(UIElement element)
```

Removes the specified element from the UIElementCollection.

| Parameter | Type | Description |
|---|---|---|
| `element` | `UIElement` | The UIElement to remove from the UIElementCollection. |

### Contains(UIElement element)

```csharp
public bool Contains(UIElement element)
```

Determines whether a element is in the UIElementCollection.

**Returns** `bool`

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection.

### Insert(int index, UIElement element)

```csharp
public void Insert(int index, UIElement element)
```

Inserts an element into the UIElementCollection at the specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index at which value should be inserted. |
| `element` | `UIElement` | The UIElement to insert. |

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

Removes the UIElement at the specified index.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index of the element to remove. |

### RemoveRange(int index, int count)

```csharp
public void RemoveRange(int index, int count)
```

Removes a range of UIElements from the UIElementCollection.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index of the range of elements to remove |
| `count` | `int` | The number of elements to remove. |
