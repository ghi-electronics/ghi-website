---
title: "DeviceConnectionStatus Enum"
sidebar_label: "DeviceConnectionStatus"
---

# DeviceConnectionStatus Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The connection status of a USB device.

```csharp
public enum DeviceConnectionStatus
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Disconnected` | `0` | The device has been disconnected. |
| `Connected` | `1` | The device has been connected. |
| `Bad` | `2` | The device was connected but is not functioning correctly. |
