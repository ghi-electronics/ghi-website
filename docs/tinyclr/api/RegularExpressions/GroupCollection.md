---
title: "GroupCollection Class"
sidebar_label: "GroupCollection"
---

# GroupCollection Class

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

_No description available._

```csharp
public class GroupCollection : ICollection, IEnumerable
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

### groupnum]

```csharp
public Group this[int groupnum] { get; }
```

_No description available._

### groupname]

```csharp
public Group this[string groupname] { get; }
```

_No description available._

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
