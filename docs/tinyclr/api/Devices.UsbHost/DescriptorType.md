---
title: "DescriptorType Enum"
sidebar_label: "DescriptorType"
---

# DescriptorType Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors`

The possible types of descriptors.

```csharp
public enum DescriptorType : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Device` | `0x01` | The device descriptor type. |
| `Configuration` | `0x02` | The configuration descriptor type. |
| `String` | `0x03` | The string descriptor type. |
| `Interface` | `0x04` | The interface descriptor type. |
| `Endpoint` | `0x05` | The endpoint descriptor type. |
