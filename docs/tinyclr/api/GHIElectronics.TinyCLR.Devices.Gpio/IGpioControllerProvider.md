---
title: "IGpioControllerProvider Interface"
sidebar_label: "IGpioControllerProvider"
---

# IGpioControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`

Provider contract for a GPIO controller. Most users call `GpioController` / `GpioPin` directly; implement this interface only when supplying a custom or virtual controller.

```csharp
public interface IGpioControllerProvider : IDisposable
```

## Properties

### PinCount

```csharp
int PinCount { get; }
```

Total number of pins exposed by this controller.

## Methods

### OpenPin(int pin)

```csharp
void OpenPin(int pin)
```

Acquires exclusive access to the specified pin.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

### ClosePin(int pin)

```csharp
void ClosePin(int pin)
```

Releases a previously opened pin.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

### IsDriveModeSupported(int pin, GpioPinDriveMode mode)

```csharp
bool IsDriveModeSupported(int pin, GpioPinDriveMode mode)
```

Tests whether the pin supports a given drive mode.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `mode` | `GpioPinDriveMode` | The drive mode to test. |

**Returns** `bool` — True if the mode is supported on that pin.

### SetPinChangedHandler(int pin, GpioPinEdge edge, GpioPinValueChangedEventHandler value)

```csharp
void SetPinChangedHandler(int pin, GpioPinEdge edge, GpioPinValueChangedEventHandler value)
```

Installs or replaces the edge-change handler for a pin.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `edge` | `GpioPinEdge` | Which edges should raise the event. |
| `value` | `GpioPinValueChangedEventHandler` | Delegate to invoke on a matching edge. |

### ClearPinChangedHandler(int pin)

```csharp
void ClearPinChangedHandler(int pin)
```

Removes any previously installed edge-change handler.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

### GetDebounceTimeout(int pin)

```csharp
TimeSpan GetDebounceTimeout(int pin)
```

Returns the pin's current debounce window.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

**Returns** `TimeSpan`

### SetDebounceTimeout(int pin, TimeSpan value)

```csharp
void SetDebounceTimeout(int pin, TimeSpan value)
```

Sets the pin's debounce window.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `value` | `TimeSpan` | Minimum stable interval before an edge is reported. |

### GetDriveMode(int pin)

```csharp
GpioPinDriveMode GetDriveMode(int pin)
```

Returns the pin's currently configured drive mode.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

**Returns** `GpioPinDriveMode`

### SetDriveMode(int pin, GpioPinDriveMode value)

```csharp
void SetDriveMode(int pin, GpioPinDriveMode value)
```

Configures the pin's drive mode.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `value` | `GpioPinDriveMode` | Drive mode to apply. |

### Read(int pin)

```csharp
GpioPinValue Read(int pin)
```

Samples the pin and returns its current logical level.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

**Returns** `GpioPinValue`

### Write(int pin, GpioPinValue value)

```csharp
void Write(int pin, GpioPinValue value)
```

Drives an output pin to the specified level.

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `value` | `GpioPinValue` | Level to drive. |

### TransferFeature(int pinSource, int pinDestination, uint mode, uint type, uint direction, uint speed, uint alternate)

```csharp
void TransferFeature(int pinSource, int pinDestination, uint mode, uint type, uint direction, uint speed, uint alternate)
```

Re-routes a pin's signal through the controller's alternate-function fabric. Advanced; used by peripheral drivers (UART/SPI/I2C/etc.) to claim package pins.

| Parameter | Type | Description |
|---|---|---|
| `pinSource` | `int` | Source pin index. |
| `pinDestination` | `int` | Destination pin index. |
| `mode` | `uint` | Platform-specific mode bits. |
| `type` | `uint` | Platform-specific type bits. |
| `direction` | `uint` | Platform-specific direction bits. |
| `speed` | `uint` | Platform-specific speed/slew bits. |
| `alternate` | `uint` | Alternate-function index. |
