---
title: "ButtonDevice Class"
sidebar_label: "ButtonDevice"
---

# ButtonDevice Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The ButtonDevice class represents the button device to the members of a context.

```csharp
public sealed class ButtonDevice : InputDevice
```

## Properties

### Target

```csharp
public override UIElement Target { get; }
```

Returns the element that input from this device is sent to.

### DeviceType

```csharp
public override InputManager.InputDeviceType DeviceType { get; }
```

gets the Device Type / Read "Identity Object" Class Code 0x01 - Attribute ID 2 _(inherited)_

## Methods

### Focus(UIElement obj)

```csharp
public UIElement Focus(UIElement obj)
```

Focuses the button input on a particular element.

| Parameter | Type | Description |
|---|---|---|
| `obj` | `UIElement` |  |

**Returns** `UIElement` — Element focused to

### IsButtonDown(HardwareButton button)

```csharp
public bool IsButtonDown(HardwareButton button)
```

Returns whether or not the specified button is down.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `bool`

### IsButtonUp(HardwareButton button)

```csharp
public bool IsButtonUp(HardwareButton button)
```

Returns whether or not the specified button is up.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `bool`

### IsButtonHeld(HardwareButton button)

```csharp
public bool IsButtonHeld(HardwareButton button)
```

Returns whether or not the specified button is held.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `bool`

### GetButtonState(HardwareButton button)

```csharp
public ButtonState GetButtonState(HardwareButton button)
```

Returns the state of the specified button.

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |

**Returns** `ButtonState`
