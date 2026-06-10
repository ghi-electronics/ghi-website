---
title: "SignalGenerator Class"
sidebar_label: "SignalGenerator"
---

# SignalGenerator Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals`

Drives a pin through a precise sequence of high/low transitions. Suitable for generating IR-remote waveforms, addressable-LED streams (WS281x), and other strict-timing protocols. Optional carrier-frequency modulation is available for IR.

```csharp
public class SignalGenerator : IDisposable
```

## Constructors

### SignalGenerator(GpioPin pin)

```csharp
public SignalGenerator(GpioPin pin)
```

Opens a signal generator on the given pin (drives it as a push-pull output).

## Properties

### DisableInterrupts

```csharp
public bool DisableInterrupts { get; set; }
```

When true, the write runs with interrupts disabled for sub-microsecond accuracy.

### GenerateCarrierFrequency

```csharp
public bool GenerateCarrierFrequency { get; set; }
```

When true, the output is modulated with the carrier frequency.

### CarrierFrequency

```csharp
public long CarrierFrequency { get; }
```

Carrier frequency in Hz used when `GenerateCarrierFrequency` is true.

### IdleValue

```csharp
public GpioPinValue IdleValue { get; set; }
```

The level the pin returns to between transitions.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Returns the pin to high-impedance input.

### Write(GpioPinValue value)

```csharp
public void Write(GpioPinValue value)
```

Sets the pin to a static level.

### Write(TimeSpan[] buffer)

```csharp
public void Write(TimeSpan[] buffer)
```

Drives the pin through a sequence of timed transitions.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `TimeSpan[]` | Durations of each segment, alternating active/inactive starting from the current `IdleValue`'s opposite. |

### Write(TimeSpan[] buffer, int offset, int count)

```csharp
public extern void Write(TimeSpan[] buffer, int offset, int count)
```

Drives a slice of the timed transitions.
