---
title: "PwmChannel Class"
sidebar_label: "PwmChannel"
---

# PwmChannel Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Pwm` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Pwm`

A single PWM channel opened from a `PwmController`. Configure `Polarity` and duty cycle, then call `Start` to begin driving the output.

```csharp
public class PwmChannel : IDisposable
```

## Properties

### ChannelNumber

```csharp
public int ChannelNumber { get; }
```

Controller-relative channel index this object represents.

### Controller

```csharp
public PwmController Controller { get; }
```

The `PwmController` that owns this channel.

### IsStarted

```csharp
public bool IsStarted { get; set; }
```

True once `Start` has been called and `Stop` has not.

### Polarity

```csharp
public PwmPulsePolarity Polarity { get; set; }
```

Selects whether the active part of the pulse is high or low.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the channel so another caller can open it.

### GetActiveDutyCyclePercentage()

```csharp
public double GetActiveDutyCyclePercentage()
```

Returns the most recently set duty cycle as a 0.0..1.0 fraction.

**Returns** `double`

### SetActiveDutyCyclePercentage(double dutyCyclePercentage)

```csharp
public void SetActiveDutyCyclePercentage(double dutyCyclePercentage)
```

Sets the duty cycle as a 0.0..1.0 fraction of the period.

| Parameter | Type | Description |
|---|---|---|
| `dutyCyclePercentage` | `double` | 0.0 = always inactive, 1.0 = always active. |

### Start()

```csharp
public void Start()
```

Begins generating the configured waveform on the channel.

### Stop()

```csharp
public void Stop()
```

Stops the waveform; the pin is parked in its inactive state.
