---
title: "GpioControllerApiWrapper Class"
sidebar_label: "GpioControllerApiWrapper"
---

# GpioControllerApiWrapper Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`

Concrete `IGpioControllerProvider` backed by the native TinyCLR GPIO HAL. Constructed internally by `GpioController`; you don't normally need to use this type directly.

```csharp
public sealed class GpioControllerApiWrapper : IGpioControllerProvider
```

## Constructors

### GpioControllerApiWrapper(NativeApi api)

```csharp
public GpioControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` | The native GPIO API to bind to. |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### PinCount

```csharp
public extern int PinCount { get; }
```

Total number of pins exposed by this controller. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### OpenPin(int pin)

```csharp
public extern void OpenPin(int pin)
```

Acquires exclusive access to the specified pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

### ClosePin(int pin)

```csharp
public extern void ClosePin(int pin)
```

Releases a previously opened pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

### GetDebounceTimeout(int pin)

```csharp
public extern TimeSpan GetDebounceTimeout(int pin)
```

Returns the pin's current debounce window. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

**Returns** `TimeSpan`

### SetDebounceTimeout(int pin, TimeSpan value)

```csharp
public extern void SetDebounceTimeout(int pin, TimeSpan value)
```

Sets the pin's debounce window. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `value` | `TimeSpan` | Minimum stable interval before an edge is reported. |

### GetDriveMode(int pin)

```csharp
public extern GpioPinDriveMode GetDriveMode(int pin)
```

Returns the pin's currently configured drive mode. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

**Returns** `GpioPinDriveMode`

### SetDriveMode(int pin, GpioPinDriveMode value)

```csharp
public extern void SetDriveMode(int pin, GpioPinDriveMode value)
```

Configures the pin's drive mode. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `value` | `GpioPinDriveMode` | Drive mode to apply. |

### Read(int pin)

```csharp
public extern GpioPinValue Read(int pin)
```

Read the data from internal buffer _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` |  |

**Returns** `GpioPinValue`

### Write(int pin, GpioPinValue value)

```csharp
public extern void Write(int pin, GpioPinValue value)
```

Writes one block at the given block index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` |  |
| `value` | `GpioPinValue` |  |

### IsDriveModeSupported(int pin, GpioPinDriveMode mode)

```csharp
public extern bool IsDriveModeSupported(int pin, GpioPinDriveMode mode)
```

Tests whether the pin supports a given drive mode. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `mode` | `GpioPinDriveMode` | The drive mode to test. |

**Returns** `bool` — True if the mode is supported on that pin.

### SetPinChangedHandler(int pin, GpioPinEdge edge, GpioPinValueChangedEventHandler value)

```csharp
public void SetPinChangedHandler(int pin, GpioPinEdge edge, GpioPinValueChangedEventHandler value)
```

Installs or replaces the edge-change handler for a pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |
| `edge` | `GpioPinEdge` | Which edges should raise the event. |
| `value` | `GpioPinValueChangedEventHandler` | Delegate to invoke on a matching edge. |

### ClearPinChangedHandler(int pin)

```csharp
public void ClearPinChangedHandler(int pin)
```

Removes any previously installed edge-change handler. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pin` | `int` | Controller-relative pin index. |

### TransferFeature(int pinSource, int pinDestination, uint mode, uint type, uint direction, uint speed, uint alternate)

```csharp
public extern void TransferFeature(int pinSource, int pinDestination, uint mode, uint type, uint direction, uint speed, uint alternate)
```

Re-routes a pin's signal through the controller's alternate-function fabric. Advanced; used by peripheral drivers (UART/SPI/I2C/etc.) to claim package pins. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinSource` | `int` | Source pin index. |
| `pinDestination` | `int` | Destination pin index. |
| `mode` | `uint` | Platform-specific mode bits. |
| `type` | `uint` | Platform-specific type bits. |
| `direction` | `uint` | Platform-specific direction bits. |
| `speed` | `uint` | Platform-specific speed/slew bits. |
| `alternate` | `uint` | Alternate-function index. |
