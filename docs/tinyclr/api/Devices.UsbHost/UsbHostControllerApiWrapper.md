---
title: "UsbHostControllerApiWrapper Class"
sidebar_label: "UsbHostControllerApiWrapper"
---

# UsbHostControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Provider`

The native API wrapper that implements the USB host controller provider.

```csharp
public sealed class UsbHostControllerApiWrapper : IUsbHostControllerProvider
```

## Constructors

### UsbHostControllerApiWrapper(NativeApi api)

```csharp
public UsbHostControllerApiWrapper(NativeApi api)
```

Creates a new wrapper around the given native API.

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The native API backing this provider.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native API and disposes the provider.

### Enable()

```csharp
public extern void Enable()
```

Enables the controller. _(inherited)_

### Disable()

```csharp
public extern void Disable()
```

Disables the controller. _(inherited)_

## Events

### OnConnectionChangedEvent

```csharp
public event OnConnectionChanged OnConnectionChangedEvent
```

The event fired when a device's connection status changes.
