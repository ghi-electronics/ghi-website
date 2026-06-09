---
title: "Enumerable Class"
sidebar_label: "Enumerable"
---

# Enumerable Class

**Namespace:** `System.Linq` · **Assembly:** `GHIElectronics.TinyCLR.Linq`

LINQ to Objects on top of `IEnumerable{T}`. Subset of the .NET BCL surface picked for embedded use - covers the common filter / project / aggregate / order / group / convert operators. Lazy operators (Where, Select, etc.) use iterator state machines; terminal operators (ToArray, Sum, OrderBy, etc.) are eager.

```csharp
public static class Enumerable
```

## Methods

### Where&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `IEnumerable<TSource>`

### Where&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, int, bool> predicate)

```csharp
public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, int, bool>` |  |

**Returns** `IEnumerable<TSource>`

### OfType&lt;TResult>(this IEnumerable source)

```csharp
public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable` |  |

**Returns** `IEnumerable<TResult>`

### Cast&lt;TResult>(this IEnumerable source)

```csharp
public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable` |  |

**Returns** `IEnumerable<TResult>`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TResult> selector)

```csharp
public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, TResult>` |  |

**Returns** `IEnumerable<TResult> Select<TSource,`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, int, TResult> selector)

```csharp
public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, int, TResult>` |  |

**Returns** `IEnumerable<TResult> Select<TSource,`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, IEnumerable&lt;TResult>> selector)

```csharp
public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, IEnumerable<TResult>>` |  |

**Returns** `IEnumerable<TResult> SelectMany<TSource,`

### Skip&lt;TSource>(this IEnumerable&lt;TSource> source, int count)

```csharp
public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `count` | `int` |  |

**Returns** `IEnumerable<TSource>`

### Take&lt;TSource>(this IEnumerable&lt;TSource> source, int count)

```csharp
public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `count` | `int` |  |

**Returns** `IEnumerable<TSource>`

### SkipWhile&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `IEnumerable<TSource>`

### TakeWhile&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `IEnumerable<TSource>`

### Distinct&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `IEnumerable<TSource>`

### Distinct&lt;TSource>(this IEnumerable&lt;TSource> source, IEqualityComparer&lt;TSource> comparer)

```csharp
public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `comparer` | `IEqualityComparer<TSource>` |  |

**Returns** `IEnumerable<TSource>`

### Concat&lt;TSource>(this IEnumerable&lt;TSource> first, IEnumerable&lt;TSource> second)

```csharp
public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `first` | `this IEnumerable<TSource>` |  |
| `second` | `IEnumerable<TSource>` |  |

**Returns** `IEnumerable<TSource>`

### Reverse&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `IEnumerable<TSource>`

### SequenceEqual&lt;TSource>(this IEnumerable&lt;TSource> first, IEnumerable&lt;TSource> second)

```csharp
public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `first` | `this IEnumerable<TSource>` |  |
| `second` | `IEnumerable<TSource>` |  |

**Returns** `bool`

### SequenceEqual&lt;TSource>(this IEnumerable&lt;TSource> first, IEnumerable&lt;TSource> second, IEqualityComparer&lt;TSource> comparer)

```csharp
public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `first` | `this IEnumerable<TSource>` |  |
| `second` | `IEnumerable<TSource>` |  |
| `comparer` | `IEqualityComparer<TSource>` |  |

**Returns** `bool`

### Any&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static bool Any<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `bool`

### Any&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `bool`

### All&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `bool`

### Contains&lt;TSource>(this IEnumerable&lt;TSource> source, TSource value)

```csharp
public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `value` | `TSource` |  |

**Returns** `bool`

### Contains&lt;TSource>(this IEnumerable&lt;TSource> source, TSource value, IEqualityComparer&lt;TSource> comparer)

```csharp
public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `value` | `TSource` |  |
| `comparer` | `IEqualityComparer<TSource>` |  |

**Returns** `bool`

### First&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource First<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### First&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `TSource`

### FirstOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### FirstOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `TSource`

### Last&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Last<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### Last&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `TSource`

### LastOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### LastOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `TSource`

### Single&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Single<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### Single&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `TSource`

### SingleOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### SingleOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `TSource`

### ElementAt&lt;TSource>(this IEnumerable&lt;TSource> source, int index)

```csharp
public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `index` | `int` |  |

**Returns** `TSource`

### ElementAtOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, int index)

```csharp
public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `index` | `int` |  |

**Returns** `TSource`

### Count&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static int Count<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `int`

