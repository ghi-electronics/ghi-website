---
title: "InputEventArgs Class"
sidebar_label: "InputEventArgs"
---

# InputEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class InputEventArgs : RoutedEventArgs
```

## Constructors

### InputEventArgs(InputDevice inputDevice, DateTime timestamp)

```csharp
public InputEventArgs(InputDevice inputDevice, DateTime timestamp)
```

Initializes a new instance of the InputEventArgs class.

| Parameter | Type | Description |
|---|---|---|
| `inputDevice` | `InputDevice` | The input device to associate with this event. |
| `timestamp` | `DateTime` | The time when the input occured. |

## Properties

### Device

```csharp
public InputDevice Device { get; }
```

Read-only access to the input device that initiated this event.

## Fields

### Timestamp

```csharp
public readonly DateTime Timestamp
```

Read-only access to the input timestamp.
