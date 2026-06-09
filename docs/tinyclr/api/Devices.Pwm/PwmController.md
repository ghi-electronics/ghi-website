---
title: "PwmController Class"
sidebar_label: "PwmController"
---

# PwmController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Pwm` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Pwm`

Represents a PWM peripheral. Set the frequency via `SetDesiredFrequency(double)`, open one or more channels with `OpenChannel(int)`, then drive each channel's duty cycle.

```csharp
public class PwmController : IDisposable
```

## Properties

### Provider

```csharp
public IPwmControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### ActualFrequency

```csharp
public double ActualFrequency { get; set; }
```

The frequency the hardware actually applied, in Hz, after the last call to `SetDesiredFrequency(double)`. May differ from the requested value due to prescaler/timer rounding.

### ChannelCount

```csharp
public int ChannelCount { get; }
```

Total number of channels on this controller.

### MinFrequency

```csharp
public double MinFrequency { get; }
```

Minimum frequency in Hz this controller can generate.

### MaxFrequency

```csharp
public double MaxFrequency { get; }
```

Maximum frequency in Hz this controller can generate.

## Methods

### GetDefault()

```csharp
public static PwmController GetDefault()
```

Returns the default PWM controller for this device.

**Returns** `PwmController`

### FromName(string name)

```csharp
public static PwmController FromName(string name)
```

Returns a PWM controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Native API name. |

**Returns** `PwmController`

### FromProvider(IPwmControllerProvider provider)

```csharp
public static PwmController FromProvider(IPwmControllerProvider provider)
```

Creates a controller from a custom `IPwmControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IPwmControllerProvider` | Provider implementing the channel operations. |

**Returns** `PwmController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### SetDesiredFrequency(double desiredFrequency)

```csharp
public double SetDesiredFrequency(double desiredFrequency)
```

Sets the controller-wide PWM frequency.

| Parameter | Type | Description |
|---|---|---|
| `desiredFrequency` | `double` | Target frequency in Hz. |

**Returns** `double` — The frequency actually applied (also published as `ActualFrequency`).

### SetDesiredFrequency(PwmChannel channel, double desiredFrequency)

```csharp
public double SetDesiredFrequency(PwmChannel channel, double desiredFrequency)
```

Sets a per-channel frequency on hardware that supports it.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `PwmChannel` | The channel to configure. |
| `desiredFrequency` | `double` | Target frequency in Hz. |

**Returns** `double` — The frequency actually applied to that channel.

### OpenChannel(int channelNumber)

```csharp
public PwmChannel OpenChannel(int channelNumber)
```

Opens a channel on this controller.

| Parameter | Type | Description |
|---|---|---|
| `channelNumber` | `int` | Controller-relative channel index. |

**Returns** `PwmChannel` — A `PwmChannel`; dispose it to release the channel.
