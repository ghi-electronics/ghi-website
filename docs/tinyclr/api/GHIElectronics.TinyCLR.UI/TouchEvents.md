---
title: "TouchEvents Class"
sidebar_label: "TouchEvents"
---

# TouchEvents Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Defines the routed events raised for touch input.

```csharp
public sealed class TouchEvents
```

## Methods

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(TouchEventArgs))

```csharp
public static readonly RoutedEvent TouchDownEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(TouchEventArgs))
```

A routed event raised when a touch press occurs.

**Returns** `RoutedEvent TouchDownEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(TouchEventArgs))

```csharp
public static readonly RoutedEvent TouchMoveEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(TouchEventArgs))
```

A routed event raised when a touch point moves.

**Returns** `RoutedEvent TouchMoveEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(TouchEventArgs))

```csharp
public static readonly RoutedEvent TouchUpEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(TouchEventArgs))
```

A routed event raised when a touch release occurs.

**Returns** `RoutedEvent TouchUpEvent = new`
