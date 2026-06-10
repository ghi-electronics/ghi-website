---
title: "DisplayControllerApiWrapper Class"
sidebar_label: "DisplayControllerApiWrapper"
---

# DisplayControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Display`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Display`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Display.Provider`

Concrete `IDisplayControllerProvider` backed by the native TinyCLR display HAL.

```csharp
public sealed class DisplayControllerApiWrapper : IDisplayControllerProvider, IApiImplementation
```

## Constructors

### DisplayControllerApiWrapper(NativeApi api)

```csharp
public DisplayControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### Enable()

```csharp
public extern void Enable()
```

Powers on the panel. _(inherited)_

### Disable()

```csharp
public extern void Disable()
```

Powers off the panel. _(inherited)_

### DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)

```csharp
public extern void DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)
```

Blits a rectangle of pixel data to the panel. _(inherited)_

### DrawPixel(int x, int y, long color)

```csharp
public extern void DrawPixel(int x, int y, long color)
```

Sets a single pixel. _(inherited)_

### DrawString(string value)

```csharp
public extern void DrawString(string value)
```

Renders text via the controller's built-in text mode. _(inherited)_

### SetConfiguration(DisplayControllerSettings configuration)

```csharp
public void SetConfiguration(DisplayControllerSettings configuration)
```

Applies a configuration. _(inherited)_
