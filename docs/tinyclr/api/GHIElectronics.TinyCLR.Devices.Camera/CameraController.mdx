---
title: "CameraController Class"
sidebar_label: "CameraController"
---

# CameraController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Camera`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Camera`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Camera`

Represents a DCMI / parallel camera interface. Configure timing via `SetActiveSettings`, `Enable` the capture engine, then call `Capture(byte[], int)` to read a frame into a buffer.

```csharp
public class CameraController : IDisposable
```

## Properties

### Provider

```csharp
public ICameraControllerProvider Provider { get; }
```

The low-level provider backing this controller.

## Methods

### GetDefault()

```csharp
public static CameraController GetDefault()
```

Returns the default camera controller for this device.

**Returns** `CameraController`

### FromName(string name)

```csharp
public static CameraController FromName(string name)
```

Returns a camera controller identified by its native API name.

**Returns** `CameraController`

### FromProvider(ICameraControllerProvider provider)

```csharp
public static CameraController FromProvider(ICameraControllerProvider provider)
```

Creates a controller from a custom `ICameraControllerProvider`.

**Returns** `CameraController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### SetActiveSettings(CaptureRate captureRate, bool horizontalSyncPolarity, bool verticalSyncPolarity, bool pixelClockPolarity, SynchronizationMode synchronizationMode, ExtendedDataMode extendedDataMode, uint sourceClock)

```csharp
public void SetActiveSettings(CaptureRate captureRate, bool horizontalSyncPolarity, bool verticalSyncPolarity, bool pixelClockPolarity, SynchronizationMode synchronizationMode, ExtendedDataMode extendedDataMode, uint sourceClock)
```

Applies a complete set of DCMI timing/protocol settings.

| Parameter | Type | Description |
|---|---|---|
| `captureRate` | `CaptureRate` | Per-frame capture rate. |
| `horizontalSyncPolarity` | `bool` | HSYNC polarity (false = active low). |
| `verticalSyncPolarity` | `bool` | VSYNC polarity (false = active low). |
| `pixelClockPolarity` | `bool` | Pixel-clock polarity (false = falling-edge sample). |
| `synchronizationMode` | `SynchronizationMode` | Hardware vs. embedded synchronization. |
| `extendedDataMode` | `ExtendedDataMode` | Data bus width. |
| `sourceClock` | `uint` | Source clock feeding the camera, in Hz. |

### Capture(byte[] data, int timeoutMillisecond)

```csharp
public int Capture(byte[] data, int timeoutMillisecond)
```

Captures one frame into the supplied buffer.

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` | Destination buffer. Must be large enough for one frame at the configured resolution/format. |
| `timeoutMillisecond` | `int` | Maximum time to wait for the frame, in milliseconds. |

**Returns** `int` — Number of bytes actually captured.

### Capture(byte[] data, int offset, int count, int timeoutMillisecond)

```csharp
public int Capture(byte[] data, int offset, int count, int timeoutMillisecond)
```

Captures one frame into a slice of the buffer.

**Returns** `int`

### Enable()

```csharp
public void Enable()
```

Powers on the capture engine.

### Disable()

```csharp
public void Disable()
```

Powers off the capture engine.
