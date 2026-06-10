---
title: "ConformanceLevel Enum"
sidebar_label: "ConformanceLevel"
---

# ConformanceLevel Enum

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

XML conformance level (auto-detect, fragment, or full document).

```csharp
public enum ConformanceLevel
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Auto` | `0` | The conformance level is detected automatically from the input. |
| `Fragment` | `1` | The input conforms to the rules for a well-formed XML fragment. |
| `Document` | `2` | The input conforms to the rules for a well-formed XML document. |
