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

_No description available._

### index]

```csharp
public GridLength this[int index] { get; set; }
```

_No description available._

## Methods

### Add(GridLength item)

```csharp
public void Add(GridLength item)
```

_No description available._

### Clear()

```csharp
public void Clear()
```

_No description available._

### Insert(int index, GridLength item)

```csharp
public void Insert(int index, GridLength item)
```

_No description available._

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

_No description available._
