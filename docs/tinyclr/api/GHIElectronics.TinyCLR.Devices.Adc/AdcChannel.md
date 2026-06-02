---
title: "AdcChannel Class"
sidebar_label: "AdcChannel"
---

# AdcChannel Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Adc` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Adc`

A single ADC channel opened from an `AdcController`. Call `ReadValue` for raw codes or `ReadRatio` for a 0.0–1.0 normalized reading.

```csharp
public class AdcChannel : IDisposable
```

## Properties

### ChannelNumber

```csharp
public int ChannelNumber { get; }
```

Controller-relative channel index this object represents.

### Controller

```csharp
public AdcController Controller { get; }
```

The `AdcController` that owns this channel.

### SamplingTime

```csharp
public TimeSpan SamplingTime { get; set; }
```

Sample-and-hold time the controller is asked to use. Longer times reduce noise on high-impedance sources but slow conversion.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the channel so another caller can open it.

### ReadValue()

```csharp
public int ReadValue()
```

Performs a conversion and returns the raw integer code.

**Returns** `int` — An integer in the range [`AdcController.MinValue`, `AdcController.MaxValue`].

### ReadRatio()

```csharp
public double ReadRatio()
```

Performs a conversion and returns a 0.0..1.0 normalized reading.

**Returns** `double` — The raw code mapped to [0.0, 1.0] using the controller's `AdcController.MinValue`/`AdcController.MaxValue`.
