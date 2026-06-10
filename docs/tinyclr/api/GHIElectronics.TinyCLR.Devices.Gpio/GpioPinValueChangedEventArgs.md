---
title: "GpioPinValueChangedEventArgs Class"
sidebar_label: "GpioPinValueChangedEventArgs"
---

# GpioPinValueChangedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio`

Arguments for the `GpioPin.ValueChanged` event.

```csharp
public class GpioPinValueChangedEventArgs : EventArgs
```

## Constructors

### GpioPinValueChangedEventArgs(GpioPinEdge edge, DateTime timestamp)

```csharp
public GpioPinValueChangedEventArgs(GpioPinEdge edge, DateTime timestamp)
```

Creates a new `GpioPinValueChangedEventArgs`.

| Parameter | Type | Description |
|---|---|---|
| `edge` | `GpioPinEdge` | The edge direction that triggered the event. |
| `timestamp` | `DateTime` | Driver-captured time of the transition. |

## Properties

### Edge

```csharp
public GpioPinEdge Edge { get; }
```

The edge direction (rising or falling) that triggered the event.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time at which the transition was detected.
