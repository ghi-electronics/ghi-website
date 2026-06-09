---
title: "ButtonDevice Class"
sidebar_label: "ButtonDevice"
---

# ButtonDevice Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

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

_No description available._

## Methods

### Focus(UIElement obj)

```csharp
public UIElement Focus(UIElement obj)
```

Focuses the button input on a particular element.

**Returns** `UIElement` — Element focused to

### IsButtonDown(HardwareButton button)

```csharp
public bool IsButtonDown(HardwareButton button)
```

Returns whether or not the specified button is down.

**Returns** `bool`

### IsButtonUp(HardwareButton button)

```csharp
public bool IsButtonUp(HardwareButton button)
```

Returns whether or not the specified button is up.

**Returns** `bool`

### IsButtonHeld(HardwareButton button)

```csharp
public bool IsButtonHeld(HardwareButton button)
```

Returns whether or not the specified button is held.

**Returns** `bool`

### GetButtonState(HardwareButton button)

```csharp
public ButtonState GetButtonState(HardwareButton button)
```

Returns the state of the specified button.

**Returns** `ButtonState`
