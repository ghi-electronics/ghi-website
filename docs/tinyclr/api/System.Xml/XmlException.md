---
title: "XmlException Class"
sidebar_label: "XmlException"
---

# XmlException Class

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

Thrown for XML parse errors; carries line/position info.

```csharp
public class XmlException : Exception
```

## Constructors

### XmlException()

```csharp
public XmlException() : base()
```

Initializes a new instance of the `XmlException` class.

### XmlException(string message)

```csharp
public XmlException(string message) : base(message)
```

Initializes a new instance of the `XmlException` class with the specified message.

### XmlException(string message, Exception innerException)

```csharp
public XmlException(string message, Exception innerException) : base(message, innerException)
```

Initializes a new instance of the `XmlException` class with the specified message and inner exception.

### XmlException(string message, Exception innerException, int lineNumber, int linePosition)

```csharp
public XmlException(string message, Exception innerException, int lineNumber, int linePosition) : base(message, innerException)
```

Initializes a new instance of the `XmlException` class with the specified message, inner exception, and line information.

## Properties

### LineNumber

```csharp
public int LineNumber { get; }
```

The line number where the error occurred.

### LinePosition

```csharp
public int LinePosition { get; }
```

The line position where the error occurred.
