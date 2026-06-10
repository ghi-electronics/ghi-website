---
title: "IXmlLineInfo Interface"
sidebar_label: "IXmlLineInfo"
---

# IXmlLineInfo Interface

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

Provides line and position information for the current node.

```csharp
public interface IXmlLineInfo
```

## Properties

### LineNumber

```csharp
int LineNumber { get; }
```

Gets the line number of the current node.

### LinePosition

```csharp
int LinePosition { get; }
```

Gets the line position of the current node.

## Methods

### HasLineInfo()

```csharp
bool HasLineInfo()
```

Gets a value indicating whether line information is available.

**Returns** `bool`
