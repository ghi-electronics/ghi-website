---
title: "Enumerator Struct"
sidebar_label: "Enumerator"
---

# Enumerator Struct

**Namespace:** `GHIElectronics.TinyCLR.UI` · **Assembly:** `GHIElectronics.TinyCLR.UI`

This is a simple UIElementCollection enumerator that is based on the ArrayListEnumeratorSimple that is used for ArrayLists. The following comment is from the CLR people: For a straightforward enumeration of the entire ArrayList, this is faster, because it's smaller. Benchmarks showed this.

```csharp
public struct Enumerator : IEnumerator, ICloneable
```

## Properties

### Current

```csharp
public UIElement Current { get; }
```

Gets the current UIElement.

## Methods

### Clone()

```csharp
public object Clone()
```

Creates a new object that is a copy of the current instance.

**Returns** `object`

### MoveNext()

```csharp
public bool MoveNext()
```

Advances the enumerator to the next element of the collection.

**Returns** `bool`

### Reset()

```csharp
public void Reset()
```

Sets the enumerator to its initial position, which is before the first element in the collection.
