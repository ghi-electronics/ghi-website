---
title: "IPwmControllerProvider Interface"
sidebar_label: "IPwmControllerProvider"
---

# IPwmControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Pwm.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Pwm`

Provider contract for a PWM controller. Most users call `PwmController` / `PwmChannel` directly; implement this interface only when supplying a custom or virtual PWM.

```csharp
public interface IPwmControllerProvider : IDisposable
```

## Properties

### ChannelCount

```csharp
int ChannelCount { get; }
```

Total number of channels exposed by this controller.

### MinFrequency

```csharp
double MinFrequency { get; }
```

Minimum frequency in Hz this controller can generate.

### MaxFrequency

```csharp
double MaxFrequency { get; }
```

Maximum frequency in Hz this controller can generate.

## Methods

### OpenChannel(int channel)

```csharp
void OpenChannel(int channel)
```

Acquires exclusive access to the specified channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### CloseChannel(int channel)

```csharp
void CloseChannel(int channel)
```

Releases a previously opened channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### EnableChannel(int channel)

```csharp
void EnableChannel(int channel)
```

Begins generating the configured waveform on the channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### DisableChannel(int channel)

```csharp
void DisableChannel(int channel)
```

Stops the waveform; the pin is parked in its inactive state.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### SetPulseParameters(int channel, double dutyCycle, PwmPulsePolarity polarity)

```csharp
void SetPulseParameters(int channel, double dutyCycle, PwmPulsePolarity polarity)
```

Sets the active duty cycle and polarity for the channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |
| `dutyCycle` | `double` | Active fraction of the period, 0.0..1.0. |
| `polarity` | `PwmPulsePolarity` | Which level is "active". |

### SetDesiredFrequency(double frequency)

```csharp
double SetDesiredFrequency(double frequency)
```

Sets the controller-wide frequency.

| Parameter | Type | Description |
|---|---|---|
| `frequency` | `double` | Target frequency in Hz. |

**Returns** `double` — The frequency actually applied.

### SetDesiredFrequency(int channel, double frequency)

```csharp
double SetDesiredFrequency(int channel, double frequency)
```

Sets a per-channel frequency where the hardware supports it.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |
| `frequency` | `double` | Target frequency in Hz. |

**Returns** `double` — The frequency actually applied to that channel.
