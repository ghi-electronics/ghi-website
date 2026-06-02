---
title: "GHIElectronics.TinyCLR.RegularExpressions"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.RegularExpressions

NuGet package containing **12** types.

## Classes

| Class | Summary |
|---|---|
| [Capture](./Capture.md) | Represents the results from a single subexpression capture. System.Text.RegularExpressions. Capture respresents one substring to a single successful catpture |
| [CaptureCollection](./CaptureCollection.md) |  |
| [Group](./Group.md) |  |
| [GroupCollection](./GroupCollection.md) |  |
| [Match](./Match.md) | Represents the results from a single regular expression match. |
| [MatchCollection](./MatchCollection.md) |  |
| [RegexCompiler](./RegexCompiler.md) | A regular expression compiler class. This class compiles a pattern string into a regular expression program interpretable by the RE evaluator class. The 'recompile' command line tool uses this compiler to pre-compile regular expressions for use with RE. For a description of the syntax accepted by RECompiler and what you can do with regular expressions, see the documentation for the RE matcher class. |
| [RegexPrecompiler](./RegexPrecompiler.md) | Class for precompiling regular expressions for later use |
| [RegexpSyntaxException](./RegexpSyntaxException.md) | Exception thrown to indicate a syntax error in a regular expression. This is a non-checked exception because you should only have problems compiling a regular expression during development. If you are making regular expresion programs dynamically then you can catch it if you wish. But should not be forced to. |

## Enums

| Enum | Summary |
|---|---|
| [RegexOptions](./RegexOptions.md) | Options which can be applied to a RegularExpression |
| [ReplaceOptions](./ReplaceOptions.md) |  |

## Delegates

| Delegate | Summary |
|---|---|
| [MatchEvaluator](./MatchEvaluator.md) |  |
