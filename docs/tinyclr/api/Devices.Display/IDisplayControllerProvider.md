---
title: "IDisplayControllerProvider Interface"
sidebar_label: "IDisplayControllerProvider"
---

# IDisplayControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Display`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Display`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Display.Provider`

Provider contract for a display controller.

```csharp
public interface IDisplayControllerProvider : IDisposable
```

## Methods

### Enable()

```csharp
void Enable()
```

Powers on the panel.

### Disable()

```csharp
void Disable()
```

Powers off the panel.

### SetConfiguration(DisplayControllerSettings configuration)

```csharp
void SetConfiguration(DisplayControllerSettings configuration)
```

Applies a configuration.

### DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)

```csharp
void DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)
```

Blits a rectangle of pixel data to the panel.

### DrawPixel(int x, int y, long color)

```csharp
void DrawPixel(int x, int y, long color)
```

Sets a single pixel.

### DrawString(string value)

```csharp
void DrawString(string value)
```

Renders text via the controller's built-in text mode.
