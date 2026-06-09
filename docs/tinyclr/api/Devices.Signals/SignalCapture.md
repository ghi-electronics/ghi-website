---
title: "SignalCapture Class"
sidebar_label: "SignalCapture"
---

# SignalCapture Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals`

Samples a digital input and records the durations between successive edges — the inverse of `SignalGenerator`. Useful for capturing IR-remote codes, decoding bit-banged protocols, or measuring pulse widths.

```csharp
public class SignalCapture : IDisposable
```

## Constructors

### SignalCapture(GpioPin pin)

```csharp
public SignalCapture(GpioPin pin)
```

Opens a capture session on the given pin.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `GpioPin` |  |

## Properties

### DisableInterrupts

```csharp
public bool DisableInterrupts { get; set; }
```

When true, capture runs with interrupts disabled.

### Timeout

```csharp
public TimeSpan Timeout { get; set; }
```

Maximum total time the capture will wait before returning.

### DriveMode

```csharp
public GpioPinDriveMode DriveMode { get; set; }
```

Drive mode applied to the capture pin (typically input or input-pull-up).

## Methods

### Dispose()

```csharp
public void Dispose()
```

Returns the pin to high-impedance input.

### Read()

```csharp
public GpioPinValue Read()
```

Samples the current level of the pin without waiting.

**Returns** `GpioPinValue`

### Read(out GpioPinValue initialState, TimeSpan[] buffer)

```csharp
public int Read(out GpioPinValue initialState, TimeSpan[] buffer)
```

Captures up to `buffer`.Length inter-edge intervals starting now.

| Parameter | Type | Description |
|---|---|---|
| `initialState` | `out GpioPinValue` | Receives the level of the pin at the moment capture began. |
| `buffer` | `TimeSpan[]` | Receives inter-edge intervals. |

**Returns** `int` — Number of intervals captured.

### Read(GpioPinValue waitForState, TimeSpan[] buffer)

```csharp
public int Read(GpioPinValue waitForState, TimeSpan[] buffer)
```

Waits for the pin to reach `waitForState`, then captures inter-edge intervals.

| Parameter | Type | Description |
|---|---|---|
| `waitForState` | `GpioPinValue` | Level the capture should be armed by. |
| `buffer` | `TimeSpan[]` | Receives inter-edge intervals. |

**Returns** `int` — Number of intervals captured.

### Read(out GpioPinValue initialState, TimeSpan[] buffer, int offset, int count)

```csharp
public extern int Read(out GpioPinValue initialState, TimeSpan[] buffer, int offset, int count)
```

Captures a slice of inter-edge intervals.

| Parameter | Type | Description |
|---|---|---|
| `initialState` | `out GpioPinValue` |  |
| `buffer` | `TimeSpan[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### Read(GpioPinValue waitForState, TimeSpan[] buffer, int offset, int count)

```csharp
public extern int Read(GpioPinValue waitForState, TimeSpan[] buffer, int offset, int count)
```

Captures a slice of inter-edge intervals after waiting for `waitForState`.

| Parameter | Type | Description |
|---|---|---|
| `waitForState` | `GpioPinValue` |  |
| `buffer` | `TimeSpan[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`
