---
title: "TextRunCollection Class"
sidebar_label: "TextRunCollection"
---

# TextRunCollection Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class TextRunCollection : ICollection
```

## Properties

### Count

```csharp
public int Count { get; }
```

_No description available._

### index]

```csharp
public TextRun this[int index] { get; set; }
```

_No description available._

### SyncRoot

```csharp
public object SyncRoot { get; }
```

_No description available._

## Methods

### Add(string text, System.Drawing.Font font, Color foreColor)

```csharp
public int Add(string text, System.Drawing.Font font, Color foreColor)
```

_No description available._

**Returns** `int`

### Add(TextRun textRun)

```csharp
public int Add(TextRun textRun)
```

_No description available._

**Returns** `int`

### Clear()

```csharp
public void Clear()
```

_No description available._

### Contains(TextRun run)

```csharp
public bool Contains(TextRun run)
```

_No description available._

**Returns** `bool`

### IndexOf(TextRun run)

```csharp
public int IndexOf(TextRun run)
```

_No description available._

**Returns** `int`

### Insert(int index, TextRun run)

```csharp
public void Insert(int index, TextRun run)
```

_No description available._

### Remove(TextRun run)

```csharp
public void Remove(TextRun run)
```

_No description available._

### RemoveAt(int index)

```csharp
public void RemoveAt(int index)
```

_No description available._

### CopyTo(Array array, int index)

```csharp
public void CopyTo(Array array, int index)
```

_No description available._
