---
title: "InputManager Class"
sidebar_label: "InputManager"
---

# InputManager Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

The InputManager class is responsible for coordinating all of the input system in TinyCore. The input manager exists per Dispatcher

```csharp
public sealed class InputManager : DispatcherObject
```

## Properties

### CurrentInputManager

```csharp
public static InputManager CurrentInputManager { get; }
```

Return the input manager associated with the current context.

### ButtonDevice

```csharp
public ButtonDevice ButtonDevice { get; }
```

_No description available._

### TouchDevice

```csharp
public TouchDevice TouchDevice { get; }
```

_No description available._

### GenericDevice

```csharp
public GenericDevice GenericDevice { get; }
```

_No description available._

### InputProviders

```csharp
public ICollection InputProviders { get; }
```

Returns a collection of input providers registered with the input manager.

### MostRecentInputDevice

```csharp
public InputDevice MostRecentInputDevice { get; set; }
```

The MostRecentInputDevice represents the last input device to report an "interesting" user action. What exactly constitutes such an action is up to each device to implement.

## Methods

### RoutedEvent( ,  RoutingStrategy.Tunnel,  typeof(InputReportEventHandler))

```csharp
public static readonly RoutedEvent PreviewInputReportEvent = new RoutedEvent( , RoutingStrategy.Tunnel, typeof(InputReportEventHandler))
```

A routed event indicating that an input report arrived.

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Tunnel` | `` |  |
| `typeof(InputReportEventHandler)` | `` |  |

**Returns** `RoutedEvent PreviewInputReportEvent = new`

### RoutedEvent( ,  RoutingStrategy.Bubble,  typeof(InputReportEventHandler))

```csharp
public static readonly RoutedEvent InputReportEvent = new RoutedEvent( , RoutingStrategy.Bubble, typeof(InputReportEventHandler))
```

A routed event indicating that an input report arrived.

| Parameter | Type | Description |
|---|---|---|
| `` | `` |  |
| `RoutingStrategy.Bubble` | `` |  |
| `typeof(InputReportEventHandler)` | `` |  |

**Returns** `RoutedEvent InputReportEvent = new`

### RegisterInputProvider(object inputProvider)

```csharp
public InputProviderSite RegisterInputProvider(object inputProvider)
```

Registers an input provider with the input manager.

| Parameter | Type | Description |
|---|---|---|
| `inputProvider` | `object` | The input provider to register. |

**Returns** `InputProviderSite`

### ProcessInput(InputEventArgs input)

```csharp
public bool ProcessInput(InputEventArgs input)
```

Synchronously processes the specified input.

| Parameter | Type | Description |
|---|---|---|
| `input` | `InputEventArgs` |  |

**Returns** `bool` — Whether or not any event generated as a consequence of this event was handled.

## Fields

### InputDeviceEvents

```csharp
public DeviceEvents[] InputDeviceEvents
```

_No description available._
