---
title: "PID Enum"
sidebar_label: "PID"
---

# PID Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

The default product ids for each built-in device type.

```csharp
public enum PID : ushort
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Mouse` | `0xF000` | The product id for a mouse. |
| `CDC` | `0xF001` | The product id for a CDC virtual COM port. |
| `MassStorage` | `0xF002` | The product id for a mass storage device. |
| `Keyboard` | `0xF004` | The product id for a keyboard. |
| `Joystick` | `0xF005` | The product id for a joystick. |
| `WinUsb` | `0xF006` | The product id for a WinUsb device. |
| `RawDevice` | `0xF007` | The product id for a raw device. |
