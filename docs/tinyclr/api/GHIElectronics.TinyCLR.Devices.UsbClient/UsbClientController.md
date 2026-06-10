---
title: "UsbClientController Class"
sidebar_label: "UsbClientController"
---

# UsbClientController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

Provides access to a USB client controller.

```csharp
public class UsbClientController : IDisposable
```

## Properties

### Provider

```csharp
public IUsbClientControllerProvider Provider { get; }
```

The underlying provider for the controller.

## Methods

### GetDefault()

```csharp
public static UsbClientController GetDefault()
```

Gets the default USB client controller.

**Returns** `UsbClientController`

### FromName(string name)

```csharp
public static UsbClientController FromName(string name)
```

Gets the USB client controller with the given name.

**Returns** `UsbClientController`

### FromProvider(IUsbClientControllerProvider provider)

```csharp
public static UsbClientController FromProvider(IUsbClientControllerProvider provider)
```

Gets a USB client controller from the given provider.

**Returns** `UsbClientController`

### Dispose()

```csharp
public void Dispose()
```

Disposes the controller.
