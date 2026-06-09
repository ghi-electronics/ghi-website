---
title: "GHIElectronics.TinyCLR.System.Xml"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">System.Xml Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [NameTable](./NameTable.md) | `System.Xml` | Hashtable-backed `XmlNameTable`. |
| [XmlException](./XmlException.md) | `System.Xml` | Thrown for XML parse errors; carries line/position info. |
| [XmlNameTable](./XmlNameTable.md) | `System.Xml` | Atomized-string table shared between readers and writers. |
| [XmlReader](./XmlReader.md) | `System.Xml` | Forward-only XML reader. Same surface as .NET's `System.Xml.XmlReader`. |
| [XmlReaderSettings](./XmlReaderSettings.md) | `System.Xml` | Settings bag passed to `XmlReader.Create(Stream, XmlReaderSettings)`. Mirrors the .NET BCL type. |
| [XmlWriter](./XmlWriter.md) | `System.Xml` | Forward-only XML writer. Same surface as .NET's `System.Xml.XmlWriter`. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IXmlLineInfo](./IXmlLineInfo.md) | `System.Xml` |  |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [ConformanceLevel](./ConformanceLevel.md) | `System.Xml` | XML conformance level (auto-detect, fragment, or full document). |
| [NewLineHandling](./NewLineHandling.md) | `System.Xml` | How the writer represents line breaks. |
| [ReadState](./ReadState.md) | `System.Xml` | Reader lifecycle state. |
| [ValidationType](./ValidationType.md) | `System.Xml` | XML validation policy (none or DTD/Schema). |
| [WhitespaceHandling](./WhitespaceHandling.md) | `System.Xml` | How the reader treats whitespace nodes. |
| [XmlNodeType](./XmlNodeType.md) | `System.Xml` | Node kinds in an XML document. Same values as .NET's `System.Xml.XmlNodeType`. |
| [XmlSpace](./XmlSpace.md) | `System.Xml` | Value of an in-scope `xml:space` attribute. |
