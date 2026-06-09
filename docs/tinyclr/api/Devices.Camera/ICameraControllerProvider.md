---
title: "ICameraControllerProvider Interface"
sidebar_label: "ICameraControllerProvider"
---

# ICameraControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Camera`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Camera`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Camera.Provider`

Provider contract for a camera controller.

```csharp
public interface ICameraControllerProvider : IDisposable
```

## Methods

### SetActiveSettings(CaptureRate captureRate, bool horizontalSyncPolarity, bool verticalSyncPolarity, bool pixelClockPolarity, SynchronizationMode synchronizationMode, ExtendedDataMode extendedDataMode, uint sourceClock)

```csharp
void SetActiveSettings(CaptureRate captureRate, bool horizontalSyncPolarity, bool verticalSyncPolarity, bool pixelClockPolarity, SynchronizationMode synchronizationMode, ExtendedDataMode extendedDataMode, uint sourceClock)
```

Applies a complete set of camera timing/protocol settings.

| Parameter | Type | Description |
|---|---|---|
| `captureRate` | `CaptureRate` |  |
| `horizontalSyncPolarity` | `bool` |  |
| `verticalSyncPolarity` | `bool` |  |
| `pixelClockPolarity` | `bool` |  |
| `synchronizationMode` | `SynchronizationMode` |  |
| `extendedDataMode` | `ExtendedDataMode` |  |
| `sourceClock` | `uint` |  |

### Capture(byte[] data, int offset, int count, int timeoutMillisecond)

```csharp
int Capture(byte[] data, int offset, int count, int timeoutMillisecond)
```

Captures one frame.

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `timeoutMillisecond` | `int` |  |

**Returns** `int`

### Enable()

```csharp
void Enable()
```

Powers on the capture engine.

### Disable()

```csharp
void Disable()
```

Powers off the capture engine.
