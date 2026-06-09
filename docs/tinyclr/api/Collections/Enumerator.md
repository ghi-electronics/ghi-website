---
title: "Enumerator Struct"
sidebar_label: "Enumerator"
---

# Enumerator Struct

**NuGet:** `GHIElectronics.TinyCLR.Collections`<br/>**Assembly:** `GHIElectronics.TinyCLR.Collections`<br/>**Namespace:** `System.Collections.Generic`

_No description available._

```csharp
public struct Enumerator : IEnumerator<T>, IEnumerator
```

## Properties

### Current

```csharp
public T Current { get; }
```

Gets the current UIElement. _(inherited)_

## Methods

### MoveNext()

```csharp
public bool MoveNext()
```

Advances the enumerator to the next element of the collection. _(inherited)_

**Returns** `bool`

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
