---
title: "RegexpSyntaxException Class"
sidebar_label: "RegexpSyntaxException"
---

# RegexpSyntaxException Class

**Namespace:** `System.Text.RegularExpressions` · **Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`

Exception thrown to indicate a syntax error in a regular expression. This is a non-checked exception because you should only have problems compiling a regular expression during development. If you are making regular expresion programs dynamically then you can catch it if you wish. But should not be forced to.

```csharp
public class RegexpSyntaxException : Exception
```

## Constructors

### RegexpSyntaxException(String s)

```csharp
public RegexpSyntaxException(String s) : base( + s)
```

Constructor

| Parameter | Type | Description |
|---|---|---|
| `s` | `String` | Further description of the syntax error |
