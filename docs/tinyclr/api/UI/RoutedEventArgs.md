---
title: "RoutedEventArgs Class"
sidebar_label: "RoutedEventArgs"
---

# RoutedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The container for all state associated with a RoutedEvent

```csharp
public class RoutedEventArgs : EventArgs
```

## Constructors

### RoutedEventArgs(RoutedEvent routedEvent)

```csharp
public RoutedEventArgs(RoutedEvent routedEvent) : this(routedEvent, null)
```

Constructor for `RoutedEventArgs`

| Parameter | Type | Description |
|---|---|---|
| `routedEvent` | `RoutedEvent` | The new value that the RoutedEvent Property is being set to |

### RoutedEventArgs(RoutedEvent routedEvent, object source)

```csharp
public RoutedEventArgs(RoutedEvent routedEvent, object source)
```

Constructor for `RoutedEventArgs`

| Parameter | Type | Description |
|---|---|---|
| `routedEvent` | `RoutedEvent` | The new value that the RoutedEvent Property is being set to |
| `source` | `object` | The new value that the SourceProperty is being set to |

## Properties

### Handled

```csharp
public bool Handled { get; set; }
```

Returns a boolean flag indicating if or not this RoutedEvent has been handled this far in the route

### Source

```csharp
public object Source { get; set; }
```

Returns Source object that raised the RoutedEvent

### OriginalSource

```csharp
public object OriginalSource { get; }
```

Returns OriginalSource object that raised the RoutedEvent

## Methods

### OnSetSource(object source)

```csharp
protected virtual void OnSetSource(object source)
```

Invoked when the source of the event is set

| Parameter | Type | Description |
|---|---|---|
| `source` | `object` | The new value that the SourceProperty is being set to |
