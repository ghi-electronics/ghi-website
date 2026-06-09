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

Total number of pins exposed by this controller. _(inherited)_

## Methods

### OpenPin(int pinNumber)

```csharp
protected internal abstract void OpenPin(int pinNumber)
```

Acquires exclusive access to the specified pin. _(inherited)_

### ClosePin(int pinNumber)

```csharp
protected internal abstract void ClosePin(int pinNumber)
```

Releases a previously opened pin. _(inherited)_

### IsPinModeSupported(int pinNumber, PinMode mode)

```csharp
protected internal abstract bool IsPinModeSupported(int pinNumber, PinMode mode)
```

_No description available._

**Returns** `bool`

### SetPinMode(int pinNumber, PinMode mode)

```csharp
protected internal abstract void SetPinMode(int pinNumber, PinMode mode)
```

_No description available._

### GetPinMode(int pinNumber)

```csharp
protected internal abstract PinMode GetPinMode(int pinNumber)
```

_No description available._

**Returns** `PinMode`

### Read(int pinNumber)

```csharp
protected internal abstract PinValue Read(int pinNumber)
```

Read the data from internal buffer _(inherited)_

**Returns** `PinValue`

### Write(int pinNumber, PinValue value)

```csharp
protected internal abstract void Write(int pinNumber, PinValue value)
```

Writes one block at the given block index. _(inherited)_

### AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)

```csharp
protected internal abstract void AddCallbackForPinValueChangedEvent(int pinNumber, PinEventTypes eventTypes, PinChangeEventHandler callback)
```

_No description available._

### RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)

```csharp
protected internal abstract void RemoveCallbackForPinValueChangedEvent(int pinNumber, PinChangeEventHandler callback)
```

_No description available._

### Dispose()

```csharp
public abstract void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
