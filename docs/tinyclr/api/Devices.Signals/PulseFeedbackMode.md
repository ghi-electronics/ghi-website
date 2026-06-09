---
title: "PulseFeedbackMode Enum"
sidebar_label: "PulseFeedbackMode"
---

# PulseFeedbackMode Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Signals`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Signals`

How a `PulseFeedback` session is driven.

```csharp
public enum PulseFeedbackMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `DrainDuration` |  | Measure the time the pin takes to be pulled back to its idle state on a single shared pin. |
| `EchoDuration` |  | Drive a pulse on one pin, then measure the duration of the echo pulse on a separate pin (e.g. ultrasonic ECHO). |
| `DurationUntilEcho` |  | Drive a pulse on one pin, then measure how long it takes the echo pin to respond (e.g. distance-sensor TOF). |
