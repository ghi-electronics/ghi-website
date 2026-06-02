---
title: "PwmChannel Class"
sidebar_label: "PwmChannel"
---

# PwmChannel Class

**Namespace:** `System.Device.Pwm` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Pwm`

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

| Parameter | Type | Description |
|---|---|---|
| `chip` | `int` |  |
| `channel` | `int` |  |

### PwmChannel(int chip, int channel, int frequency, double dutyCyclePercentage)

```csharp
protected PwmChannel(int chip, int channel, int frequency, double dutyCyclePercentage)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `chip` | `int` |  |
| `channel` | `int` |  |
| `frequency` | `int` |  |
| `dutyCyclePercentage` | `double` |  |

## Properties

### Channel

```csharp
public int Channel { get; }
```

AP channel (1..13). AccessPoint mode only. _(inherited)_

### Controller

```csharp
public int Controller { get; }
```

The `SpiController` this device transacts over. _(inherited)_

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

Selects whether the active part of the pulse is high or low. _(inherited)_

## Methods

### Create(int chip, int channel)

```csharp
public static PwmChannel Create(int chip, int channel)
```

Creates or overwrites a file. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `chip` | `int` |  |
| `channel` | `int` |  |

**Returns** `PwmChannel` — TinyFileStream that provides stream based access to the file.

### Create(int chip, int channel, int frequency, double dutyCyclePercentage)

```csharp
public static PwmChannel Create(int chip, int channel, int frequency = 400, double dutyCyclePercentage = 0.5)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `chip` | `int` |  |
| `channel` | `int` |  |
| `frequency` | `int` |  |
| `dutyCyclePercentage` | `double` |  |

**Returns** `PwmChannel`

### Start()

```csharp
public void Start()
```

Starts the timer. _(inherited)_

### Stop()

```csharp
public void Stop()
```

Stops the timer. _(inherited)_

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
