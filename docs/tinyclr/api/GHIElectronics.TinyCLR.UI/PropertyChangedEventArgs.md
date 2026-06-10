---
title: "PropertyChangedEventArgs Class"
sidebar_label: "PropertyChangedEventArgs"
---

# PropertyChangedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

Provides data for the various property changed events.

```csharp
public class PropertyChangedEventArgs
```

## Constructors

### PropertyChangedEventArgs(string property, object oldValue, object newValue)

```csharp
public PropertyChangedEventArgs(string property, object oldValue, object newValue)
```

Initializes a new instance of the PropertyChangedEventArgs class.

| Parameter | Type | Description |
|---|---|---|
| `property` | `string` | The property whose value changed. |
| `oldValue` | `object` | The value of the property before the change. |
| `newValue` | `object` | The value of the property after the change. |

## Fields

### Property

```csharp
public readonly string Property
```

The property whose value changed.

### OldValue

```csharp
public readonly object OldValue
```

The value of the property before the change.

### NewValue

```csharp
public readonly object NewValue
```

The value of the property after the change.
