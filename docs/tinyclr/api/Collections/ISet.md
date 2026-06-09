---
title: "ISet<T> Interface"
sidebar_label: "ISet<T>"
---

# ISet&lt;T> Interface

**NuGet:** `GHIElectronics.TinyCLR.Collections`<br/>**Assembly:** `GHIElectronics.TinyCLR.Collections`<br/>**Namespace:** `System.Collections.Generic`

Generic set abstraction. Mirrors the .NET BCL `System.Collections.Generic.ISet<T>` shape so HashSet&lt;T> and future set implementations interop cleanly with portable BCL-using code.

```csharp
public interface ISet<T> : ICollection<T>
```

## Methods

### Add(T item)

```csharp
new bool Add(T item)
```

_No description available._

**Returns** `bool`

### UnionWith(IEnumerable&lt;T> other)

```csharp
void UnionWith(IEnumerable<T> other)
```

_No description available._

### IntersectWith(IEnumerable&lt;T> other)

```csharp
void IntersectWith(IEnumerable<T> other)
```

_No description available._

### ExceptWith(IEnumerable&lt;T> other)

```csharp
void ExceptWith(IEnumerable<T> other)
```

_No description available._

### SymmetricExceptWith(IEnumerable&lt;T> other)

```csharp
void SymmetricExceptWith(IEnumerable<T> other)
```

_No description available._

### IsSubsetOf(IEnumerable&lt;T> other)

```csharp
bool IsSubsetOf(IEnumerable<T> other)
```

_No description available._

**Returns** `bool`

### IsSupersetOf(IEnumerable&lt;T> other)

```csharp
bool IsSupersetOf(IEnumerable<T> other)
```

_No description available._

**Returns** `bool`

### IsProperSupersetOf(IEnumerable&lt;T> other)

```csharp
bool IsProperSupersetOf(IEnumerable<T> other)
```

_No description available._

**Returns** `bool`

### IsProperSubsetOf(IEnumerable&lt;T> other)

```csharp
bool IsProperSubsetOf(IEnumerable<T> other)
```

_No description available._

**Returns** `bool`

### Overlaps(IEnumerable&lt;T> other)

```csharp
bool Overlaps(IEnumerable<T> other)
```

_No description available._

**Returns** `bool`

### SetEquals(IEnumerable&lt;T> other)

```csharp
bool SetEquals(IEnumerable<T> other)
```

_No description available._

**Returns** `bool`
