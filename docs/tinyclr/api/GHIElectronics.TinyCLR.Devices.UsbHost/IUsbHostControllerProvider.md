---
title: "IUsbHostControllerProvider Interface"
sidebar_label: "IUsbHostControllerProvider"
---

# IUsbHostControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

_No description available._

```csharp
public interface IUsbHostControllerProvider : IDisposable
```

## Methods

### Enable()

```csharp
void Enable()
```

Re-enables interrupts after a matching `Disable`. _(inherited)_

### Disable()

```csharp
void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

## Events

### OnConnectionChangedEvent

```csharp
event OnConnectionChanged OnConnectionChangedEvent
```

_No description available._
