---
title: "DisplayController Class"
sidebar_label: "DisplayController"
---

# DisplayController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Display`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Display`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Display`

Represents the framebuffer / panel controller. After supplying timing via `SetConfiguration(DisplayControllerSettings)` and calling `Enable`, push pixels with `DrawBuffer` / `DrawPixel` — or mount the controller into the higher-level drawing/UI stack via `Hdc`.

```csharp
public class DisplayController : IDisposable
```

## Properties

### Provider

```csharp
public IDisplayControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### Hdc

```csharp
public IntPtr Hdc { get; }
```

Native handle (HDC) for use with the drawing/UI stack.

### ActiveConfiguration

```csharp
public DisplayControllerSettings ActiveConfiguration { get; set; }
```

The settings most recently applied via `SetConfiguration(DisplayControllerSettings)`.

## Methods

### GetDefault()

```csharp
public static DisplayController GetDefault()
```

Returns the default display controller for this device.

**Returns** `DisplayController`

### FromName(string name)

```csharp
public static DisplayController FromName(string name)
```

Returns a display controller identified by its native API name.

**Returns** `DisplayController`

### FromProvider(IDisplayControllerProvider provider)

```csharp
public static DisplayController FromProvider(IDisplayControllerProvider provider)
```

Creates a controller from a custom `IDisplayControllerProvider`.

**Returns** `DisplayController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### Enable()

```csharp
public void Enable()
```

Powers on the panel and the timing engine.

### Disable()

```csharp
public void Disable()
```

Powers off the panel.

### DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)

```csharp
public void DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)
```

Blits a rectangular region of an off-screen buffer to the panel.

| Parameter | Type | Description |
|---|---|---|
| `targetX` | `int` | Destination left edge. |
| `targetY` | `int` | Destination top edge. |
| `sourceX` | `int` | Source-buffer left edge. |
| `sourceY` | `int` | Source-buffer top edge. |
| `width` | `int` | Width of the region in pixels. |
| `height` | `int` | Height of the region in pixels. |
| `originalWidth` | `int` | Width of the full source buffer in pixels. |
| `data` | `byte[]` | Pixel data (RGB565 byte pairs). |
| `offset` | `int` | Starting offset within `data`. |

### DrawPixel(int x, int y, long color)

```csharp
public void DrawPixel(int x, int y, long color)
```

Sets a single pixel.

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` | X coordinate. |
| `y` | `int` | Y coordinate. |
| `color` | `long` | Pixel color in the active `DisplayDataFormat`. |

### DrawString(string value)

```csharp
public void DrawString(string value)
```

Renders a string via the controller's built-in text mode (where supported).

### SetConfiguration(DisplayControllerSettings configuration)

```csharp
public void SetConfiguration(DisplayControllerSettings configuration)
```

Applies a display configuration (timing, size, orientation, color format).

| Parameter | Type | Description |
|---|---|---|
| `configuration` | `DisplayControllerSettings` | A concrete settings instance — pass a `ParallelDisplayControllerSettings` for parallel RGB panels. |
