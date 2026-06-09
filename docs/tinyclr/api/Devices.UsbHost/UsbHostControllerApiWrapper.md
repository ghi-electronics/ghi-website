---
title: "UsbHostControllerApiWrapper Class"
sidebar_label: "UsbHostControllerApiWrapper"
---

# UsbHostControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Provider`

_No description available._

```csharp
public sealed class UsbHostControllerApiWrapper : IUsbHostControllerProvider
```

## Constructors

### UsbHostControllerApiWrapper(NativeApi api)

```csharp
public UsbHostControllerApiWrapper(NativeApi api)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` |  |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

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

## Events

### OnConnectionChangedEvent

```csharp
public event OnConnectionChanged OnConnectionChangedEvent
```

_No description available._
