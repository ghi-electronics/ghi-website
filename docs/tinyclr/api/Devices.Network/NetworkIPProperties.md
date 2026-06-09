---
title: "NetworkIPProperties Class"
sidebar_label: "NetworkIPProperties"
---

# NetworkIPProperties Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network`

IP-level interface properties.

```csharp
public class NetworkIPProperties
```

## Properties

### Address

```csharp
public IPAddress Address { get; }
```

Current IP address.

### SubnetMask

```csharp
public IPAddress SubnetMask { get; }
```

Subnet mask.

### GatewayAddress

```csharp
public IPAddress GatewayAddress { get; }
```

Default gateway.

### DnsAddresses

```csharp
public IPAddress[] DnsAddresses { get; }
```

DNS servers in order of preference.
