---
title: "Buttons Class"
sidebar_label: "Buttons"
---

# Buttons Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The Button class represents the button device to the members of a context.

```csharp
public sealed class Buttons
```

## Properties

### FocusedElement

```csharp
public static UIElement FocusedElement { get; }
```

Returns the element that the button is focused on.

### PrimaryDevice

```csharp
public static ButtonDevice PrimaryDevice { get; }
```

The primary button device.

## Methods

### RoutedEvent( ,  RoutingStrategy.Tunnel,  typeof(ButtonEventHandler))

```csharp
public static readonly RoutedEvent PreviewButtonDownEvent = new RoutedEvent( , RoutingStrategy.Tunnel, typeof(ButtonEventHandler))
```

PreviewButtonDown

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Tunnel` | `` |  |
| `typeof(ButtonEventHandler)` | `` |  |

**Returns** `RoutedEvent PreviewButtonDownEvent = new`

### RoutedEvent( ,  RoutingStrategy.Tunnel,  typeof(ButtonEventHandler))

```csharp
public static readonly RoutedEvent PreviewButtonUpEvent = new RoutedEvent( , RoutingStrategy.Tunnel, typeof(ButtonEventHandler))
```

PreviewButtonUp

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Tunnel` | `` |  |
| `typeof(ButtonEventHandler)` | `` |  |

**Returns** `RoutedEvent PreviewButtonUpEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(ButtonEventHandler))

```csharp
public static readonly RoutedEvent ButtonDownEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(ButtonEventHandler))
```

ButtonDown

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Bubble` | `` |  |
| `typeof(ButtonEventHandler)` | `` |  |

**Returns** `RoutedEvent ButtonDownEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(ButtonEventHandler))

```csharp
public static readonly RoutedEvent ButtonUpEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(ButtonEventHandler))
```

ButtonUp

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Bubble` | `` |  |
| `typeof(ButtonEventHandler)` | `` |  |

**Returns** `RoutedEvent ButtonUpEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(FocusChangedEventHandler))

```csharp
public static readonly RoutedEvent GotFocusEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(FocusChangedEventHandler))
```

GotFocus

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Bubble` | `` |  |
| `typeof(FocusChangedEventHandler)` | `` |  |

**Returns** `RoutedEvent GotFocusEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(FocusChangedEventHandler))

```csharp
public static readonly RoutedEvent LostFocusEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(FocusChangedEventHandler))
```

LostFocus

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Bubble` | `` |  |
| `typeof(FocusChangedEventHandler)` | `` |  |

**Returns** `RoutedEvent LostFocusEvent = new`

### Focus(UIElement element)

```csharp
public static UIElement Focus(UIElement element)
```

Focuses the button on a particular element.

| Parameter | Type | Description |
|---|---|---|
| `element` | `UIElement` | The element to focus the button on. |

**Returns** `UIElement`

### IsButtonDown(HardwareButton button)

```csharp
public static bool IsButtonDown(HardwareButton button)
```

Returns whether or not the specified button is down.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `bool`

### IsButtonUp(HardwareButton button)

```csharp
public static bool IsButtonUp(HardwareButton button)
```

Returns whether or not the specified button is up.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `bool`

### IsButtonHeld(HardwareButton button)

```csharp
public static bool IsButtonHeld(HardwareButton button)
```

Returns whether or not the specified button is held.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `bool`

### GetButtonState(HardwareButton button)

```csharp
public static ButtonState GetButtonState(HardwareButton button)
```

Returns the state of the specified button.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `ButtonState`
