---
title: "GHIElectronics.TinyCLR.RegularExpressions"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.RegularExpressions</h1>

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Capture](./Capture.md) | `System.Text.RegularExpressions` | Represents the results from a single subexpression capture. System.Text.RegularExpressions. Capture respresents one substring to a single successful catpture |
| [CaptureCollection](./CaptureCollection.md) | `System.Text.RegularExpressions` | Represents the set of captures made by a single capturing group. |
| [Group](./Group.md) | `System.Text.RegularExpressions` | Represents the results from a single capturing group. |
| [GroupCollection](./GroupCollection.md) | `System.Text.RegularExpressions` | Represents the set of capturing groups matched by a regular expression. |
| [Match](./Match.md) | `System.Text.RegularExpressions` | Represents the results from a single regular expression match. |
| [MatchCollection](./MatchCollection.md) | `System.Text.RegularExpressions` | Represents the set of successful matches found by iteratively applying a regular expression pattern to the input string. |
| [RegexCompiler](./RegexCompiler.md) | `System.Text.RegularExpressions` | A regular expression compiler class. This class compiles a pattern string into a regular expression program interpretable by the RE evaluator class. The 'recompile' command line tool uses this compiler to pre-compile regular expressions for use with RE. For a description of the syntax accepted by RECompiler and what you can do with regular expressions, see the documentation for the RE matcher class. |
| [RegexPrecompiler](./RegexPrecompiler.md) | `System.Text.RegularExpressions` | Class for precompiling regular expressions for later use |
| [RegexpSyntaxException](./RegexpSyntaxException.md) | `System.Text.RegularExpressions` | Exception thrown to indicate a syntax error in a regular expression. This is a non-checked exception because you should only have problems compiling a regular expression during development. If you are making regular expresion programs dynamically then you can catch it if you wish. But should not be forced to. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [RegexOptions](./RegexOptions.md) | `System.Text.RegularExpressions` | Options which can be applied to a RegularExpression |
| [ReplaceOptions](./ReplaceOptions.md) | `System.Text.RegularExpressions` | Options that control how a replacement is applied to matches. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [MatchEvaluator](./MatchEvaluator.md) | `System.Text.RegularExpressions` | Represents the method that is called each time a regular expression match is found, returning the replacement string. |
