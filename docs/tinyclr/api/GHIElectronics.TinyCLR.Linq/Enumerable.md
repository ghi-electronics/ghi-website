---
title: "Enumerable Class"
sidebar_label: "Enumerable"
---

# Enumerable Class

**NuGet:** `GHIElectronics.TinyCLR.Linq`<br/>**Assembly:** `GHIElectronics.TinyCLR.Linq`<br/>**Namespace:** `System.Linq`

LINQ to Objects on top of `IEnumerable{T}`. Subset of the .NET BCL surface picked for embedded use - covers the common filter / project / aggregate / order / group / convert operators. Lazy operators (Where, Select, etc.) use iterator state machines; terminal operators (ToArray, Sum, OrderBy, etc.) are eager.

```csharp
public static class Enumerable
```

## Methods

### Where&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Filters a sequence of values based on a predicate.

**Returns** `IEnumerable<TSource>`

### Where&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, int, bool> predicate)

```csharp
public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
```

Filters a sequence of values based on a predicate that receives each element's index.

**Returns** `IEnumerable<TSource>`

### OfType&lt;TResult>(this IEnumerable source)

```csharp
public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
```

Filters the elements of a sequence based on a specified type.

**Returns** `IEnumerable<TResult>`

### Cast&lt;TResult>(this IEnumerable source)

```csharp
public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
```

Casts the elements of a sequence to the specified type.

**Returns** `IEnumerable<TResult>`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TResult> selector)

```csharp
public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
```

Projects each element of a sequence into a new form.

**Returns** `IEnumerable<TResult> Select<TSource,`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, int, TResult> selector)

```csharp
public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
```

Projects each element of a sequence into a new form by incorporating the element's index.

**Returns** `IEnumerable<TResult> Select<TSource,`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, IEnumerable&lt;TResult>> selector)

```csharp
public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
```

Projects each element of a sequence to an `IEnumerable{T}` and flattens the results into one sequence.

**Returns** `IEnumerable<TResult> SelectMany<TSource,`

### Skip&lt;TSource>(this IEnumerable&lt;TSource> source, int count)

```csharp
public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
```

Bypasses a specified number of elements and returns the remaining elements.

**Returns** `IEnumerable<TSource>`

### Take&lt;TSource>(this IEnumerable&lt;TSource> source, int count)

```csharp
public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
```

Returns a specified number of contiguous elements from the start of a sequence.

**Returns** `IEnumerable<TSource>`

### SkipWhile&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Bypasses elements while a predicate is true and returns the remaining elements.

**Returns** `IEnumerable<TSource>`

### TakeWhile&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns elements from the start of a sequence while a predicate is true.

**Returns** `IEnumerable<TSource>`

### Distinct&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
```

Returns distinct elements from a sequence using the default equality comparer.

**Returns** `IEnumerable<TSource>`

### Distinct&lt;TSource>(this IEnumerable&lt;TSource> source, IEqualityComparer&lt;TSource> comparer)

```csharp
public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
```

Returns distinct elements from a sequence using a specified equality comparer.

**Returns** `IEnumerable<TSource>`

### Concat&lt;TSource>(this IEnumerable&lt;TSource> first, IEnumerable&lt;TSource> second)

```csharp
public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
```

Concatenates two sequences.

**Returns** `IEnumerable<TSource>`

### Reverse&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
```

Inverts the order of the elements in a sequence.

**Returns** `IEnumerable<TSource>`

### SequenceEqual&lt;TSource>(this IEnumerable&lt;TSource> first, IEnumerable&lt;TSource> second)

```csharp
public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
```

Determines whether two sequences are equal using the default equality comparer.

**Returns** `bool`

### SequenceEqual&lt;TSource>(this IEnumerable&lt;TSource> first, IEnumerable&lt;TSource> second, IEqualityComparer&lt;TSource> comparer)

```csharp
public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
```

Determines whether two sequences are equal using a specified equality comparer.

**Returns** `bool`

### Any&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static bool Any<TSource>(this IEnumerable<TSource> source)
```

Determines whether a sequence contains any elements.

**Returns** `bool`

### Any&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Determines whether any element of a sequence satisfies a predicate.

**Returns** `bool`

### All&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Determines whether all elements of a sequence satisfy a predicate.

**Returns** `bool`

### Contains&lt;TSource>(this IEnumerable&lt;TSource> source, TSource value)

```csharp
public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
```

Determines whether a sequence contains a specified element using the default equality comparer.

**Returns** `bool`

### Contains&lt;TSource>(this IEnumerable&lt;TSource> source, TSource value, IEqualityComparer&lt;TSource> comparer)

```csharp
public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
```

Determines whether a sequence contains a specified element using a specified equality comparer.

**Returns** `bool`

### First&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource First<TSource>(this IEnumerable<TSource> source)
```

