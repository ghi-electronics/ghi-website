---
title: "PulseReadEventHandler Delegate"
sidebar_label: "PulseReadEventHandler"
---

# PulseReadEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals`

Handler for `OnReadPulseFinished`.

```csharp
public delegate void PulseReadEventHandler(DigitalSignal sender, TimeSpan duration, uint count, GpioPinValue initialState);
```
