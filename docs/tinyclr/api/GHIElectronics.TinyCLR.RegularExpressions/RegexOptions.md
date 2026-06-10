---
title: "RegexOptions Enum"
sidebar_label: "RegexOptions"
---

# RegexOptions Enum

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

Options which can be applied to a RegularExpression

```csharp
public enum RegexOptions
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Compiled` | `8` | Compile the regular expression to a program for faster execution. |
| `CultureInvariant` | `0x200` | Ignore cultural differences in language when matching. |
| `ECMAScript` | `0x100` | Enable ECMAScript-compliant behavior for the expression. |
| `ExplicitCapture` | `4` | Capture only explicitly named or numbered groups. |
| `IgnoreCase` | `1` | Match without regard to case. |
| `IgnorePatternWhitespace` | `0x20` | Ignore unescaped whitespace in the pattern. |
| `Multiline` | `2` | Treat ^ and $ as matching at the start and end of any line. |
| `None` | `0` | Use the default options. |
| `Singleline` | `0x10` | Make the period (.) match every character, including newlines. |
| `Timed` | `0x400` | Time the match and throw if it exceeds the allowed number of ticks. |
