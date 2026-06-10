---
title: "Enumerator Struct"
sidebar_label: "Enumerator"
---

# Enumerator Struct

**NuGet:** `GHIElectronics.TinyCLR.Collections`<br/>**Assembly:** `GHIElectronics.TinyCLR.Collections`<br/>**Namespace:** `System.Collections.Generic`

Enumerates the elements of a `HashSet{T}`.

```csharp
public struct Enumerator : IEnumerator<T>, IEnumerator
```

## Properties

### Current

```csharp
public T Current { get; }
```

Gets the element at the current position of the enumerator.

## Methods

### MoveNext()

```csharp
public bool MoveNext()
```

Advances the enumerator to the next element of the set.

**Returns** `bool`

### Dispose()

```csharp
public void Dispose()
```

Releases all resources used by the enumerator.
