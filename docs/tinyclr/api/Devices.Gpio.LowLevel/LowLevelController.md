---
title: "LowLevelController Class"
sidebar_label: "LowLevelController"
---

# LowLevelController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`

Low-level pin-mux helper. Lets a driver re-route or reconfigure pins at a level finer than the regular `GpioPin` API (slew rate, alternate function, etc.). Mostly used by peripheral library authors; ordinary apps don't need this.

```csharp
static public class LowLevelController
```

## Methods

### TransferFeature(int pinSource, int pinDestination, Settings settings)

```csharp
public static void TransferFeature(int pinSource, int pinDestination, Settings settings)
```

Applies a low-level pin-mux configuration moving `pinSource`'s signal to `pinDestination`.

| Parameter | Type | Description |
|---|---|---|
| `pinSource` | `int` | Source pin index. |
| `pinDestination` | `int` | Destination pin index. |
| `settings` | `Settings` | Mode, type, pulls, speed, and alternate function. |
