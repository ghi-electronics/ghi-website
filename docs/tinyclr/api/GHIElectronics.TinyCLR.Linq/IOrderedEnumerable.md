---
title: "IOrderedEnumerable<TElement> Interface"
sidebar_label: "IOrderedEnumerable<TElement>"
---

# IOrderedEnumerable&lt;TElement> Interface

**Namespace:** `System.Linq` · **Assembly:** `GHIElectronics.TinyCLR.Linq`

Represents a sorted sequence. Used as the chain link between `OrderBy`/`OrderByDescending` and `ThenBy`/`ThenByDescending`.

```csharp
public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>
```

## Methods

### CreateOrderedEnumerable&lt;TKey>(Func&lt;TElement, TKey> keySelector, IComparer&lt;TKey> comparer, bool descending)

```csharp
IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>( Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `keySelector` | `Func<TElement, TKey>` |  |
| `comparer` | `IComparer<TKey>` |  |
| `descending` | `bool` |  |

**Returns** `IOrderedEnumerable<TElement>`
