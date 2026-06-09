---
title: "LibGpiodDriver Class"
sidebar_label: "LibGpiodDriver"
---

# LibGpiodDriver Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio`<br/>**Assembly:** `System.Device.Gpio`<br/>**Namespace:** `System.Device.Gpio.Drivers`

Alias of `TinyClrGpioDriver` for source-compatibility with Linux .NET IoT samples that reference `LibGpiodDriver`.

```csharp
public sealed class LibGpiodDriver : System.Device.Gpio.TinyClrGpioDriver
```

## Constructors

### LibGpiodDriver(int chipNumber)

```csharp
public LibGpiodDriver(int chipNumber) : base(CalculatePinBase(chipNumber))
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `chipNumber` | `int` |  |

## Properties

### ChipNumber

```csharp
public int ChipNumber { get; }
```

_No description available._
