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

_No description available._

### XmlException(string message)

```csharp
public XmlException(string message) : base(message)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` |  |

### XmlException(string message, Exception innerException)

```csharp
public XmlException(string message, Exception innerException) : base(message, innerException)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` |  |
| `innerException` | `Exception` |  |

### XmlException(string message, Exception innerException, int lineNumber, int linePosition)

```csharp
public XmlException(string message, Exception innerException, int lineNumber, int linePosition) : base(message, innerException)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` |  |
| `innerException` | `Exception` |  |
| `lineNumber` | `int` |  |
| `linePosition` | `int` |  |

## Properties

### LineNumber

```csharp
public int LineNumber { get; }
```

_No description available._

### LinePosition

```csharp
public int LinePosition { get; }
```

_No description available._
