---
title: "GpioController Class"
sidebar_label: "GpioController"
---

# GpioController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`

Represents a GPIO controller — the hardware peripheral that owns a set of individually addressable pins. Use `GetDefault` to obtain the device's primary controller, then `OpenPin(int)` to acquire pins for input or output.

```csharp
public class GpioController : IDisposable
```

## Properties

### Provider

```csharp
public IGpioControllerProvider Provider { get; }
```

The low-level provider backing this controller.

## Methods

### GetDefault()

```csharp
public static GpioController GetDefault()
```

Returns the default GPIO controller for this device.

**Returns** `GpioController`

### FromName(string name)

```csharp
public static GpioController FromName(string name)
```

Returns a GPIO controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Native API name (e.g. one of the platform-specific Pin map constants). |

**Returns** `GpioController`

### FromProvider(IGpioControllerProvider provider)

```csharp
public static GpioController FromProvider(IGpioControllerProvider provider)
```

Creates a controller from a custom `IGpioControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IGpioControllerProvider` | Provider implementing the pin operations. |

**Returns** `GpioController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider and any pins it still holds open.

### OpenPin(int pinNumber)

```csharp
public GpioPin OpenPin(int pinNumber)
```

Opens a single pin for input or output.

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` | Controller-relative pin index. |

**Returns** `GpioPin` — A `GpioPin` bound to this controller; dispose it to release the pin.

### OpenPins(params int[] pinNumbers)

```csharp
public GpioPin[] OpenPins(params int[] pinNumbers)
```

Opens multiple pins atomically. If any pin fails to open, every pin already opened by this call is disposed and the original exception is rethrown.

| Parameter | Type | Description |
|---|---|---|
| `pinNumbers` | `params int[]` | Controller-relative pin indices. |

**Returns** `GpioPin[]` — An array of opened pins in the same order as `pinNumbers`.

### TryOpenPin(int pinNumber, out GpioPin pin)

```csharp
public bool TryOpenPin(int pinNumber, out GpioPin pin)
```

Non-throwing version of `OpenPin(int)`.

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` | Controller-relative pin index. |
| `pin` | `out GpioPin` | Receives the opened pin on success; null on failure. |

**Returns** `bool` — True if the pin was opened; false if it was unavailable or in use.

### TryOpenPins(out GpioPin[] pins, params int[] pinNumbers)

```csharp
public bool TryOpenPins(out GpioPin[] pins, params int[] pinNumbers)
```

Non-throwing batch version of `OpenPins(int[])`.

| Parameter | Type | Description |
|---|---|---|
| `pins` | `out GpioPin[]` | Receives the opened pins on success; null on failure. |
| `pinNumbers` | `params int[]` | Controller-relative pin indices. |

**Returns** `bool` — True if every pin opened; false if any one failed (in which case no pins remain open).
