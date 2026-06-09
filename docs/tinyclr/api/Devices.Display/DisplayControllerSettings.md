---
title: "DisplayControllerSettings Class"
sidebar_label: "DisplayControllerSettings"
---

# DisplayControllerSettings Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Display` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Display`

Common settings for any display controller (size, color format, orientation).

```csharp
public class DisplayControllerSettings
```

## Properties

### Width

```csharp
public int Width { get; set; }
```

Panel width in pixels (before rotation).

### Height

```csharp
public int Height { get; set; }
```

Panel height in pixels (before rotation).

### DataFormat

```csharp
public DisplayDataFormat DataFormat { get; set; }
```

Pixel encoding.

### Orientation

```csharp
public DisplayOrientation Orientation { get; set; }
```

Logical screen rotation.
