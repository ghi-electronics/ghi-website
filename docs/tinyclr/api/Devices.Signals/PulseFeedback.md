---
title: "PulseFeedback Class"
sidebar_label: "PulseFeedback"
---

# PulseFeedback Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals`

Generates a digital pulse on one pin and measures a pulse-related duration on the same pin or a separate echo pin. Common applications: ultrasonic distance sensors (HC-SR04), 1-wire interrogation, capacitive touch.

```csharp
public class PulseFeedback : IDisposable
```

## Constructors

### PulseFeedback(GpioPin pin, PulseFeedbackMode mode)

```csharp
public PulseFeedback(GpioPin pin, PulseFeedbackMode mode) : this(pin, null, mode)
```

Single-pin (drain-duration) constructor.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `GpioPin` |  |
| `mode` | `PulseFeedbackMode` |  |

### PulseFeedback(GpioPin pulsePin, GpioPin echoPin, PulseFeedbackMode mode)

```csharp
public PulseFeedback(GpioPin pulsePin, GpioPin echoPin, PulseFeedbackMode mode)
```

Two-pin (echo / duration-until-echo) constructor.

| Parameter | Type | Description |
|---|---|---|
| `pulsePin` | `GpioPin` |  |
| `echoPin` | `GpioPin` |  |
| `mode` | `PulseFeedbackMode` |  |

## Properties

### DisableInterrupts

```csharp
public bool DisableInterrupts { get; set; }
```

When true, the trigger runs with interrupts disabled for jitter-free timing.

### Timeout

```csharp
public TimeSpan Timeout { get; set; }
```

Maximum time to wait for the echo before giving up.

### PulseLength

```csharp
public TimeSpan PulseLength { get; set; }
```

How long to drive the stimulus pulse before measuring.

### PulseValue

```csharp
public GpioPinValue PulseValue { get; set; }
```

Active level of the stimulus pulse on `pulsePin`.

### EchoValue

```csharp
public GpioPinValue EchoValue { get; set; }
```

Active level of the echo on `echoPin`.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Returns the pin(s) to high-impedance input.

### Trigger()

```csharp
public extern TimeSpan Trigger()
```

Runs one stimulate-and-measure cycle. Returns the measured duration, or `Timeout` when no echo arrives in time.

**Returns** `TimeSpan`
