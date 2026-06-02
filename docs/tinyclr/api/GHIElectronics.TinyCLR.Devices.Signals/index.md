---
title: "GHIElectronics.TinyCLR.Devices.Signals"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Signals

NuGet package containing **8** types.

## Classes

| Class | Summary |
|---|---|
| [DigitalSignal](./DigitalSignal.md) | DMA/timer-backed pulse-train I/O on a small set of pins. Capable of pulse counting (`ReadPulse`), high-resolution edge capture (`Capture`), and emitting pulse-width-modulated sequences (`Generate`). All three operations are mutually exclusive and run asynchronously — completion is reported via `OnReadPulseFinished` / `OnCaptureFinished` / `OnGenerateFinished`. Only specific pins are supported (currently 0, 1, and 19). |
| [PulseFeedback](./PulseFeedback.md) | Generates a digital pulse on one pin and measures a pulse-related duration on the same pin or a separate echo pin. Common applications: ultrasonic distance sensors (HC-SR04), 1-wire interrogation, capacitive touch. |
| [SignalCapture](./SignalCapture.md) | Samples a digital input and records the durations between successive edges — the inverse of `SignalGenerator`. Useful for capturing IR-remote codes, decoding bit-banged protocols, or measuring pulse widths. |
| [SignalGenerator](./SignalGenerator.md) | Drives a pin through a precise sequence of high/low transitions. Suitable for generating IR-remote waveforms, addressable-LED streams (WS281x), and other strict-timing protocols. Optional carrier-frequency modulation is available for IR. |

## Enums

| Enum | Summary |
|---|---|
| [PulseFeedbackMode](./PulseFeedbackMode.md) | How a `PulseFeedback` session is driven. |

## Delegates

| Delegate | Summary |
|---|---|
| [PulseCaptureEventHandler](./PulseCaptureEventHandler.md) | Handler for `OnCaptureFinished`. |
| [PulseGenerateEventHandler](./PulseGenerateEventHandler.md) | Handler for `OnGenerateFinished`. |
| [PulseReadEventHandler](./PulseReadEventHandler.md) | Handler for `OnReadPulseFinished`. |
