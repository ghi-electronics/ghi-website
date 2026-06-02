---
title: "OutputType Enum"
sidebar_label: "OutputType"
---

# OutputType Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio.LowLevel`

How a GPIO pin's output driver is wired.

```csharp
public enum OutputType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `PushPull` | `0` | Driver actively drives both high and low. |
| `OpenDrain` | `1` | Driver actively pulls low and floats when set high (use with a pull-up). |
