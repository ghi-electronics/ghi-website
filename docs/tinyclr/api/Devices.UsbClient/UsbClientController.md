---
title: "UsbClientController Class"
sidebar_label: "UsbClientController"
---

# UsbClientController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

_No description available._

```csharp
public class UsbClientController : IDisposable
```

## Properties

### Provider

```csharp
public IUsbClientControllerProvider Provider { get; }
```

The low-level provider backing this controller. _(inherited)_

## Methods

### GetDefault()

```csharp
public static UsbClientController GetDefault()
```

Returns the default watchdog for this device. _(inherited)_

**Returns** `UsbClientController`

### FromName(string name)

```csharp
public static UsbClientController FromName(string name)
```

Returns a watchdog identified by its native API name. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `UsbClientController`

### FromProvider(IUsbClientControllerProvider provider)

```csharp
public static UsbClientController FromProvider(IUsbClientControllerProvider provider)
```

Creates a controller from a custom `IWatchdogControllerProvider`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IUsbClientControllerProvider` |  |

**Returns** `UsbClientController`

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
