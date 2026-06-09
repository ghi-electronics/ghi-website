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

_No description available._

## Methods

### NextMatch()

```csharp
public Match NextMatch()
```

_No description available._

**Returns** `Match`

### Result(string replacement)

```csharp
public virtual string Result(string replacement)
```

_No description available._

**Returns** `string`

### Synchronized(Match inner)

```csharp
public static Match Synchronized(Match inner)
```

_No description available._

**Returns** `Match`
