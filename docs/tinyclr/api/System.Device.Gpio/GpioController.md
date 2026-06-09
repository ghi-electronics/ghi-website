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

_No description available._

### GpioController(PinNumberingScheme numberingScheme)

```csharp
public GpioController(PinNumberingScheme numberingScheme) : this(numberingScheme, new TinyClrGpioDriver())
```

_No description available._

### GpioController(PinNumberingScheme numberingScheme, GpioDriver driver)

```csharp
public GpioController(PinNumberingScheme numberingScheme, GpioDriver driver)
```

_No description available._

## Properties

### Driver

```csharp
public GpioDriver Driver { get; }
```

_No description available._

### NumberingScheme

```csharp
public PinNumberingScheme NumberingScheme { get; }
```

_No description available._

### PinCount

```csharp
public int PinCount { get; }
```

_No description available._

## Methods

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### OpenPin(int pinNumber)

```csharp
public void OpenPin(int pinNumber)
```

_No description available._

### OpenPin(int pinNumber, PinMode mode)

```csharp
public void OpenPin(int pinNumber, PinMode mode)
```

_No description available._

### OpenPin(int pinNumber, PinMode mode, PinValue initialValue)

```csharp
public void OpenPin(int pinNumber, PinMode mode, PinValue initialValue)
```

_No description available._

### IsPinOpen(int pinNumber)

```csharp
public bool IsPinOpen(int pinNumber)
```

_No description available._

**Returns** `bool`

### ClosePin(int pinNumber)

```csharp
public void ClosePin(int pinNumber)
```

_No description available._

### GetPinMode(int pinNumber)

```csharp
public PinMode GetPinMode(int pinNumber)
```

_No description available._

**Returns** `PinMode`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
public void SetPinMode(int pinNumber, PinMode mode)
```

_No description available._

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
public bool IsPinModeSupported(int pinNumber, PinMode mode)
```

_No description available._

**Returns** `bool`

### Read(int pinNumber)

```csharp
public PinValue Read(int pinNumber)
```

_No description available._

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
public void Write(int pinNumber, PinValue value)
```

_No description available._

### RegisterCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
public void RegisterCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

_No description available._

### UnregisterCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
public void UnregisterCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

_No description available._

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
