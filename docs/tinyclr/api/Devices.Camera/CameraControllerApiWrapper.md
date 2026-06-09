---
title: "CameraControllerApiWrapper Class"
sidebar_label: "CameraControllerApiWrapper"
---

# CameraControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Camera`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Camera`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Camera.Provider`

Concrete `ICameraControllerProvider` backed by the native TinyCLR camera HAL.

```csharp
public sealed class CameraControllerApiWrapper : ICameraControllerProvider
```

## Constructors

### CameraControllerApiWrapper(NativeApi api)

```csharp
public CameraControllerApiWrapper(NativeApi api)
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

### SetActiveSettings(CaptureRate captureRate, bool horizontalSyncPolarity, bool verticalSyncPolarity, bool pixelClockPolarity, SynchronizationMode synchronizationMode, ExtendedDataMode extendedDataMode, uint sourceClock)

```csharp
public void SetActiveSettings(CaptureRate captureRate, bool horizontalSyncPolarity, bool verticalSyncPolarity, bool pixelClockPolarity, SynchronizationMode synchronizationMode, ExtendedDataMode extendedDataMode, uint sourceClock)
```

Applies a complete set of camera timing/protocol settings. _(inherited)_

### Capture(byte[] data, int offset, int count, int timeoutMillisecond)

```csharp
public int Capture(byte[] data, int offset, int count, int timeoutMillisecond)
```

Capture timestamps of `count` edges on the pin. _(inherited)_

**Returns** `int`

### Enable()

```csharp
public void Enable()
```

Re-enables interrupts after a matching `Disable`. _(inherited)_

### Disable()

```csharp
public void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_
