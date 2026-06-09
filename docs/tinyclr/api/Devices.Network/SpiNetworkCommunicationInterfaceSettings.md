---
title: "SpiNetworkCommunicationInterfaceSettings Class"
sidebar_label: "SpiNetworkCommunicationInterfaceSettings"
---

# SpiNetworkCommunicationInterfaceSettings Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Network` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Network`

Settings for an external SPI-attached network controller (chip select, reset, interrupt pins, SPI mode).

```csharp
public class SpiNetworkCommunicationInterfaceSettings : NetworkCommunicationInterfaceSettings
```

## Properties

### SpiApiName

```csharp
public string SpiApiName { get; set; }
```

Native API name of the SPI controller to use.

### SpiSettings

```csharp
public SpiConnectionSettings SpiSettings { get; set; }
```

SPI clock and mode settings.

### GpioApiName

```csharp
public string GpioApiName { get; set; }
```

Native API name of the GPIO controller owning the reset/interrupt pins.

### ResetPin

```csharp
public GpioPin ResetPin { get; set; }
```

Pin used to reset the external controller.

### ResetActiveState

```csharp
public GpioPinValue ResetActiveState { get; set; }
```

Level that drives the chip into reset.

### InterruptPin

```csharp
public GpioPin InterruptPin { get; set; }
```

Pin the external controller uses to signal interrupts.

### InterruptEdge

```csharp
public GpioPinEdge InterruptEdge { get; set; }
```

Edge of the interrupt signal that fires an event.

### InterruptDriveMode

```csharp
public GpioPinDriveMode InterruptDriveMode { get; set; }
```

Drive mode applied to the interrupt pin.
