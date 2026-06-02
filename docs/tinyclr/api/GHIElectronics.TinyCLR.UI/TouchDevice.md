---
title: "TouchDevice Class"
sidebar_label: "TouchDevice"
---

# TouchDevice Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The TouchDevice class represents the stylus/touch device to the members of a context.

```csharp
public sealed class TouchDevice : InputDevice
```

## Properties

### Target

```csharp
public override UIElement Target { get; }
```

Returns the element that input from this device is sent to. _(inherited)_

### DeviceType

```csharp
public override InputManager.InputDeviceType DeviceType { get; }
```

gets the Device Type / Read "Identity Object" Class Code 0x01 - Attribute ID 2 _(inherited)_

## Methods

### SetTarget(UIElement target)

```csharp
public void SetTarget(UIElement target)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `target` | `UIElement` |  |
