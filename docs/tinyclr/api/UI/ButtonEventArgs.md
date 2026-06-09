---
title: "ButtonEventArgs Class"
sidebar_label: "ButtonEventArgs"
---

# ButtonEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The ButtonEventArgs class contains information about button states.

```csharp
public class ButtonEventArgs : InputEventArgs
```

## Constructors

### ButtonEventArgs(ButtonDevice buttonDevice, PresentationSource inputSource, DateTime timestamp, HardwareButton button)

```csharp
public ButtonEventArgs(ButtonDevice buttonDevice, PresentationSource inputSource, DateTime timestamp, HardwareButton button) : base(buttonDevice, timestamp)
```

Constructs an instance of the ButtonEventArgs class.

| Parameter | Type | Description |
|---|---|---|
| `buttonDevice` | `ButtonDevice` | The button device associated with this event. |
| `inputSource` | `PresentationSource` |  |
| `timestamp` | `DateTime` | The time when the input occured. (machine time) |
| `button` | `HardwareButton` | The button referenced by the event. |

## Properties

### ButtonState

```csharp
public ButtonState ButtonState { get; }
```

The state of the button referenced by the event.

### IsRepeat

```csharp
public bool IsRepeat { get; }
```

Whether the button pressed is a repeated button or not.

## Fields

### Button

```csharp
public readonly HardwareButton Button
```

The Button referenced by the event.

### InputSource

```csharp
public readonly PresentationSource InputSource
```

The source for this button
