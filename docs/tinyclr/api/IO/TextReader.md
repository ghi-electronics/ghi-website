---
title: "TextReader Class"
sidebar_label: "TextReader"
---

# TextReader Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

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

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._

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

_No description available._

**Returns** `int`

### Read(char[] buffer, int index, int count)

```csharp
public virtual int Read(char[] buffer, int index, int count)
```

_No description available._

**Returns** `int`

### ReadBlock(char[] buffer, int index, int count)

```csharp
public virtual int ReadBlock(char[] buffer, int index, int count)
```

_No description available._

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
