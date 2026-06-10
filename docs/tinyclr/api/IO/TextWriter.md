---
title: "TextWriter Class"
sidebar_label: "TextWriter"
---

# TextWriter Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Base class for writing a sequential series of characters.

```csharp
public abstract class TextWriter : MarshalByRefObject, IDisposable
```

## Properties

### CoreNewLine

```csharp
protected char[] CoreNewLine { }
```

The characters written for a line terminator.

### Encoding

```csharp
public abstract Encoding Encoding { get; }
```

The character encoding the writer uses.

### NewLine

```csharp
public virtual string NewLine { get; set; }
```

The line terminator string used by the writer.

## Methods

### Close()

```csharp
public virtual void Close()
```

Closes the writer and releases its resources.

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by the writer.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the resources used by the writer.

### Flush()

```csharp
public virtual void Flush()
```

Flushes any buffered data to the underlying store.

### Write(char value)

```csharp
public virtual void Write(char value)
```

Writes a character.

### Write(char[] buffer)

```csharp
public virtual void Write(char[] buffer)
```

Writes a character array.

### Write(char[] buffer, int index, int count)

```csharp
public virtual void Write(char[] buffer, int index, int count)
```

Writes a range of characters from an array.

### Write(bool value)

```csharp
public virtual void Write(bool value)
```

Writes the text representation of a boolean value.

### Write(int value)

```csharp
public virtual void Write(int value)
```

Writes the text representation of an integer.

### Write(uint value)

```csharp
public virtual void Write(uint value)
```

Writes the text representation of an unsigned integer.

### Write(long value)

```csharp
public virtual void Write(long value)
```

Writes the text representation of a long integer.

### Write(ulong value)

```csharp
public virtual void Write(ulong value)
```

Writes the text representation of an unsigned long integer.

### Write(float value)

```csharp
public virtual void Write(float value)
```

Writes the text representation of a single-precision number.

### Write(double value)

```csharp
public virtual void Write(double value)
```

Writes the text representation of a double-precision number.

### Write(string value)

```csharp
public virtual void Write(string value)
```

Writes a string.

### Write(object value)

```csharp
public virtual void Write(object value)
```

Writes the text representation of an object.

### WriteLine()

```csharp
public virtual void WriteLine()
```

Writes a line terminator.

### WriteLine(char value)

```csharp
public virtual void WriteLine(char value)
```

Writes a character followed by a line terminator.

### WriteLine(char[] buffer)

```csharp
public virtual void WriteLine(char[] buffer)
```

Writes a character array followed by a line terminator.

### WriteLine(char[] buffer, int index, int count)

```csharp
public virtual void WriteLine(char[] buffer, int index, int count)
```

Writes a range of characters followed by a line terminator.

### WriteLine(bool value)

```csharp
public virtual void WriteLine(bool value)
```

Writes a boolean value followed by a line terminator.

### WriteLine(int value)

```csharp
public virtual void WriteLine(int value)
```

Writes an integer followed by a line terminator.

### WriteLine(uint value)

```csharp
public virtual void WriteLine(uint value)
```

Writes an unsigned integer followed by a line terminator.

### WriteLine(long value)

```csharp
public virtual void WriteLine(long value)
```

Writes a long integer followed by a line terminator.

### WriteLine(ulong value)

```csharp
public virtual void WriteLine(ulong value)
```

Writes an unsigned long integer followed by a line terminator.

### WriteLine(float value)

```csharp
public virtual void WriteLine(float value)
```

Writes a single-precision number followed by a line terminator.

### WriteLine(double value)

```csharp
public virtual void WriteLine(double value)
```

Writes a double-precision number followed by a line terminator.

### WriteLine(string value)

```csharp
public virtual void WriteLine(string value)
```

Writes a string followed by a line terminator.

### WriteLine(object value)

```csharp
public virtual void WriteLine(object value)
```

Writes the text representation of an object followed by a line terminator.
