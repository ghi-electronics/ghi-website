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

_No description available._

### Count

```csharp
public int Count { get; }
```

_No description available._

### IsSynchronized

```csharp
public bool IsSynchronized { get; }
```

_No description available._

### SyncRoot

```csharp
public object SyncRoot { get; }
```

_No description available._

## Methods

### Add(ListBoxItem item)

```csharp
public int Add(ListBoxItem item)
```

_No description available._

**Returns** `int`

### Add(UIElement element)

```csharp
public int Add(UIElement element)
```

_No description available._

**Returns** `int`

### Clear()

```csharp
public void Clear()
```

_No description available._

### Contains(ListBoxItem item)

```csharp
public bool Contains(ListBoxItem item)
```

_No description available._

**Returns** `bool`

### IndexOf(ListBoxItem item)

```csharp
public int IndexOf(ListBoxItem item)
```

_No description available._

**Returns** `int`

### Insert(int index, ListBoxItem item)

```csharp
public void Insert(int index, ListBoxItem item)
```

_No description available._

### Remove(ListBoxItem item)

```csharp
public void Remove(ListBoxItem item)
```

_No description available._

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

_No description available._
