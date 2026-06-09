---
title: "GHIElectronics.TinyCLR.Devices.Signals"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Signals NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [DigitalSignal](./DigitalSignal.md) | `GHIElectronics.TinyCLR.Devices.Signals` | DMA/timer-backed pulse-train I/O on a small set of pins. Capable of pulse counting (`ReadPulse`), high-resolution edge capture (`Capture`), and emitting pulse-width-modulated sequences (`Generate`). All three operations are mutually exclusive and run asynchronously — completion is reported via `OnReadPulseFinished` / `OnCaptureFinished` / `OnGenerateFinished`. Only specific pins are supported (currently 0, 1, and 19). |
| [PulseFeedback](./PulseFeedback.md) | `GHIElectronics.TinyCLR.Devices.Signals` | Generates a digital pulse on one pin and measures a pulse-related duration on the same pin or a separate echo pin. Common applications: ultrasonic distance sensors (HC-SR04), 1-wire interrogation, capacitive touch. |
| [SignalCapture](./SignalCapture.md) | `GHIElectronics.TinyCLR.Devices.Signals` | Samples a digital input and records the durations between successive edges — the inverse of `SignalGenerator`. Useful for capturing IR-remote codes, decoding bit-banged protocols, or measuring pulse widths. |
| [SignalGenerator](./SignalGenerator.md) | `GHIElectronics.TinyCLR.Devices.Signals` | Drives a pin through a precise sequence of high/low transitions. Suitable for generating IR-remote waveforms, addressable-LED streams (WS281x), and other strict-timing protocols. Optional carrier-frequency modulation is available for IR. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [PulseFeedbackMode](./PulseFeedbackMode.md) | `GHIElectronics.TinyCLR.Devices.Signals` | How a `PulseFeedback` session is driven. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [PulseCaptureEventHandler](./PulseCaptureEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Signals` | Handler for `OnCaptureFinished`. |
| [PulseGenerateEventHandler](./PulseGenerateEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Signals` | Handler for `OnGenerateFinished`. |
| [PulseReadEventHandler](./PulseReadEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Signals` | Handler for `OnReadPulseFinished`. |
