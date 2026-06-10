---
title: "Capture Class"
sidebar_label: "Capture"
---

# Capture Class

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

Represents the results from a single subexpression capture. System.Text.RegularExpressions. Capture respresents one substring to a single successful catpture

```csharp
public class Capture
```

## Properties

### Length

```csharp
public int Length { get; }
```

The length of the captured substring.

### Value

```csharp
public string Value { get; }
```

The captured substring from the input string.

## Methods

### ToString()

```csharp
public override string ToString()
```

Returns the captured substring.

**Returns** `string`
