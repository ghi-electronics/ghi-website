---
title: "InputDevice Class"
sidebar_label: "InputDevice"
---

# InputDevice Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Provides the base class for all input devices.

```csharp
public abstract class InputDevice : DispatcherObject
```

## Constructors

### InputDevice()

```csharp
protected InputDevice()
```

Constructs an instance of the InputDevice class.

## Properties

### Target

```csharp
public abstract UIElement Target { get; }
```

Returns the element that input from this device is sent to.

### DeviceType

```csharp
public abstract InputManager.InputDeviceType DeviceType { get; }
```

The input device type for this device.
