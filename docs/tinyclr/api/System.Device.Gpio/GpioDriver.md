---
title: "GpioDriver Class"
sidebar_label: "GpioDriver"
---

# GpioDriver Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `System.Device.Gpio`<br/>**Namespace:** `System.Device.Gpio`

Abstract GPIO driver per .NET IoT. Implemented by `TinyClrGpioDriver` for TinyCLR hardware.

```csharp
public abstract class GpioDriver : IDisposable
```

## Properties

### PinCount

```csharp
public abstract int PinCount { get; }
```

Number of pins the driver exposes.

## Methods

### OpenPin(int pinNumber)

```csharp
protected internal abstract void OpenPin(int pinNumber)
```

Opens the pin for use.

### ClosePin(int pinNumber)

```csharp
protected internal abstract void ClosePin(int pinNumber)
```

Closes the pin.

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
protected internal abstract bool IsPinModeSupported(int pinNumber, PinMode mode)
```

Returns true if the pin supports the given mode.

**Returns** `bool`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
protected internal abstract void SetPinMode(int pinNumber, PinMode mode)
```

Sets the pin's drive mode.

### GetPinMode(int pinNumber)

```csharp
protected internal abstract PinMode GetPinMode(int pinNumber)
```

Gets the pin's drive mode.

**Returns** `PinMode`

### Read(int pinNumber)

```csharp
protected internal abstract PinValue Read(int pinNumber)
```

Reads the pin level.

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
protected internal abstract void Write(int pinNumber, PinValue value)
```

Writes the pin level.

### AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
protected internal abstract void AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

Registers a callback for edge changes on the pin.

### RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
protected internal abstract void RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

Removes a previously registered callback.

### Dispose()

```csharp
public abstract void Dispose()
```

Releases the driver and closes all pins.
