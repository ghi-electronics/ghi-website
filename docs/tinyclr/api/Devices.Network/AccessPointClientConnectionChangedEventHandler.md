---
title: "AccessPointClientConnectionChangedEventHandler Delegate"
sidebar_label: "AccessPointClientConnectionChangedEventHandler"
---

# AccessPointClientConnectionChangedEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network`

Handler signature for `AccessPointClientConnectionChanged`.

```csharp
public delegate void AccessPointClientConnectionChangedEventHandler(NetworkController sender, IPAddress clientAddress, string macAddress);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `NetworkController` |  |
| `clientAddress` | `IPAddress` |  |
| `macAddress` | `string` |  |
