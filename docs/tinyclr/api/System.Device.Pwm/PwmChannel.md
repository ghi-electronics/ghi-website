---
title: "PwmChannel Class"
sidebar_label: "PwmChannel"
---

# PwmChannel Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Pwm`<br/>**Assembly:** `System.Device.Pwm`<br/>**Namespace:** `System.Device.Pwm`

.NET-style PWM channel. Same surface as `System.Device.Pwm.PwmChannel`; internally routes through TinyCLR's PWM driver.

```csharp
public class PwmChannel : IDisposable
```

## Constructors

### PwmChannel(int chip, int channel)

```csharp
protected PwmChannel(int chip, int channel) : this(chip, channel, 400, 0.5)
```

Opens a channel on the given chip at 400 Hz and 50% duty cycle.

### PwmChannel(int chip, int channel, int frequency, double dutyCyclePercentage)

```csharp
protected PwmChannel(int chip, int channel, int frequency, double dutyCyclePercentage)
```

Opens a channel on the given chip with the given frequency and duty cycle.

## Properties

### Channel

```csharp
public int Channel { get; }
```

The channel number on the controller.

### Controller

```csharp
public int Controller { get; }
```

The controller (chip) index.

### Frequency

```csharp
public double Frequency { get; set; }
```

The output frequency in Hz. Setting it changes the whole controller's frequency.

### DutyCycle

```csharp
public double DutyCycle { get; set; }
```

The duty cycle from 0.0 to 1.0.

### Polarity

```csharp
public PwmPulsePolarity Polarity { get; set; }
```

The pulse polarity.

## Methods

### Create(int chip, int channel)

```csharp
public static PwmChannel Create(int chip, int channel)
```

Opens a channel on the given chip at 400 Hz and 50% duty cycle.

**Returns** `PwmChannel`

### Create(int chip, int channel, int frequency, double dutyCyclePercentage)

```csharp
public static PwmChannel Create(int chip, int channel, int frequency = 400, double dutyCyclePercentage = 0.5)
```

Opens a channel on the given chip with the given frequency and duty cycle.

**Returns** `PwmChannel`

### Start()

```csharp
public void Start()
```

Starts the PWM output.

### Stop()

```csharp
public void Stop()
```

Stops the PWM output.

### Dispose()

```csharp
public void Dispose()
```

Stops the output and releases the channel.
