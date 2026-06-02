---
title: "Capture Class"
sidebar_label: "Capture"
---

# Capture Class

**Namespace:** `System.Text.RegularExpressions` · **Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`

Represents the results from a single subexpression capture. System.Text.RegularExpressions. Capture respresents one substring to a single successful catpture

```csharp
public class Capture
```

## Properties

### Length

```csharp
public int Length { get; }
```

Gets length of bytes in the stream. _(inherited)_

### Value

```csharp
public string Value { get; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_

## Methods

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`
