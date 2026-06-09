---
title: "DigitalSignal Class"
sidebar_label: "DigitalSignal"
---

# DigitalSignal Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals`

DMA/timer-backed pulse-train I/O on a small set of pins. Capable of pulse counting (`ReadPulse`), high-resolution edge capture (`Capture`), and emitting pulse-width-modulated sequences (`Generate`). All three operations are mutually exclusive and run asynchronously — completion is reported via `OnReadPulseFinished` / `OnCaptureFinished` / `OnGenerateFinished`. Only specific pins are supported (currently 0, 1, and 19).

```csharp
public class DigitalSignal : IDisposable
```

## Constructors

### DigitalSignal(GpioPin pin)

```csharp
public DigitalSignal(GpioPin pin)
```

Opens a digital-signal session on a supported pin (0, 1, or 19).

| Parameter | Type | Description |
|---|---|---|
| `pin` | `GpioPin` |  |

## Properties

### CanReadPulse

```csharp
public bool CanReadPulse { get; }
```

True when no operation is in progress and `ReadPulse` may be called.

### CanCapture

```csharp
public bool CanCapture { get; }
```

True when no operation is in progress and `Capture` may be called.

### CanGenerate

```csharp
public bool CanGenerate { get; }
```

True when no operation is in progress and `Generate` may be called.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native pulse-train resources.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Dispose implementation.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` |  |

### ReadPulse(uint pulseNum, GpioPinEdge edge, bool waitForEdge)

```csharp
public void ReadPulse(uint pulseNum, GpioPinEdge edge, bool waitForEdge)
```

Counts up to `pulseNum` edges matching `edge` and measures the total elapsed time. Result is delivered via `OnReadPulseFinished`.

| Parameter | Type | Description |
|---|---|---|
| `pulseNum` | `uint` | Number of edges to count. |
| `edge` | `GpioPinEdge` | Which edge(s) to count. |
| `waitForEdge` | `bool` | When true, the timer starts on the first matching edge instead of immediately. |

### Capture(uint bufferSize, GpioPinEdge edge, bool waitForEdge)

```csharp
public void Capture(uint bufferSize, GpioPinEdge edge, bool waitForEdge)
```

Captures inter-edge intervals. See full-parameter overload for buffer-layout details.

| Parameter | Type | Description |
|---|---|---|
| `bufferSize` | `uint` |  |
| `edge` | `GpioPinEdge` |  |
| `waitForEdge` | `bool` |  |

### Capture(uint count, GpioPinEdge edge, bool waitForEdge, TimeSpan timeout)

```csharp
public void Capture(uint count, GpioPinEdge edge, bool waitForEdge, TimeSpan timeout)
```

Capture timestamps of `count` edges on the pin.

| Parameter | Type | Description |
|---|---|---|
| `count` | `uint` |  |
| `edge` | `GpioPinEdge` |  |
| `waitForEdge` | `bool` |  |
| `timeout` | `TimeSpan` |  |

### Generate(uint[] data, uint offset, uint count)

```csharp
public void Generate(uint[] data, uint offset, uint count)
```

Emits a pulse train described by `data` with default multiplier and starting high.

| Parameter | Type | Description |
|---|---|---|
| `data` | `uint[]` |  |
| `offset` | `uint` |  |
| `count` | `uint` |  |

### Generate(uint[] data, uint offset, uint count, uint multiplier)

```csharp
public void Generate(uint[] data, uint offset, uint count, uint multiplier)
```

Emits a pulse train with explicit multiplier and starting high.

| Parameter | Type | Description |
|---|---|---|
| `data` | `uint[]` |  |
| `offset` | `uint` |  |
| `count` | `uint` |  |
| `multiplier` | `uint` |  |

### Generate(uint[] data, uint offset, uint count, uint multiplier, GpioPinValue startingPolarity)

```csharp
public void Generate(uint[] data, uint offset, uint count, uint multiplier, GpioPinValue startingPolarity)
```

Emits a pulse train: each `data` entry is a duration in timer ticks, alternating polarity starting from `startingPolarity`.

| Parameter | Type | Description |
|---|---|---|
| `data` | `uint[]` | Buffer of segment durations. |
| `offset` | `uint` | Starting index in `data`. |
| `count` | `uint` | Number of entries to emit. |
| `multiplier` | `uint` | Multiplier applied to each duration entry (timer-tick scaling). |
| `startingPolarity` | `GpioPinValue` | Polarity of the first segment. |

### Abort()

```csharp
public void Abort()
```

Aborts the running operation, if any.

## Events

### OnReadPulseFinished

```csharp
public event PulseReadEventHandler OnReadPulseFinished
```

Raised when `ReadPulse` completes.

### OnCaptureFinished

```csharp
public event PulseCaptureEventHandler OnCaptureFinished
```

Raised when `Capture` completes.

### OnGenerateFinished

```csharp
public event PulseGenerateEventHandler OnGenerateFinished
```

Raised when `Generate` completes.