Returns the first element of a sequence, throwing if the sequence is empty.

**Returns** `TSource`

### First&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the first element that satisfies a predicate, throwing if none match.

**Returns** `TSource`

### FirstOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
```

Returns the first element of a sequence, or a default value if the sequence is empty.

**Returns** `TSource`

### FirstOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the first element that satisfies a predicate, or a default value if none match.

**Returns** `TSource`

### Last&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Last<TSource>(this IEnumerable<TSource> source)
```

Returns the last element of a sequence, throwing if the sequence is empty.

**Returns** `TSource`

### Last&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the last element that satisfies a predicate, throwing if none match.

**Returns** `TSource`

### LastOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
```

Returns the last element of a sequence, or a default value if the sequence is empty.

**Returns** `TSource`

### LastOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the last element that satisfies a predicate, or a default value if none match.

**Returns** `TSource`

### Single&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Single<TSource>(this IEnumerable<TSource> source)
```

Returns the only element of a sequence, throwing if it is empty or has more than one element.

**Returns** `TSource`

### Single&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the only element that satisfies a predicate, throwing if none or more than one match.

**Returns** `TSource`

### SingleOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
```

Returns the only element of a sequence, a default value if empty, or throws if more than one element.

**Returns** `TSource`

### SingleOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the only element that satisfies a predicate, a default value if none match, or throws if more than one matches.

**Returns** `TSource`

### ElementAt&lt;TSource>(this IEnumerable&lt;TSource> source, int index)

```csharp
public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
```

Returns the element at a specified index in a sequence.

**Returns** `TSource`

### ElementAtOrDefault&lt;TSource>(this IEnumerable&lt;TSource> source, int index)

```csharp
public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
```

Returns the element at a specified index, or a default value if the index is out of range.

**Returns** `TSource`

### Count&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static int Count<TSource>(this IEnumerable<TSource> source)
```

Returns the number of elements in a sequence.

**Returns** `int`

### Count&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, bool> predicate)

```csharp
public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

Returns the number of elements in a sequence that satisfy a predicate.

**Returns** `int`

### LongCount&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static long LongCount<TSource>(this IEnumerable<TSource> source)
```

Returns the number of elements in a sequence as a 64-bit integer.

**Returns** `long`

### Sum(this IEnumerable&lt;int> source)

```csharp
public static int Sum(this IEnumerable<int> source)
```

Computes the sum of a sequence of 32-bit integers.

**Returns** `int`

### Sum&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, int> selector)

```csharp
public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
```

Computes the sum of the 32-bit integer values selected from each element.

**Returns** `int`

### Sum(this IEnumerable&lt;long> source)

```csharp
public static long Sum(this IEnumerable<long> source)
```

Computes the sum of a sequence of 64-bit integers.

**Returns** `long`

### Sum&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, long> selector)

```csharp
public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
```

Computes the sum of the 64-bit integer values selected from each element.

**Returns** `long`

### Sum(this IEnumerable&lt;double> source)

```csharp
public static double Sum(this IEnumerable<double> source)
```

Computes the sum of a sequence of double-precision values.

**Returns** `double`

### Sum&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, double> selector)

```csharp
public static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
```

Computes the sum of the double-precision values selected from each element.

**Returns** `double`

### Sum(this IEnumerable&lt;float> source)

```csharp
public static float Sum(this IEnumerable<float> source)
```

Computes the sum of a sequence of single-precision values.

**Returns** `float`

### Min&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Min<TSource>(this IEnumerable<TSource> source)
```

Returns the minimum value in a sequence using the default comparer.

**Returns** `TSource`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TResult> selector)

```csharp
public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
```

Returns the minimum value selected from each element of a sequence.

**Returns** `TResult Min<TSource,`

### Max&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource Max<TSource>(this IEnumerable<TSource> source)
```

Returns the maximum value in a sequence using the default comparer.

**Returns** `TSource`

### TResult>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TResult> selector)

```csharp
public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
```

Returns the maximum value selected from each element of a sequence.

**Returns** `TResult Max<TSource,`

### Average(this IEnumerable&lt;int> source)

```csharp
public static double Average(this IEnumerable<int> source)
```

