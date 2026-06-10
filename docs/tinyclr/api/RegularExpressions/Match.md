---
title: "Match Class"
sidebar_label: "Match"
---

# Match Class

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

Represents the results from a single regular expression match.

```csharp
public class Match : Group
```

## Properties

### Groups

```csharp
public virtual GroupCollection Groups { get; }
```

The collection of groups matched by the regular expression.

## Methods

### NextMatch()

```csharp
public Match NextMatch()
```

Returns a new match starting at the position where the previous match ended.

**Returns** `Match`

### Result(string replacement)

```csharp
public virtual string Result(string replacement)
```

Returns the expansion of the specified replacement pattern for this match.

**Returns** `string`

### Synchronized(Match inner)

```csharp
public static Match Synchronized(Match inner)
```

Returns a thread-safe wrapper around the specified match.

**Returns** `Match`
