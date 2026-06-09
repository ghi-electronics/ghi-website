---
title: "XmlWriter Class"
sidebar_label: "XmlWriter"
---

# XmlWriter Class

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

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

### WriteStartElement(string localName, string ns)

```csharp
public abstract void WriteStartElement(string localName, string ns)
```

_No description available._

### WriteStartElement(string prefix, string localName, string ns)

```csharp
public abstract void WriteStartElement(string prefix, string localName, string ns)
```

_No description available._

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

### WriteAttributeString(string localName, string ns, string value)

```csharp
public abstract void WriteAttributeString(string localName, string ns, string value)
```

_No description available._

### WriteAttributeString(string prefix, string localName, string ns, string value)

```csharp
public abstract void WriteAttributeString(string prefix, string localName, string ns, string value)
```

_No description available._

### WriteString(string text)

```csharp
public abstract void WriteString(string text)
```

_No description available._

### WriteRaw(string data)

```csharp
public abstract void WriteRaw(string data)
```

_No description available._

### WriteCData(string text)

```csharp
public abstract void WriteCData(string text)
```

_No description available._

### WriteComment(string text)

```csharp
public abstract void WriteComment(string text)
```

_No description available._

### WriteProcessingInstruction(string name, string text)

```csharp
public abstract void WriteProcessingInstruction(string name, string text)
```

_No description available._

### Flush()

```csharp
public abstract void Flush()
```

_No description available._

### Close()

```csharp
public abstract void Close()
```

_No description available._

### LookupPrefix(string ns)

```csharp
public abstract string LookupPrefix(string ns)
```

_No description available._

**Returns** `string`

### WriteElementString(string localName, string value)

```csharp
public void WriteElementString(string localName, string value)
```

_No description available._

### Dispose()

```csharp
public virtual void Dispose()
```

_No description available._

### Create(Stream output)

```csharp
public static XmlWriter Create(Stream output)
```

_No description available._

**Returns** `XmlWriter`