### Count&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `predicate` | `Func<TSource, bool>` |  |

**Returns** `int`

### LongCount&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static long LongCount<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `long`

### Sum(this IEnumerable&lt;int> source)

```csharp
public static int Sum(this IEnumerable<int> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<int>` |  |

**Returns** `int`

### Sum&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, int> selector)

```csharp
public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, int>` |  |

**Returns** `int`

### Sum(this IEnumerable&lt;long> source)

```csharp
public static long Sum(this IEnumerable<long> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<long>` |  |

**Returns** `long`

### Sum&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, long> selector)

```csharp
public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, long>` |  |

**Returns** `long`

### Sum(this IEnumerable&lt;double> source)

```csharp
public static double Sum(this IEnumerable<double> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<double>` |  |

**Returns** `double`

### Sum&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, double> selector)

```csharp
public static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, double>` |  |

**Returns** `double`

### Sum(this IEnumerable&lt;float> source)

```csharp
public static float Sum(this IEnumerable<float> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<float>` |  |

**Returns** `float`

### Min&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Min<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TResult> selector)

```csharp
public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, TResult>` |  |

**Returns** `TResult Min<TSource,`

### Max&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Max<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TResult> selector)

```csharp
public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `selector` | `Func<TSource, TResult>` |  |

**Returns** `TResult Max<TSource,`

### Average(this IEnumerable&lt;int> source)

```csharp
public static double Average(this IEnumerable<int> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<int>` |  |

**Returns** `double`

### Average(this IEnumerable&lt;long> source)

```csharp
public static double Average(this IEnumerable<long> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<long>` |  |

**Returns** `double`

### Average(this IEnumerable&lt;double> source)

```csharp
public static double Average(this IEnumerable<double> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<double>` |  |

**Returns** `double`

### TAccumulate>(this IEnumerable&lt;TSource> source, TAccumulate seed, Func&lt;TAccumulate, TSource, TAccumulate> func)

```csharp
public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `seed` | `TAccumulate` |  |
| `func` | `Func<TAccumulate, TSource, TAccumulate>` |  |

**Returns** `TAccumulate Aggregate<TSource,`

### Aggregate&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TSource, TSource> func)

```csharp
public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `func` | `Func<TSource, TSource, TSource>` |  |

**Returns** `TSource`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> OrderBy<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `comparer` | `IComparer<TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> OrderBy<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> OrderByDescending<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `comparer` | `IComparer<TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> OrderByDescending<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IOrderedEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> ThenBy<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IOrderedEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `comparer` | `IComparer<TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> ThenBy<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IOrderedEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> ThenByDescending<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IOrderedEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `comparer` | `IComparer<TKey>` |  |

**Returns** `IOrderedEnumerable<TSource> ThenByDescending<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |

**Returns** `IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `comparer` | `IEqualityComparer<TKey>` |  |

**Returns** `IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector)

```csharp
public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `elementSelector` | `Func<TSource, TElement>` |  |

**Returns** `IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `elementSelector` | `Func<TSource, TElement>` |  |
| `comparer` | `IEqualityComparer<TKey>` |  |

**Returns** `IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey,`

### ToArray&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `TSource[]`

### ToList&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |

**Returns** `List<TSource>`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |

**Returns** `Dictionary<TKey, TSource> ToDictionary<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `comparer` | `IEqualityComparer<TKey>` |  |

**Returns** `Dictionary<TKey, TSource> ToDictionary<TSource,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector)

```csharp
public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `elementSelector` | `Func<TSource, TElement>` |  |

**Returns** `Dictionary<TKey, TElement> ToDictionary<TSource, TKey,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `this IEnumerable<TSource>` |  |
| `keySelector` | `Func<TSource, TKey>` |  |
| `elementSelector` | `Func<TSource, TElement>` |  |
| `comparer` | `IEqualityComparer<TKey>` |  |

**Returns** `Dictionary<TKey, TElement> ToDictionary<TSource, TKey,`

### Range(int start, int count)

```csharp
public static IEnumerable<int> Range(int start, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `start` | `int` |  |
| `count` | `int` |  |

**Returns** `IEnumerable<int>`

### Repeat&lt;TResult>(TResult element, int count)

```csharp
public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `element` | `TResult` |  |
| `count` | `int` |  |

**Returns** `IEnumerable<TResult>`

### Empty&lt;TResult>()

```csharp
public static IEnumerable<TResult> Empty<TResult>()
```

_No description available._

**Returns** `IEnumerable<TResult>`
