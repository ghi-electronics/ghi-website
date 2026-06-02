---
title: "GpioPinValueChangedEventHandler Delegate"
sidebar_label: "GpioPinValueChangedEventHandler"
---

# GpioPinValueChangedEventHandler Delegate

**Namespace:** `GHIElectronics.TinyCLR.Devices.Gpio` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Gpio`

Handler invoked when a `GpioPin` configured as an input observes a level change matching its `GpioPin.ValueChangedEdge`.

```csharp
public delegate void GpioPinValueChangedEventHandler(GpioPin sender, GpioPinValueChangedEventArgs e);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `GpioPin` | The pin that detected the edge. |
| `e` | `GpioPinValueChangedEventArgs` | Edge direction and timestamp captured by the driver. |
