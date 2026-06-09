---
title: "PinValueChangedEventArgs Class"
sidebar_label: "PinValueChangedEventArgs"
---

# PinValueChangedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `System.Device.Gpio`<br/>**Namespace:** `System.Device.Gpio`

Arguments for the .NET IoT pin-change callback.

```csharp
public sealed class PinValueChangedEventArgs : EventArgs
```

## Constructors

### PinValueChangedEventArgs(PinEventTypes changeType, int pinNumber)

```csharp
public PinValueChangedEventArgs(PinEventTypes changeType, int pinNumber)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `changeType` | `PinEventTypes` |  |
| `pinNumber` | `int` |  |

## Properties

### ChangeType

```csharp
public PinEventTypes ChangeType { get; }
```

_No description available._

### PinNumber

```csharp
public int PinNumber { get; }
```

The controller-relative pin index this object represents. _(inherited)_
