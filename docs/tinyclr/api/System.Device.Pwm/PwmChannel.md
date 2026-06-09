---
title: "PwmChannel Class"
sidebar_label: "PwmChannel"
---

# PwmChannel Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Pwm`<br/>**Assembly:** `System.Device.Pwm`<br/>**Namespace:** `System.Device.Pwm`

_No description available._

```csharp
public class PwmChannel : IDisposable
```

## Constructors

### PwmChannel(int chip, int channel)

```csharp
protected PwmChannel(int chip, int channel) : this(chip, channel, 400, 0.5)
```

_No description available._

### PwmChannel(int chip, int channel, int frequency, double dutyCyclePercentage)

```csharp
protected PwmChannel(int chip, int channel, int frequency, double dutyCyclePercentage)
```

_No description available._

## Properties

### Channel

```csharp
public int Channel { get; }
```

_No description available._

### Controller

```csharp
public int Controller { get; }
```

_No description available._

### Frequency

```csharp
public double Frequency { get; set; }
```

_No description available._

### DutyCycle

```csharp
public double DutyCycle { get; set; }
```

_No description available._

### Polarity

```csharp
public PwmPulsePolarity Polarity { get; set; }
```

_No description available._

## Methods

### Create(int chip, int channel)

```csharp
public static PwmChannel Create(int chip, int channel)
```

_No description available._

**Returns** `PwmChannel`

### Create(int chip, int channel, int frequency, double dutyCyclePercentage)

```csharp
public static PwmChannel Create(int chip, int channel, int frequency = 400, double dutyCyclePercentage = 0.5)
```

_No description available._

**Returns** `PwmChannel`

### Start()

```csharp
public void Start()
```

_No description available._

### Stop()

```csharp
public void Stop()
```

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._
