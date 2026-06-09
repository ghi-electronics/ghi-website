---
title: "FormatKind Enum"
sidebar_label: "FormatKind"
---

# FormatKind Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The on-the-wire pixel encoding for a UVC stream.

```csharp
public enum FormatKind : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Yuy2` | `0` | Uncompressed 4:2:2 packed (YUYV). Streamable; converted to RGB565 on the device. |
| `Mjpeg` | `1` | Motion-JPEG. Currently enumerated only; streaming returns NotSupported until a JPEG decoder is wired in. |
