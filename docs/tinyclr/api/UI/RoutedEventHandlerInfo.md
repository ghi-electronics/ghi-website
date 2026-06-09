---
title: "RoutedEventHandlerInfo Class"
sidebar_label: "RoutedEventHandlerInfo"
---

# RoutedEventHandlerInfo Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

Container for handler instance and other invocation preferences for this handler instance

```csharp
public class RoutedEventHandlerInfo
```

## Properties

### InvokeHandledEventsToo

```csharp
public bool InvokeHandledEventsToo { get; }
```

Returns HandledEventsToo Flag

## Methods

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Is the given object equivalent to the current one

| Parameter | Type | Description |
|---|---|---|
| `obj` | `object` |  |

**Returns** `bool`

### Equals(RoutedEventHandlerInfo handlerInfo)

```csharp
public bool Equals(RoutedEventHandlerInfo handlerInfo)
```

Is the given RoutedEventHandlerInfo equals the current

| Parameter | Type | Description |
|---|---|---|
| `handlerInfo` | `RoutedEventHandlerInfo` |  |

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table

**Returns** `int`

### ==(RoutedEventHandlerInfo handlerInfo1, RoutedEventHandlerInfo handlerInfo2)

```csharp
public static bool operator ==(RoutedEventHandlerInfo handlerInfo1, RoutedEventHandlerInfo handlerInfo2)
```

Equals operator overload

| Parameter | Type | Description |
|---|---|---|
| `handlerInfo1` | `RoutedEventHandlerInfo` |  |
| `handlerInfo2` | `RoutedEventHandlerInfo` |  |

**Returns** `bool operator`

### !=(RoutedEventHandlerInfo handlerInfo1, RoutedEventHandlerInfo handlerInfo2)

```csharp
public static bool operator !=(RoutedEventHandlerInfo handlerInfo1, RoutedEventHandlerInfo handlerInfo2)
```

NotEquals operator overload

| Parameter | Type | Description |
|---|---|---|
| `handlerInfo1` | `RoutedEventHandlerInfo` |  |
| `handlerInfo2` | `RoutedEventHandlerInfo` |  |

**Returns** `bool operator`
