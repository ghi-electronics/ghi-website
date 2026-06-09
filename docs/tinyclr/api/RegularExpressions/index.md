---
title: "GHIElectronics.TinyCLR.RegularExpressions"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">RegularExpressions Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Capture](./Capture.md) | `System.Text.RegularExpressions` | Represents the results from a single subexpression capture. System.Text.RegularExpressions. Capture respresents one substring to a single successful catpture |
| [CaptureCollection](./CaptureCollection.md) | `System.Text.RegularExpressions` |  |
| [Group](./Group.md) | `System.Text.RegularExpressions` |  |
| [GroupCollection](./GroupCollection.md) | `System.Text.RegularExpressions` |  |
| [Match](./Match.md) | `System.Text.RegularExpressions` | Represents the results from a single regular expression match. |
| [MatchCollection](./MatchCollection.md) | `System.Text.RegularExpressions` |  |
| [RegexCompiler](./RegexCompiler.md) | `System.Text.RegularExpressions` | A regular expression compiler class. This class compiles a pattern string into a regular expression program interpretable by the RE evaluator class. The 'recompile' command line tool uses this compiler to pre-compile regular expressions for use with RE. For a description of the syntax accepted by RECompiler and what you can do with regular expressions, see the documentation for the RE matcher class. |
| [RegexPrecompiler](./RegexPrecompiler.md) | `System.Text.RegularExpressions` | Class for precompiling regular expressions for later use |
| [RegexpSyntaxException](./RegexpSyntaxException.md) | `System.Text.RegularExpressions` | Exception thrown to indicate a syntax error in a regular expression. This is a non-checked exception because you should only have problems compiling a regular expression during development. If you are making regular expresion programs dynamically then you can catch it if you wish. But should not be forced to. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [RegexOptions](./RegexOptions.md) | `System.Text.RegularExpressions` | Options which can be applied to a RegularExpression |
| [ReplaceOptions](./ReplaceOptions.md) | `System.Text.RegularExpressions` |  |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [MatchEvaluator](./MatchEvaluator.md) | `System.Text.RegularExpressions` |  |
