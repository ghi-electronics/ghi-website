---
title: "XmlReaderSettings Class"
sidebar_label: "XmlReaderSettings"
---

# XmlReaderSettings Class

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

Settings bag passed to `XmlReader.Create(Stream, XmlReaderSettings)`. Mirrors the .NET BCL type.

```csharp
public class XmlReaderSettings
```

## Constructors

### XmlReaderSettings()

```csharp
public XmlReaderSettings()
```

_No description available._

## Properties

### NameTable

```csharp
public XmlNameTable NameTable { get; set; }
```

_No description available._

### LineNumberOffset

```csharp
public int LineNumberOffset { get; set; }
```

_No description available._

### LinePositionOffset

```csharp
public int LinePositionOffset { get; set; }
```

_No description available._

### ConformanceLevel

```csharp
public ConformanceLevel ConformanceLevel { get; set; }
```

_No description available._

### CheckCharacters

```csharp
public bool CheckCharacters { get; set; }
```

_No description available._

### ValidationType

```csharp
public ValidationType ValidationType { get; set; }
```

_No description available._

### IgnoreWhitespace

```csharp
public bool IgnoreWhitespace { get; set; }
```

_No description available._

### IgnoreProcessingInstructions

```csharp
public bool IgnoreProcessingInstructions { get; set; }
```

_No description available._

### IgnoreComments

```csharp
public bool IgnoreComments { get; set; }
```

_No description available._

### CloseInput

```csharp
public bool CloseInput { get; set; }
```

_No description available._

## Methods

### Reset()

```csharp
public void Reset()
```

_No description available._

### Clone()

```csharp
public XmlReaderSettings Clone()
```

_No description available._

**Returns** `XmlReaderSettings`
