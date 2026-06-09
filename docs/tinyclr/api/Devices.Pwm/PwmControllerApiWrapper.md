---
title: "PwmControllerApiWrapper Class"
sidebar_label: "PwmControllerApiWrapper"
---

# PwmControllerApiWrapper Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Pwm.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Pwm`

Concrete `IPwmControllerProvider` backed by the native TinyCLR PWM HAL. Constructed internally by `PwmController`; you don't normally need to use this type directly.

```csharp
public sealed class PwmControllerApiWrapper : IPwmControllerProvider
```

## Constructors

### PwmControllerApiWrapper(NativeApi api)

```csharp
public PwmControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` | The native PWM API to bind to. |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### ChannelCount

```csharp
public extern int ChannelCount { get; }
```

Total number of channels exposed by this controller. _(inherited)_

### MinFrequency

```csharp
public extern double MinFrequency { get; }
```

Minimum frequency in Hz this controller can generate. _(inherited)_

### MaxFrequency

```csharp
public extern double MaxFrequency { get; }
```

Maximum frequency in Hz this controller can generate. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### OpenChannel(int channel)

```csharp
public extern void OpenChannel(int channel)
```

Acquires exclusive access to the specified channel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### CloseChannel(int channel)

```csharp
public extern void CloseChannel(int channel)
```

Releases a previously opened channel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### EnableChannel(int channel)

```csharp
public extern void EnableChannel(int channel)
```

Begins generating the configured waveform on the channel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### DisableChannel(int channel)

```csharp
public extern void DisableChannel(int channel)
```

Stops the waveform; the pin is parked in its inactive state. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### SetPulseParameters(int channel, double dutyCycle, PwmPulsePolarity polarity)

```csharp
public extern void SetPulseParameters(int channel, double dutyCycle, PwmPulsePolarity polarity)
```

Sets the active duty cycle and polarity for the channel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |
| `dutyCycle` | `double` | Active fraction of the period, 0.0..1.0. |
| `polarity` | `PwmPulsePolarity` | Which level is "active". |

### SetDesiredFrequency(double frequency)

```csharp
public extern double SetDesiredFrequency(double frequency)
```

Sets the controller-wide frequency. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `frequency` | `double` | Target frequency in Hz. |

**Returns** `double` — The frequency actually applied.

### SetDesiredFrequency(int channel, double frequency)

```csharp
public extern double SetDesiredFrequency(int channel, double frequency)
```

Sets a per-channel frequency where the hardware supports it. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |
| `frequency` | `double` | Target frequency in Hz. |

**Returns** `double` — The frequency actually applied to that channel.
