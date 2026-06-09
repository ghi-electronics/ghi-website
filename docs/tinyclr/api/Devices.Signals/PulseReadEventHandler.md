---
title: "PulseReadEventHandler Delegate"
sidebar_label: "PulseReadEventHandler"
---

# PulseReadEventHandler Delegate

**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`

Handler for `OnReadPulseFinished`.

```csharp
public delegate void PulseReadEventHandler(DigitalSignal sender, TimeSpan duration, uint count, GpioPinValue initialState);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `DigitalSignal` |  |
| `duration` | `TimeSpan` |  |
| `count` | `uint` |  |
| `initialState` | `GpioPinValue` |  |
