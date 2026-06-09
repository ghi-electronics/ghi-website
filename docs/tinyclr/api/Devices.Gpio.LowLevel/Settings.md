---
title: "Settings Class"
sidebar_label: "Settings"
---

# Settings Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`

Bundle of low-level pin settings passed to `LowLevelController.TransferFeature`.

```csharp
public class Settings
```

## Fields

### mode

```csharp
public PortMode mode
```

Pin role (GPIO input/output, alternate function, analog).

### type

```csharp
public OutputType type
```

Output driver type.

### driveDirection

```csharp
public PullDirection driveDirection
```

Pull-resistor selection.

### speed

```csharp
public OutputSpeed speed
```

Output speed / drive strength.

### alternate

```csharp
public AlternateFunction alternate
```

Alternate-function index when `mode` is `PortMode.AlternateFunction`.
