---
title: "CaptureCollection Class"
sidebar_label: "CaptureCollection"
---

# CaptureCollection Class

**Namespace:** `System.Text.RegularExpressions` · **Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`

_No description available._

```csharp
public class CaptureCollection : ICollection, IEnumerable
```

## Properties

### Count

```csharp
public int Count { get; }
```

Gets the number of elements contained in the array. _(inherited)_

### IsReadOnly

```csharp
public bool IsReadOnly { get; }
```

Gets a value that indicates whether the collection is read only. _(inherited)_

### IsSynchronized

```csharp
public bool IsSynchronized { get; }
```

Gets a value indicating whether access to the collection is synchronized (thread-safe). _(inherited)_

### i]

```csharp
public Capture this[int i] { get; }
```

Gets an individual member of the collection. _(inherited)_

### SyncRoot

```csharp
public object SyncRoot { get; }
```

Gets an object that can be used to synchronize access to the collection. _(inherited)_

## Methods

### CopyTo(Array array, int arrayIndex)

```csharp
public void CopyTo(Array array, int arrayIndex)
```

Strongly typed version of CopyTo Copies the collection into the Array. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `array` | `Array` |  |
| `arrayIndex` | `int` |  |

### GetEnumerator()

```csharp
public IEnumerator GetEnumerator()
```

_No description available._

**Returns** `IEnumerator`
