---
title: "IGrouping<TKey, TElement> Interface"
sidebar_label: "IGrouping<TKey, TElement>"
---

# IGrouping&lt;TKey, TElement> Interface

**Namespace:** `System.Linq` · **Assembly:** `GHIElectronics.TinyCLR.Linq`

Represents a collection of objects that have a common key. Returned by `GroupBy`.

```csharp
public interface IGrouping<TKey, TElement> : IEnumerable<TElement>
```

## Properties

### Key

```csharp
TKey Key { get; }
```

_No description available._
