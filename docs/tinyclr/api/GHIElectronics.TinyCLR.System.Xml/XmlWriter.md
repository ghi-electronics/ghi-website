---
title: "XmlWriter Class"
sidebar_label: "XmlWriter"
---

# XmlWriter Class

**Namespace:** `System.Xml` · **Assembly:** `GHIElectronics.TinyCLR.System.Xml`

Forward-only XML writer. Same surface as .NET's `System.Xml.XmlWriter`.

```csharp
public abstract class XmlWriter : IDisposable
```

## Methods

### WriteStartDocument()

```csharp
public abstract void WriteStartDocument()
```

_No description available._

### WriteStartDocument(bool standalone)

```csharp
public abstract void WriteStartDocument(bool standalone)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `standalone` | `bool` |  |

### WriteEndDocument()

```csharp
public abstract void WriteEndDocument()
```

_No description available._

### WriteStartElement(string localName)

```csharp
public abstract void WriteStartElement(string localName)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `localName` | `string` |  |

### WriteStartElement(string localName, string ns)

```csharp
public abstract void WriteStartElement(string localName, string ns)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `localName` | `string` |  |
| `ns` | `string` |  |

### WriteStartElement(string prefix, string localName, string ns)

```csharp
public abstract void WriteStartElement(string prefix, string localName, string ns)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `prefix` | `string` |  |
| `localName` | `string` |  |
| `ns` | `string` |  |

### WriteEndElement()

```csharp
public abstract void WriteEndElement()
```

_No description available._

### WriteFullEndElement()

```csharp
public abstract void WriteFullEndElement()
```

_No description available._

### WriteAttributeString(string localName, string value)

```csharp
public abstract void WriteAttributeString(string localName, string value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `localName` | `string` |  |
| `value` | `string` |  |

### WriteAttributeString(string localName, string ns, string value)

```csharp
public abstract void WriteAttributeString(string localName, string ns, string value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `localName` | `string` |  |
| `ns` | `string` |  |
| `value` | `string` |  |

### WriteAttributeString(string prefix, string localName, string ns, string value)

```csharp
public abstract void WriteAttributeString(string prefix, string localName, string ns, string value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `prefix` | `string` |  |
| `localName` | `string` |  |
| `ns` | `string` |  |
| `value` | `string` |  |

### WriteString(string text)

```csharp
public abstract void WriteString(string text)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |

### WriteRaw(string data)

```csharp
public abstract void WriteRaw(string data)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `string` |  |

### WriteCData(string text)

```csharp
public abstract void WriteCData(string text)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |

### WriteComment(string text)

```csharp
public abstract void WriteComment(string text)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |

### WriteProcessingInstruction(string name, string text)

```csharp
public abstract void WriteProcessingInstruction(string name, string text)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `text` | `string` |  |

### Flush()

```csharp
public abstract void Flush()
```

Writes unwritten data to the file. _(inherited)_

### Close()

```csharp
public abstract void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### LookupPrefix(string ns)

```csharp
public abstract string LookupPrefix(string ns)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `ns` | `string` |  |

**Returns** `string`

### WriteElementString(string localName, string value)

```csharp
public void WriteElementString(string localName, string value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `localName` | `string` |  |
| `value` | `string` |  |

### Dispose()

```csharp
public virtual void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Create(Stream output)

```csharp
public static XmlWriter Create(Stream output)
```

Creates a WebRequest . _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `output` | `Stream` |  |

**Returns** `XmlWriter`
