---
title: "IUsbHostControllerProvider Interface"
sidebar_label: "IUsbHostControllerProvider"
---

# IUsbHostControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Provider`

Provides the underlying implementation for a USB host controller.

```csharp
public interface IUsbHostControllerProvider : IDisposable
```

## Methods

### Enable()

```csharp
void Enable()
```

Enables the controller.

### Disable()

```csharp
void Disable()
```

Disables the controller.

## Events

### OnConnectionChangedEvent

```csharp
event OnConnectionChanged OnConnectionChangedEvent
```

The event fired when a device's connection status changes.
