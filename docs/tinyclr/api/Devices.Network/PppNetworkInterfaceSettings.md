---
title: "PppNetworkInterfaceSettings Class"
sidebar_label: "PppNetworkInterfaceSettings"
---

# PppNetworkInterfaceSettings Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network`

PPP-specific interface settings (cellular modems, dial-up).

```csharp
public class PppNetworkInterfaceSettings : NetworkInterfaceSettings
```

## Properties

### Username

```csharp
public string Username { get; set; }
```

PPP username.

### Password

```csharp
public string Password { get; set; }
```

PPP password.

### AuthenticationType

```csharp
public PppAuthenticationType AuthenticationType { get; set; }
```

Authentication protocol to use.
