---
title: "NetworkLinkConnectedChangedEventArgs Class"
sidebar_label: "NetworkLinkConnectedChangedEventArgs"
---

# NetworkLinkConnectedChangedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Network` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Network`

Arguments for `NetworkController.NetworkLinkConnectedChanged`.

```csharp
public class NetworkLinkConnectedChangedEventArgs : EventArgs
```

## Properties

### Connected

```csharp
public bool Connected { get; }
```

True when the physical link is up.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the transition.
