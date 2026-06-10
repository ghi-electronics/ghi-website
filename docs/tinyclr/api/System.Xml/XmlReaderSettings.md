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

Initializes a new instance of the `XmlReaderSettings` class.

## Properties

### NameTable

```csharp
public XmlNameTable NameTable { get; set; }
```

The name table used by the reader. Not wrapped; always returns null.

### LineNumberOffset

```csharp
public int LineNumberOffset { get; set; }
```

The starting line number reported by the reader.

### LinePositionOffset

```csharp
public int LinePositionOffset { get; set; }
```

The starting line position reported by the reader.

### ConformanceLevel

```csharp
public ConformanceLevel ConformanceLevel { get; set; }
```

The level of conformance the reader enforces.

### CheckCharacters

```csharp
public bool CheckCharacters { get; set; }
```

Indicates whether the reader checks that characters are legal XML.

### ValidationType

```csharp
public ValidationType ValidationType { get; set; }
```

The type of validation the reader performs.

### IgnoreWhitespace

```csharp
public bool IgnoreWhitespace { get; set; }
```

Indicates whether to ignore insignificant whitespace.

### IgnoreProcessingInstructions

```csharp
public bool IgnoreProcessingInstructions { get; set; }
```

Indicates whether to ignore processing instructions.

### IgnoreComments

```csharp
public bool IgnoreComments { get; set; }
```

Indicates whether to ignore comments.

### CloseInput

```csharp
public bool CloseInput { get; set; }
```

Indicates whether to close the underlying input when the reader is closed.

## Methods

### Reset()

```csharp
public void Reset()
```

Resets the settings to their default values.

### Clone()

```csharp
public XmlReaderSettings Clone()
```

Returns a copy of this settings object.

**Returns** `XmlReaderSettings`
