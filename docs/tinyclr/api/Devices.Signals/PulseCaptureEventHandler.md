---
title: "PulseCaptureEventHandler Delegate"
sidebar_label: "PulseCaptureEventHandler"
---

# PulseCaptureEventHandler Delegate

**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`

Handler for `OnCaptureFinished`.

```csharp
public delegate void PulseCaptureEventHandler(DigitalSignal sender, double[] buffer, uint count, GpioPinValue initialState);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `DigitalSignal` |  |
| `buffer` | `double[]` |  |
| `count` | `uint` |  |
| `initialState` | `GpioPinValue` |  |
