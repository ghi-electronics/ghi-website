---
title: "MatchCollection Class"
sidebar_label: "MatchCollection"
---

# MatchCollection Class

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

Represents the set of successful matches found by iteratively applying a regular expression pattern to the input string.

```csharp
public class MatchCollection : ICollection, IEnumerable
```

## Properties

### IsReadOnly

```csharp
public bool IsReadOnly { get; }
```

Gets a value that indicates whether the collection is read only.

### IsSynchronized

```csharp
public bool IsSynchronized { get; }
```

Gets a value indicating whether access to the collection is synchronized (thread-safe).

### i]

```csharp
public virtual Match this[int i] { get; }
```

Gets an individual member of the collection.

### SyncRoot

```csharp
public object SyncRoot { get; }
```

Gets an object that can be used to synchronize access to the collection.

## Methods

### GetEnumerator()

```csharp
public IEnumerator GetEnumerator()
```

Returns an enumerator that iterates through the collection.

**Returns** `IEnumerator`
