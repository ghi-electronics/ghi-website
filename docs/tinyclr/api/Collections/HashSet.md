---
title: "HashSet<T> Class"
sidebar_label: "HashSet<T>"
---

# HashSet&lt;T> Class

**NuGet:** `GHIElectronics.TinyCLR.Collections`<br/>**Assembly:** `GHIElectronics.TinyCLR.Collections`<br/>**Namespace:** `System.Collections.Generic`

Hash-table-based generic set. Mirrors the .NET BCL surface for the subset we ship. Same chained-collision layout and prime-table sizing as `Dictionary{TKey, TValue}`; the entry holds the element directly instead of a key/value pair. null IS a valid element when T is a reference type — the comparer (`EqualityComparer{T}.Default`) treats null consistently (GetHashCode(null) = 0, Equals(null, null) = true).

```csharp
public class HashSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, ICollection, IEnumerable
```

## Constructors

### HashSet()

```csharp
public HashSet() : this(0, null)
```

_No description available._

### HashSet(IEqualityComparer&lt;T> comparer)

```csharp
public HashSet(IEqualityComparer<T> comparer) : this(0, comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `comparer` | `IEqualityComparer<T>` |  |

### HashSet(int capacity)

```csharp
public HashSet(int capacity) : this(capacity, null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `capacity` | `int` |  |

### HashSet(int capacity, IEqualityComparer&lt;T> comparer)

```csharp
public HashSet(int capacity, IEqualityComparer<T> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `capacity` | `int` |  |
| `comparer` | `IEqualityComparer<T>` |  |

### HashSet(IEnumerable&lt;T> collection)

```csharp
public HashSet(IEnumerable<T> collection) : this(collection, null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `collection` | `IEnumerable<T>` |  |

### HashSet(IEnumerable&lt;T> collection, IEqualityComparer&lt;T> comparer)

```csharp
public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer) : this(0, comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `collection` | `IEnumerable<T>` |  |
| `comparer` | `IEqualityComparer<T>` |  |

## Properties

### Comparer

```csharp
public IEqualityComparer<T> Comparer { get; }
```

_No description available._

### Count

```csharp
public int Count { get; }
```

Gets the number of elements contained in the array. _(inherited)_

## Methods

### Add(T item)

```csharp
public bool Add(T item)
```

Appends a UIElement to the end of the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `item` | `T` |  |

**Returns** `bool` — The UIElementCollection index at which the UIElement has been added.

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_

### Contains(T item)

```csharp
public bool Contains(T item)
```

Determines whether a element is in the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `item` | `T` |  |

**Returns** `bool`

### Remove(T item)

```csharp
public bool Remove(T item)
```

Removes the specified element from the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `item` | `T` |  |

**Returns** `bool`

### RemoveWhere(Predicate&lt;T> match)

```csharp
public int RemoveWhere(Predicate<T> match)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `match` | `Predicate<T>` |  |

**Returns** `int`

### TryGetValue(T equalValue, out T actualValue)

```csharp
public bool TryGetValue(T equalValue, out T actualValue)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `equalValue` | `T` |  |
| `actualValue` | `out T` |  |

**Returns** `bool`

### CopyTo(T[] array)

```csharp
public void CopyTo(T[] array)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `array` | `T[]` |  |

### CopyTo(T[] array, int arrayIndex)

```csharp
public void CopyTo(T[] array, int arrayIndex)
```

Strongly typed version of CopyTo Copies the collection into the Array. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `array` | `T[]` |  |
| `arrayIndex` | `int` |  |

### CopyTo(T[] array, int arrayIndex, int count)

```csharp
public void CopyTo(T[] array, int arrayIndex, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `array` | `T[]` |  |
| `arrayIndex` | `int` |  |
| `count` | `int` |  |

### UnionWith(IEnumerable&lt;T> other)

```csharp
public void UnionWith(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

### IntersectWith(IEnumerable&lt;T> other)

```csharp
public void IntersectWith(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

### ExceptWith(IEnumerable&lt;T> other)

```csharp
public void ExceptWith(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

### SymmetricExceptWith(IEnumerable&lt;T> other)

```csharp
public void SymmetricExceptWith(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

### IsSubsetOf(IEnumerable&lt;T> other)

```csharp
public bool IsSubsetOf(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

**Returns** `bool`

### IsProperSubsetOf(IEnumerable&lt;T> other)

```csharp
public bool IsProperSubsetOf(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

**Returns** `bool`

### IsSupersetOf(IEnumerable&lt;T> other)

```csharp
public bool IsSupersetOf(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

**Returns** `bool`

### IsProperSupersetOf(IEnumerable&lt;T> other)

```csharp
public bool IsProperSupersetOf(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

**Returns** `bool`

### Overlaps(IEnumerable&lt;T> other)

```csharp
public bool Overlaps(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

**Returns** `bool`

### SetEquals(IEnumerable&lt;T> other)

```csharp
public bool SetEquals(IEnumerable<T> other)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `other` | `IEnumerable<T>` |  |

**Returns** `bool`

### GetEnumerator()

```csharp
public Enumerator GetEnumerator()
```

_No description available._

**Returns** `Enumerator`
