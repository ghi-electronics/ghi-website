---
title: "DisplayControllerApiWrapper Class"
sidebar_label: "DisplayControllerApiWrapper"
---

# DisplayControllerApiWrapper Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Display.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Display`

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

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` |  |

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

Re-enables interrupts after a matching `Disable`. _(inherited)_

### Disable()

```csharp
public extern void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

### DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)

```csharp
public extern void DrawBuffer(int targetX, int targetY, int sourceX, int sourceY, int width, int height, int originalWidth, byte[] data, int offset)
```

Blits a rectangle of pixel data to the panel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `targetX` | `int` |  |
| `targetY` | `int` |  |
| `sourceX` | `int` |  |
| `sourceY` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `originalWidth` | `int` |  |
| `data` | `byte[]` |  |
| `offset` | `int` |  |

### DrawPixel(int x, int y, long color)

```csharp
public extern void DrawPixel(int x, int y, long color)
```

Sets a single pixel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `color` | `long` |  |

### DrawString(string value)

```csharp
public extern void DrawString(string value)
```

Renders text via the controller's built-in text mode. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `string` |  |

### SetConfiguration(DisplayControllerSettings configuration)

```csharp
public void SetConfiguration(DisplayControllerSettings configuration)
```

Applies a configuration. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `configuration` | `DisplayControllerSettings` |  |
