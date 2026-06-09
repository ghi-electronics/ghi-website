---
title: "TextWriter Class"
sidebar_label: "TextWriter"
---

# TextWriter Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public abstract class TextWriter : MarshalByRefObject, IDisposable
```

## Properties

### CoreNewLine

```csharp
protected char[] CoreNewLine { }
```

_No description available._

### Encoding

```csharp
public abstract Encoding Encoding { get; }
```

_No description available._

### NewLine

```csharp
public virtual string NewLine { get; set; }
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

### Flush()

```csharp
public virtual void Flush()
```

Writes unwritten data to the file. _(inherited)_

### Write(char value)

```csharp
public virtual void Write(char value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `char` |  |

### Write(char[] buffer)

```csharp
public virtual void Write(char[] buffer)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |

### Write(char[] buffer, int index, int count)

```csharp
public virtual void Write(char[] buffer, int index, int count)
```

Writes a block of bytes to the file stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |
| `index` | `int` |  |
| `count` | `int` | The number of bytes to write. |

### Write(bool value)

```csharp
public virtual void Write(bool value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `bool` |  |

### Write(int value)

```csharp
public virtual void Write(int value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `int` |  |

### Write(uint value)

```csharp
public virtual void Write(uint value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `uint` |  |

### Write(long value)

```csharp
public virtual void Write(long value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `long` |  |

### Write(ulong value)

```csharp
public virtual void Write(ulong value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `ulong` |  |

### Write(float value)

```csharp
public virtual void Write(float value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `float` |  |

### Write(double value)

```csharp
public virtual void Write(double value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `double` |  |

### Write(string value)

```csharp
public virtual void Write(string value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `string` |  |

### Write(object value)

```csharp
public virtual void Write(object value)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `object` |  |

### WriteLine()

```csharp
public virtual void WriteLine()
```

_No description available._

### WriteLine(char value)

```csharp
public virtual void WriteLine(char value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `char` |  |

### WriteLine(char[] buffer)

```csharp
public virtual void WriteLine(char[] buffer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |

### WriteLine(char[] buffer, int index, int count)

```csharp
public virtual void WriteLine(char[] buffer, int index, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |
| `index` | `int` |  |
| `count` | `int` |  |

### WriteLine(bool value)

```csharp
public virtual void WriteLine(bool value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `bool` |  |

### WriteLine(int value)

```csharp
public virtual void WriteLine(int value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `int` |  |

### WriteLine(uint value)

```csharp
public virtual void WriteLine(uint value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `uint` |  |

### WriteLine(long value)

```csharp
public virtual void WriteLine(long value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `long` |  |

### WriteLine(ulong value)

```csharp
public virtual void WriteLine(ulong value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `ulong` |  |

### WriteLine(float value)

```csharp
public virtual void WriteLine(float value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `float` |  |

### WriteLine(double value)

```csharp
public virtual void WriteLine(double value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `double` |  |

### WriteLine(string value)

```csharp
public virtual void WriteLine(string value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `string` |  |

### WriteLine(object value)

```csharp
public virtual void WriteLine(object value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `object` |  |
