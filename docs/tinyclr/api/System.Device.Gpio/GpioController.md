---
title: "GpioController Class"
sidebar_label: "GpioController"
---

# GpioController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `System.Device.Gpio`<br/>**Namespace:** `System.Device.Gpio`

.NET IoT-style GPIO controller. Same surface as `System.Device.Gpio.GpioController`; internally routes through TinyCLR's GPIO HAL via `TinyClrGpioDriver`.

```csharp
public sealed class GpioController : IDisposable
```

## Constructors

### GpioController()

```csharp
public GpioController() : this(PinNumberingScheme.Logical, new TinyClrGpioDriver())
```

Creates a controller over the default TinyCLR GPIO driver.

### GpioController(PinNumberingScheme numberingScheme)

```csharp
public GpioController(PinNumberingScheme numberingScheme) : this(numberingScheme, new TinyClrGpioDriver())
```

Creates a controller with the given numbering scheme.

### GpioController(PinNumberingScheme numberingScheme, GpioDriver driver)

```csharp
public GpioController(PinNumberingScheme numberingScheme, GpioDriver driver)
```

Creates a controller with the given numbering scheme and driver.

## Properties

### Driver

```csharp
public GpioDriver Driver { get; }
```

The underlying driver.

### NumberingScheme

```csharp
public PinNumberingScheme NumberingScheme { get; }
```

How pin numbers are interpreted.

### PinCount

```csharp
public int PinCount { get; }
```

Number of pins on the controller.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Closes all open pins and releases the driver.

### OpenPin(int pinNumber)

```csharp
public void OpenPin(int pinNumber)
```

Opens the pin as an input.

### OpenPin(int pinNumber, PinMode mode)

```csharp
public void OpenPin(int pinNumber, PinMode mode)
```

Opens the pin in the given mode.

### OpenPin(int pinNumber, PinMode mode, PinValue initialValue)

```csharp
public void OpenPin(int pinNumber, PinMode mode, PinValue initialValue)
```

Opens the pin in the given mode and, for outputs, sets its initial level.

### IsPinOpen(int pinNumber)

```csharp
public bool IsPinOpen(int pinNumber)
```

Returns true if the pin is open.

**Returns** `bool`

### ClosePin(int pinNumber)

```csharp
public void ClosePin(int pinNumber)
```

Closes the pin.

### GetPinMode(int pinNumber)

```csharp
public PinMode GetPinMode(int pinNumber)
```

Gets the pin's drive mode.

**Returns** `PinMode`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
public void SetPinMode(int pinNumber, PinMode mode)
```

Sets the pin's drive mode.

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
public bool IsPinModeSupported(int pinNumber, PinMode mode)
```

Returns true if the pin supports the given mode.

**Returns** `bool`

### Read(int pinNumber)

```csharp
public PinValue Read(int pinNumber)
```

Reads the pin level.

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
public void Write(int pinNumber, PinValue value)
```

Writes the pin level.

### RegisterCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
public void RegisterCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

Registers a callback for edge changes on the pin.

### UnregisterCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
public void UnregisterCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

Removes a previously registered callback.

### WaitForEvent(int pinNumber, PinEventTypes eventTypes, TimeSpan timeout)

```csharp
public WaitForEventResult WaitForEvent(int pinNumber, PinEventTypes eventTypes, TimeSpan timeout)
```

Blocks until an edge of type `eventTypes` occurs on `pinNumber` or `timeout` elapses. The pin must already be open. Pass `Timeout.InfiniteTimeSpan` to wait indefinitely.

**Returns** `WaitForEventResult`

### WaitForEvent(int pinNumber, PinEventTypes eventTypes, CancellationToken cancellationToken)

```csharp
public WaitForEventResult WaitForEvent(int pinNumber, PinEventTypes eventTypes, CancellationToken cancellationToken)
```

Blocks until an edge of type `eventTypes` occurs on `pinNumber` or `cancellationToken` is cancelled. The pin must already be open. On cancellation the result has `WaitForEventResult.TimedOut` set to true.

**Returns** `WaitForEventResult`
