---
title: "PortMode Enum"
sidebar_label: "PortMode"
---

# PortMode Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`

What role the pin plays in the chip's pin-mux fabric.

```csharp
public enum PortMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `GpioInput` | `0` | Plain GPIO input. |
| `GpioOutput` | `1` | Plain GPIO output. |
| `AlternateFunction` | `2` | Routed to a peripheral (UART/SPI/I2C/...) selected by `AlternateFunction`. |
| `Analog` | `3` | Pin disconnected from digital logic, used by ADC/DAC. |