Computes the average of a sequence of 32-bit integers.

**Returns** `double`

### Average(this IEnumerable&lt;long> source)

```csharp
public static double Average(this IEnumerable<long> source)
```

Computes the average of a sequence of 64-bit integers.

**Returns** `double`

### Average(this IEnumerable&lt;double> source)

```csharp
public static double Average(this IEnumerable<double> source)
```

Computes the average of a sequence of double-precision values.

**Returns** `double`

### TAccumulate>(this IEnumerable&lt;TSource> source, TAccumulate seed, Func&lt;TAccumulate, TSource, TAccumulate> func)

```csharp
public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
```

Applies an accumulator function over a sequence starting from a seed value.

**Returns** `TAccumulate Aggregate<TSource,`

### Aggregate&lt;TSource>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TSource, TSource> func)

```csharp
public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
```

Applies an accumulator function over a sequence using the first element as the seed.

**Returns** `TSource`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

Sorts the elements of a sequence in ascending order by a key.

**Returns** `IOrderedEnumerable<TSource> OrderBy<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

Sorts the elements of a sequence in ascending order by a key using a specified comparer.

**Returns** `IOrderedEnumerable<TSource> OrderBy<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

Sorts the elements of a sequence in descending order by a key.

**Returns** `IOrderedEnumerable<TSource> OrderByDescending<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

Sorts the elements of a sequence in descending order by a key using a specified comparer.

**Returns** `IOrderedEnumerable<TSource> OrderByDescending<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

Performs a subsequent ascending sort on an already ordered sequence by a key.

**Returns** `IOrderedEnumerable<TSource> ThenBy<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

Performs a subsequent ascending sort on an already ordered sequence by a key using a specified comparer.

**Returns** `IOrderedEnumerable<TSource> ThenBy<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

Performs a subsequent descending sort on an already ordered sequence by a key.

**Returns** `IOrderedEnumerable<TSource> ThenByDescending<TSource,`

### TKey>(this IOrderedEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IComparer&lt;TKey> comparer)

```csharp
public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
```

Performs a subsequent descending sort on an already ordered sequence by a key using a specified comparer.

**Returns** `IOrderedEnumerable<TSource> ThenByDescending<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

Groups the elements of a sequence by a key.

**Returns** `IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
```

Groups the elements of a sequence by a key using a specified equality comparer.

**Returns** `IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector)

```csharp
public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
```

Groups the elements of a sequence by a key and projects each element with an element selector.

**Returns** `IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
```

Groups the elements of a sequence by a key, projecting each element with an element selector and using a specified equality comparer.

**Returns** `IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey,`

### ToArray&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
```

Creates an array from a sequence.

**Returns** `TSource[]`

### ToList&lt;TSource>(this IEnumerable&lt;TSource> source)

```csharp
public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
```

Creates a `List{T}` from a sequence.

**Returns** `List<TSource>`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector)

```csharp
public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

Creates a `Dictionary{TKey,TValue}` from a sequence using a key selector.

**Returns** `Dictionary<TKey, TSource> ToDictionary<TSource,`

### TKey>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
```

Creates a `Dictionary{TKey,TValue}` from a sequence using a key selector and a specified equality comparer.

**Returns** `Dictionary<TKey, TSource> ToDictionary<TSource,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector)

```csharp
public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
```

Creates a `Dictionary{TKey,TValue}` from a sequence using key and element selectors.

**Returns** `Dictionary<TKey, TElement> ToDictionary<TSource, TKey,`

### TElement>(this IEnumerable&lt;TSource> source, Func&lt;TSource, TKey> keySelector, Func&lt;TSource, TElement> elementSelector, IEqualityComparer&lt;TKey> comparer)

```csharp
public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
```

Creates a `Dictionary{TKey,TValue}` from a sequence using key and element selectors and a specified equality comparer.

**Returns** `Dictionary<TKey, TElement> ToDictionary<TSource, TKey,`

### Range(int start, int count)

```csharp
public static IEnumerable<int> Range(int start, int count)
```

Generates a sequence of consecutive integers starting at a specified value.

**Returns** `IEnumerable<int>`

### Repeat&lt;TResult>(TResult element, int count)

```csharp
public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
```

Generates a sequence that contains one repeated value.

**Returns** `IEnumerable<TResult>`

### Empty&lt;TResult>()

```csharp
public static IEnumerable<TResult> Empty<TResult>()
```

Returns an empty sequence of the specified type.

**Returns** `IEnumerable<TResult>`
