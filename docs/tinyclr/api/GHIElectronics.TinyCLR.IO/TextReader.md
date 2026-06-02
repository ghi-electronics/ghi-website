---
title: "TextReader Class"
sidebar_label: "TextReader"
---

# TextReader Class

**Namespace:** `System.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

_No description available._

```csharp
public abstract class TextReader : MarshalByRefObject, IDisposable
```

## Constructors

### TextReader()

```csharp
protected TextReader()
```

_No description available._

## Methods

### Close()

```csharp
public virtual void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### Peek()

```csharp
public virtual int Peek()
```

_No description available._

**Returns** `int`

### Read()

```csharp
public virtual int Read()
```

Samples the current level of the pin without waiting. _(inherited)_

**Returns** `int`

### Read(char[] buffer, int index, int count)

```csharp
public virtual int Read(char[] buffer, int index, int count)
```

Reads a block of bytes from the stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |
| `index` | `int` |  |
| `count` | `int` | The maximun number of bytes to read. |

**Returns** `int`

### ReadBlock(char[] buffer, int index, int count)

```csharp
public virtual int ReadBlock(char[] buffer, int index, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |
| `index` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### ReadToEnd()

```csharp
public virtual string ReadToEnd()
```

_No description available._

**Returns** `string`

### ReadLine()

```csharp
public virtual string ReadLine()
```

_No description available._

**Returns** `string`
