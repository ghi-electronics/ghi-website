---
title: "Format Class"
sidebar_label: "Format"
---

# Format Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

A camera-supported video format / resolution combination.

```csharp
public class Format
```

## Properties

### Width

```csharp
public int Width { get; set; }
```

Frame width in pixels.

### Height

```csharp
public int Height { get; set; }
```

Frame height in pixels.

### Kind

```csharp
public FormatKind Kind { get; }
```

The pixel encoding (YUY2 or MJPEG).
