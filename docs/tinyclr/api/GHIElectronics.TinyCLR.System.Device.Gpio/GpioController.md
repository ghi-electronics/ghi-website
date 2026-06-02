---
title: "GpioController Class"
sidebar_label: "GpioController"
---

# GpioController Class

**Namespace:** `System.Device.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.System.Device.Gpio`

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

| Parameter | Type | Description |
|---|---|---|
| `numberingScheme` | `PinNumberingScheme` |  |

### GpioController(PinNumberingScheme numberingScheme, GpioDriver driver)

```csharp
public GpioController(PinNumberingScheme numberingScheme, GpioDriver driver)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `numberingScheme` | `PinNumberingScheme` |  |
| `driver` | `GpioDriver` |  |

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

Total number of pins exposed by this controller. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### OpenPin(int pinNumber)

```csharp
public void OpenPin(int pinNumber)
```

Acquires exclusive access to the specified pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

### OpenPin(int pinNumber, PinMode mode)

```csharp
public void OpenPin(int pinNumber, PinMode mode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `mode` | `PinMode` |  |

### OpenPin(int pinNumber, PinMode mode, PinValue initialValue)

```csharp
public void OpenPin(int pinNumber, PinMode mode, PinValue initialValue)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `mode` | `PinMode` |  |
| `initialValue` | `PinValue` |  |

### IsPinOpen(int pinNumber)

```csharp
public bool IsPinOpen(int pinNumber)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

**Returns** `bool`

### ClosePin(int pinNumber)

```csharp
public void ClosePin(int pinNumber)
```

Releases a previously opened pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

### GetPinMode(int pinNumber)

```csharp
public PinMode GetPinMode(int pinNumber)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

**Returns** `PinMode`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
public void SetPinMode(int pinNumber, PinMode mode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `mode` | `PinMode` |  |

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
public bool IsPinModeSupported(int pinNumber, PinMode mode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `mode` | `PinMode` |  |

**Returns** `bool`

### Read(int pinNumber)

```csharp
public PinValue Read(int pinNumber)
```

Read the data from internal buffer _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
public void Write(int pinNumber, PinValue value)
```

Writes one block at the given block index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `value` | `PinValue` |  |

### RegisterCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
public void RegisterCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `eventTypes` | `PinEventTypes` |  |
| `callback` | `PinChangeEventHandler` |  |

### UnregisterCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
public void UnregisterCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `callback` | `PinChangeEventHandler` |  |
