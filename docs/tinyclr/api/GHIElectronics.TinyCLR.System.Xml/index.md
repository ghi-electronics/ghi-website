---
title: "GHIElectronics.TinyCLR.System.Xml"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.System.Xml

NuGet package containing **14** types.

## Classes

| Class | Summary |
|---|---|
| [NameTable](./NameTable.md) | Hashtable-backed `XmlNameTable`. |
| [XmlException](./XmlException.md) | Thrown for XML parse errors; carries line/position info. |
| [XmlNameTable](./XmlNameTable.md) | Atomized-string table shared between readers and writers. |
| [XmlReader](./XmlReader.md) | Forward-only XML reader. Same surface as .NET's `System.Xml.XmlReader`. |
| [XmlReaderSettings](./XmlReaderSettings.md) | Settings bag passed to `XmlReader.Create(Stream, XmlReaderSettings)`. Mirrors the .NET BCL type. |
| [XmlWriter](./XmlWriter.md) | Forward-only XML writer. Same surface as .NET's `System.Xml.XmlWriter`. |

## Interfaces

| Interface | Summary |
|---|---|
| [IXmlLineInfo](./IXmlLineInfo.md) |  |

## Enums

| Enum | Summary |
|---|---|
| [ConformanceLevel](./ConformanceLevel.md) | XML conformance level (auto-detect, fragment, or full document). |
| [NewLineHandling](./NewLineHandling.md) | How the writer represents line breaks. |
| [ReadState](./ReadState.md) | Reader lifecycle state. |
| [ValidationType](./ValidationType.md) | XML validation policy (none or DTD/Schema). |
| [WhitespaceHandling](./WhitespaceHandling.md) | How the reader treats whitespace nodes. |
| [XmlNodeType](./XmlNodeType.md) | Node kinds in an XML document. Same values as .NET's `System.Xml.XmlNodeType`. |
| [XmlSpace](./XmlSpace.md) | Value of an in-scope `xml:space` attribute. |
