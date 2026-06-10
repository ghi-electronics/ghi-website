---
title: "GridLengthCollection Class"
sidebar_label: "GridLengthCollection"
---

# GridLengthCollection Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Notifying GridLength collection. Every mutation invalidates the owning Grid's measure pass so layout stays in sync without callers having to remember to call InvalidateMeasure() manually.

```csharp
public sealed class GridLengthCollection
```

## Properties

### Count

```csharp
public int Count { get; }
```

Number of definitions in the collection.

### index]

```csharp
public GridLength this[int index] { get; set; }
```

Gets or sets the definition at the given index.

## Methods

### Add(GridLength item)

```csharp
public void Add(GridLength item)
```

Adds a definition to the collection.

### Clear()

```csharp
public void Clear()
```

Removes all definitions from the collection.

### Insert(int index, GridLength item)

```csharp
public void Insert(int index, GridLength item)
```

Inserts a definition at the given index.

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

Removes the definition at the given index.
