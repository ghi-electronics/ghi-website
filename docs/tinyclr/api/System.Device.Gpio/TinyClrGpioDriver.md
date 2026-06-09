---
title: "TinyClrGpioDriver Class"
sidebar_label: "TinyClrGpioDriver"
---

# TinyClrGpioDriver Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `System.Device.Gpio`<br/>**Namespace:** `System.Device.Gpio`

TinyCLR-backed implementation of `GpioDriver`. Routes `GpioController` calls to `GHIElectronics.TinyCLR.Devices.Gpio.GpioController`.

```csharp
public class TinyClrGpioDriver : GpioDriver
```

## Constructors

### TinyClrGpioDriver()

```csharp
public TinyClrGpioDriver() : this(GHIElectronics.TinyCLR.Devices.Gpio.GpioController.GetDefault(), 0)
```

_No description available._

### TinyClrGpioDriver(int pinBase)

```csharp
public TinyClrGpioDriver(int pinBase) : this(GHIElectronics.TinyCLR.Devices.Gpio.GpioController.GetDefault(), pinBase)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinBase` | `int` |  |

### TinyClrGpioDriver(GHIElectronics.TinyCLR.Devices.Gpio.GpioController tinyClrController, int pinBase)

```csharp
public TinyClrGpioDriver(GHIElectronics.TinyCLR.Devices.Gpio.GpioController tinyClrController, int pinBase = 0)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `tinyClrController` | `GHIElectronics.TinyCLR.Devices.Gpio.GpioController` |  |
| `pinBase` | `int` |  |

## Properties

### PinCount

```csharp
public override int PinCount { get; }
```

Total number of pins exposed by this controller. _(inherited)_

## Methods

### Dispose()

```csharp
public override void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### OpenPin(int pinNumber)

```csharp
protected internal override void OpenPin(int pinNumber)
```

Acquires exclusive access to the specified pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

### ClosePin(int pinNumber)

```csharp
protected internal override void ClosePin(int pinNumber)
```

Releases a previously opened pin. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
protected internal override bool IsPinModeSupported(int pinNumber, PinMode mode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `mode` | `PinMode` |  |

**Returns** `bool`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
protected internal override void SetPinMode(int pinNumber, PinMode mode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `mode` | `PinMode` |  |

### GetPinMode(int pinNumber)

```csharp
protected internal override PinMode GetPinMode(int pinNumber)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

**Returns** `PinMode`

### Read(int pinNumber)

```csharp
protected internal override PinValue Read(int pinNumber)
```

Read the data from internal buffer _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
protected internal override void Write(int pinNumber, PinValue value)
```

Writes one block at the given block index. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `value` | `PinValue` |  |

### AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
protected internal override void AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `eventTypes` | `PinEventTypes` |  |
| `callback` | `PinChangeEventHandler` |  |

### RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
protected internal override void RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |
| `callback` | `PinChangeEventHandler` |  |

### MapPinNumber(int pinNumber)

```csharp
protected virtual int MapPinNumber(int pinNumber)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` |  |

**Returns** `int`
