---
title: "UsbHostController Class"
sidebar_label: "UsbHostController"
---

# UsbHostController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

_No description available._

```csharp
public class UsbHostController : IDisposable
```

## Properties

### Provider

```csharp
public IUsbHostControllerProvider Provider { get; }
```

The low-level provider backing this controller. _(inherited)_

## Methods

### GetDefault()

```csharp
public static UsbHostController GetDefault()
```

Returns the default watchdog for this device. _(inherited)_

**Returns** `UsbHostController`

### FromName(string name)

```csharp
public static UsbHostController FromName(string name)
```

Returns a watchdog identified by its native API name. _(inherited)_

**Returns** `UsbHostController`

### FromProvider(IUsbHostControllerProvider provider)

```csharp
public static UsbHostController FromProvider(IUsbHostControllerProvider provider)
```

Creates a controller from a custom `IWatchdogControllerProvider`. _(inherited)_

**Returns** `UsbHostController`

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

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

### GetConnectedDevices()

```csharp
public static BaseDevice[] GetConnectedDevices()
```

_No description available._

**Returns** `BaseDevice[]`

## Events

### OnConnectionChangedEvent

```csharp
public event OnConnectionChanged OnConnectionChangedEvent
```

_No description available._
