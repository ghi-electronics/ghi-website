---
title: "RegexCompiler Class"
sidebar_label: "RegexCompiler"
---

# RegexCompiler Class

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

A regular expression compiler class. This class compiles a pattern string into a regular expression program interpretable by the RE evaluator class. The 'recompile' command line tool uses this compiler to pre-compile regular expressions for use with RE. For a description of the syntax accepted by RECompiler and what you can do with regular expressions, see the documentation for the RE matcher class.

```csharp
public class RegexCompiler
```

## Properties

### Pattern

```csharp
public string Pattern { get; }
```

_No description available._
