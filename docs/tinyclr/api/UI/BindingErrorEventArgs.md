---
title: "BindingErrorEventArgs Class"
sidebar_label: "BindingErrorEventArgs"
---

# BindingErrorEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

Reported by controls (currently `TextBox`) when a reflection- based binding read or write fails. Subscribing is optional — the framework defaults to silent so a misspelled property name doesn't crash the UI, but a subscriber can log or surface the error.

```csharp
public sealed class BindingErrorEventArgs
```

## Constructors

### BindingErrorEventArgs(BindingErrorDirection direction, string propertyName, Exception exception)

```csharp
public BindingErrorEventArgs(BindingErrorDirection direction, string propertyName, Exception exception)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `direction` | `BindingErrorDirection` |  |
| `propertyName` | `string` |  |
| `exception` | `Exception` |  |

## Properties

### Direction

```csharp
public BindingErrorDirection Direction { get; }
```

The new direction of the hat switch. _(inherited)_

### PropertyName

```csharp
public string PropertyName { get; }
```

_No description available._

### Exception

```csharp
public Exception Exception { get; }
```

_No description available._
