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

### TinyClrGpioDriver(GHIElectronics.TinyCLR.Devices.Gpio.GpioController tinyClrController, int pinBase)

```csharp
public TinyClrGpioDriver(GHIElectronics.TinyCLR.Devices.Gpio.GpioController tinyClrController, int pinBase = 0)
```

_No description available._

## Properties

### PinCount

```csharp
public override int PinCount { get; }
```

_No description available._

## Methods

### Dispose()

```csharp
public override void Dispose()
```

_No description available._

### OpenPin(int pinNumber)

```csharp
protected internal override void OpenPin(int pinNumber)
```

_No description available._

### ClosePin(int pinNumber)

```csharp
protected internal override void ClosePin(int pinNumber)
```

_No description available._

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
protected internal override bool IsPinModeSupported(int pinNumber, PinMode mode)
```

_No description available._

**Returns** `bool`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
protected internal override void SetPinMode(int pinNumber, PinMode mode)
```

_No description available._

### GetPinMode(int pinNumber)

```csharp
protected internal override PinMode GetPinMode(int pinNumber)
```

_No description available._

**Returns** `PinMode`

### Read(int pinNumber)

```csharp
protected internal override PinValue Read(int pinNumber)
```

_No description available._

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
protected internal override void Write(int pinNumber, PinValue value)
```

_No description available._

### AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
protected internal override void AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

_No description available._

### RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
protected internal override void RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

_No description available._

### MapPinNumber(int pinNumber)

```csharp
protected virtual int MapPinNumber(int pinNumber)
```

_No description available._

**Returns** `int`
