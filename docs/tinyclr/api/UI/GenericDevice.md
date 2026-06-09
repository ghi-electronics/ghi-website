---
title: "GenericDevice Class"
sidebar_label: "GenericDevice"
---

# GenericDevice Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

The GenericDevice class represents the Generic device to the members of a context.

```csharp
public sealed class GenericDevice : InputDevice
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

_No description available._

## Methods

### SetTarget(UIElement target)

```csharp
public void SetTarget(UIElement target)
```

_No description available._
