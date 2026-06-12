---
title: "GpioPin Class"
sidebar_label: "GpioPin"
---

# GpioPin Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio`

A single GPIO pin opened from a `GpioController`. Configure the direction with `SetDriveMode(GpioPinDriveMode)`, then drive it with `Write(GpioPinValue)` or sample it with `Read`. Subscribe to `ValueChanged` for edge-triggered notifications on inputs.

```csharp
public class GpioPin : IDisposable
```

## Properties

### PinNumber

```csharp
public int PinNumber { get; }
```

The controller-relative pin index this object represents.

### Controller

```csharp
public GpioController Controller { get; }
```

The `GpioController` that owns this pin.

### DebounceTimeout

```csharp
public TimeSpan DebounceTimeout { get; set; }
```

Debounce window applied before `ValueChanged` fires. Transitions shorter than this duration are suppressed.

### ValueChangedEdge

```csharp
public GpioPinEdge ValueChangedEdge { get; set; }
```

Selects which edges raise `ValueChanged`. Defaults to both rising and falling. Updates take effect immediately if a handler is attached.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the pin so another caller can open it.

### IsDriveModeSupported(GpioPinDriveMode mode)

```csharp
public bool IsDriveModeSupported(GpioPinDriveMode mode)
```

Tests whether a given drive mode is supported on this pin.

| Parameter | Type | Description |
|---|---|---|
| `mode` | `GpioPinDriveMode` | The drive mode to test. |

**Returns** `bool` — True if the pin can be configured with the given mode.

### IsDriveModeSupported(int pin, GpioPinDriveMode mode)

```csharp
public bool IsDriveModeSupported(int pin, GpioPinDriveMode mode)
```

Obsolete. The `pin` argument is ignored — the pin's own `PinNumber` is used. Call the no-pin overload instead.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Ignored. |
| `mode` | `GpioPinDriveMode` | The drive mode to test. |

**Returns** `bool` — True if the pin can be configured with the given mode.

### GetDriveMode()

```csharp
public GpioPinDriveMode GetDriveMode()
```

Returns the pin's currently configured drive mode.

**Returns** `GpioPinDriveMode`

### SetDriveMode(GpioPinDriveMode value)

```csharp
public void SetDriveMode(GpioPinDriveMode value)
```

Configures the pin's electrical drive mode.

| Parameter | Type | Description |
|---|---|---|
| `value` | `GpioPinDriveMode` | New drive mode. Must be supported on this pin (see `IsDriveModeSupported(GpioPinDriveMode)`). |

### Read()

```csharp
public GpioPinValue Read()
```

Samples the pin and returns the current logical level.

**Returns** `GpioPinValue` — The pin's present `GpioPinValue`.

### Write(GpioPinValue value)

```csharp
public void Write(GpioPinValue value)
```

Drives an output pin to the specified level. No effect on input modes.

| Parameter | Type | Description |
|---|---|---|
| `value` | `GpioPinValue` | The logical level to drive. |

### Toggle()

```csharp
public void Toggle()
```

Inverts the pin's current output level. Equivalent to reading the current state and writing its opposite.

## Events

### ValueChanged

```csharp
public event GpioPinValueChangedEventHandler ValueChanged
```

Raised when the pin transitions on an edge selected by `ValueChangedEdge`. The handler runs on the driver's event thread — keep it short and avoid blocking.
