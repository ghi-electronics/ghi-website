---
title: "XmlReader Class"
sidebar_label: "XmlReader"
---

# XmlReader Class

**Namespace:** `System.Xml` · **Assembly:** `GHIElectronics.TinyCLR.System.Xml`

Forward-only XML reader. Same surface as .NET's `System.Xml.XmlReader`.

```csharp
public abstract class XmlReader : IDisposable
```

## Properties

### NodeType

```csharp
public abstract XmlNodeType NodeType { get; }
```

_No description available._

### LocalName

```csharp
public abstract string LocalName { get; }
```

_No description available._

### NamespaceURI

```csharp
public abstract string NamespaceURI { get; }
```

_No description available._

### Prefix

```csharp
public abstract string Prefix { get; }
```

_No description available._

### HasValue

```csharp
public abstract bool HasValue { get; }
```

_No description available._

### Value

```csharp
public abstract string Value { get; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_

### Depth

```csharp
public abstract int Depth { get; }
```

_No description available._

### BaseURI

```csharp
public abstract string BaseURI { get; }
```

_No description available._

### IsEmptyElement

```csharp
public abstract bool IsEmptyElement { get; }
```

_No description available._

### AttributeCount

```csharp
public abstract int AttributeCount { get; }
```

_No description available._

### EOF

```csharp
public abstract bool EOF { get; }
```

_No description available._

### ReadState

```csharp
public abstract ReadState ReadState { get; }
```

_No description available._

### Name

```csharp
public virtual string Name { get; }
```

The native API name. _(inherited)_

### HasAttributes

```csharp
public virtual bool HasAttributes { get; }
```

_No description available._

## Methods

### GetAttribute(string name)

```csharp
public abstract string GetAttribute(string name)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `string`

### GetAttribute(string name, string namespaceURI)

```csharp
public abstract string GetAttribute(string name, string namespaceURI)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `namespaceURI` | `string` |  |

**Returns** `string`

### GetAttribute(int i)

```csharp
public abstract string GetAttribute(int i)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `i` | `int` |  |

**Returns** `string`

### MoveToAttribute(string name)

```csharp
public abstract bool MoveToAttribute(string name)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `bool`

### MoveToAttribute(string name, string ns)

```csharp
public abstract bool MoveToAttribute(string name, string ns)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `ns` | `string` |  |

**Returns** `bool`

### MoveToFirstAttribute()

```csharp
public abstract bool MoveToFirstAttribute()
```

_No description available._

**Returns** `bool`

### MoveToNextAttribute()

```csharp
public abstract bool MoveToNextAttribute()
```

_No description available._

**Returns** `bool`

### MoveToElement()

```csharp
public abstract bool MoveToElement()
```

_No description available._

**Returns** `bool`

### ReadAttributeValue()

```csharp
public abstract bool ReadAttributeValue()
```

_No description available._

**Returns** `bool`

### Read()

```csharp
public abstract bool Read()
```

Samples the current level of the pin without waiting. _(inherited)_

**Returns** `bool`

### Close()

```csharp
public abstract void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### LookupNamespace(string prefix)

```csharp
public abstract string LookupNamespace(string prefix)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `prefix` | `string` |  |

**Returns** `string`

### ResolveEntity()

```csharp
public abstract void ResolveEntity()
```

_No description available._

### Skip()

```csharp
public virtual void Skip()
```

_No description available._

### ReadString()

```csharp
public virtual string ReadString()
```

_No description available._

**Returns** `string`

### IsStartElement()

```csharp
public virtual bool IsStartElement()
```

_No description available._

**Returns** `bool`

### IsStartElement(string name)

```csharp
public virtual bool IsStartElement(string name)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `bool`

### MoveToContent()

```csharp
public virtual XmlNodeType MoveToContent()
```

_No description available._

**Returns** `XmlNodeType`

### ReadStartElement()

```csharp
public virtual void ReadStartElement()
```

_No description available._

### ReadStartElement(string name)

```csharp
public virtual void ReadStartElement(string name)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

### ReadEndElement()

```csharp
public virtual void ReadEndElement()
```

_No description available._

### ReadElementString()

```csharp
public virtual string ReadElementString()
```

_No description available._

**Returns** `string`

### Dispose()

```csharp
public virtual void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Create(Stream input)

```csharp
public static XmlReader Create(Stream input)
```

Creates a WebRequest . _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `input` | `Stream` |  |

**Returns** `XmlReader`

### Create(Stream input, XmlReaderSettings settings)

```csharp
public static XmlReader Create(Stream input, XmlReaderSettings settings)
```

Creates or overwrites a file. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `input` | `Stream` |  |
| `settings` | `XmlReaderSettings` |  |

**Returns** `XmlReader` — TinyFileStream that provides stream based access to the file.

### Create(Stream input, XmlReaderSettings settings, string baseUri)

```csharp
public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `input` | `Stream` |  |
| `settings` | `XmlReaderSettings` |  |
| `baseUri` | `string` |  |

**Returns** `XmlReader`

### IsName(string str)

```csharp
public static bool IsName(string str)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `str` | `string` |  |

**Returns** `bool`

### IsNameToken(string str)

```csharp
public static bool IsNameToken(string str)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `str` | `string` |  |

**Returns** `bool`
