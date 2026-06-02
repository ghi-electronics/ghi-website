---
title: "TextRunCollection Class"
sidebar_label: "TextRunCollection"
---

# TextRunCollection Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class TextRunCollection : ICollection
```

## Properties

### Count

```csharp
public int Count { get; }
```

Gets the number of elements contained in the array. _(inherited)_

### index]

```csharp
public TextRun this[int index] { get; set; }
```

Indexer for the UIElementCollection. Gets or sets the UIElement stored at the zero-based index of the UIElementCollection. _(inherited)_

### SyncRoot

```csharp
public object SyncRoot { get; }
```

Gets an object that can be used to synchronize access to the collection. _(inherited)_

## Methods

### Add(string text, System.Drawing.Font font, Color foreColor)

```csharp
public int Add(string text, System.Drawing.Font font, Color foreColor)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |
| `font` | `System.Drawing.Font` |  |
| `foreColor` | `Color` |  |

**Returns** `int`

### Add(TextRun textRun)

```csharp
public int Add(TextRun textRun)
```

Appends a UIElement to the end of the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `textRun` | `TextRun` |  |

**Returns** `int` — The UIElementCollection index at which the UIElement has been added.

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_

### Contains(TextRun run)

```csharp
public bool Contains(TextRun run)
```

Determines whether a element is in the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `run` | `TextRun` |  |

**Returns** `bool`

### IndexOf(TextRun run)

```csharp
public int IndexOf(TextRun run)
```

Returns the zero-based index of the UIElement. If the UIElement is not in the UIElementCollection -1 is returned. If null is passed to the method, the index of the first entry with null is returned. If there is no null entry -1 is returned. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `run` | `TextRun` |  |

**Returns** `int`

### Insert(int index, TextRun run)

```csharp
public void Insert(int index, TextRun run)
```

Inserts an element into the UIElementCollection at the specified index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index at which value should be inserted. |
| `run` | `TextRun` |  |

### Remove(TextRun run)

```csharp
public void Remove(TextRun run)
```

Removes the specified element from the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `run` | `TextRun` |  |

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

Removes the UIElement at the specified index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The zero-based index of the element to remove. |

### CopyTo(Array array, int index)

```csharp
public void CopyTo(Array array, int index)
```

Strongly typed version of CopyTo Copies the collection into the Array. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `array` | `Array` |  |
| `index` | `int` |  |
