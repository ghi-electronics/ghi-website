---
title: "RoutedEvent Class"
sidebar_label: "RoutedEvent"
---

# RoutedEvent Class

**Namespace:** `GHIElectronics.TinyCLR.UI` · **Assembly:** `GHIElectronics.TinyCLR.UI`

RoutedEvent is a unique identifier for any registered RoutedEvent

```csharp
public sealed class RoutedEvent
```

## Properties

### RoutingStrategy

```csharp
public RoutingStrategy RoutingStrategy { get; }
```

Returns the `RoutingStrategy` of the RoutedEvent

### HandlerType

```csharp
public Type HandlerType { get; }
```

Returns Type of Handler for the RoutedEvent

## Methods

### ToString()

```csharp
public override string ToString()
```

String representation

**Returns** `string`
