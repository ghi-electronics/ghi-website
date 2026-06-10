---
title: "ValidationType Enum"
sidebar_label: "ValidationType"
---

# ValidationType Enum

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

XML validation policy (none or DTD/Schema).

```csharp
public enum ValidationType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No validation is performed. |
| `Auto` | `1` | The validation type is detected automatically. |
| `DTD` | `2` | Validate according to a DTD. |
| `XDR` | `3` | Validate according to XML-Data Reduced (XDR) schemas. |
| `Schema` | `4` | Validate according to XSD schemas. |
