---
title: "TextRunCollection Class"
sidebar_label: "TextRunCollection"
---

# TextRunCollection Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

An ordered collection of `TextRun` items belonging to a `TextFlow`.

```csharp
public class TextRunCollection : ICollection
```

## Properties

### Count

```csharp
public int Count { get; }
```

The number of runs in the collection.

### index]

```csharp
public TextRun this[int index] { get; set; }
```

Gets or sets the run at the given index.

### SyncRoot

```csharp
public object SyncRoot { get; }
```

Always null; the collection does not expose a synchronization root.

## Methods

### Add(string text, System.Drawing.Font font, Color foreColor)

```csharp
public int Add(string text, System.Drawing.Font font, Color foreColor)
```

Creates a run from the given text, font, and color and adds it, returning its index.

**Returns** `int`

### Add(TextRun textRun)

```csharp
public int Add(TextRun textRun)
```

Adds an existing run to the collection and returns its index.

**Returns** `int`

### Clear()

```csharp
public void Clear()
```

Removes all runs from the collection.

### Contains(TextRun run)

```csharp
public bool Contains(TextRun run)
```

Returns whether the given run is in the collection.

**Returns** `bool`

### IndexOf(TextRun run)

```csharp
public int IndexOf(TextRun run)
```

Returns the index of the given run, or -1 if it is not present.

**Returns** `int`

### Insert(int index, TextRun run)

```csharp
public void Insert(int index, TextRun run)
```

Inserts a run at the given index.

### Remove(TextRun run)

```csharp
public void Remove(TextRun run)
```

Removes the given run from the collection.

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

Removes the run at the given index.

### CopyTo(Array array, int index)

```csharp
public void CopyTo(Array array, int index)
```

Copies the runs to the given array starting at the specified index.
