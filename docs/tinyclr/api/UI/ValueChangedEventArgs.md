---
title: "ValueChangedEventArgs Class"
sidebar_label: "ValueChangedEventArgs"
---

# ValueChangedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public sealed class ValueChangedEventArgs : EventArgs
```

## Constructors

### ValueChangedEventArgs(double value)

```csharp
public ValueChangedEventArgs(double value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `value` | `double` |  |

## Properties

### Value

```csharp
public double Value { get; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_
