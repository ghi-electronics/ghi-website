---
title: "NetworkInterfaceProperties Class"
sidebar_label: "NetworkInterfaceProperties"
---

# NetworkInterfaceProperties Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Network` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Network`

Common interface properties. Cast via `GetEthernetProperties` / `GetWiFiProperties` / `GetPppProperties` for transport-specific fields.

```csharp
public class NetworkInterfaceProperties
```

## Properties

### MacAddress

```csharp
public byte[] MacAddress { get; }
```

The interface's MAC address (6 bytes for Ethernet/WiFi).

## Methods

### GetEthernetProperties()

```csharp
public EthernetNetworkInterfaceProperties GetEthernetProperties()
```

Returns Ethernet-specific properties, or null if this is not an Ethernet interface.

**Returns** `EthernetNetworkInterfaceProperties`

### GetWiFiProperties()

```csharp
public WiFiNetworkInterfaceProperties GetWiFiProperties()
```

Returns WiFi-specific properties, or null if this is not a WiFi interface.

**Returns** `WiFiNetworkInterfaceProperties`

### GetPppProperties()

```csharp
public PppNetworkInterfaceProperties GetPppProperties()
```

Returns PPP-specific properties, or null if this is not a PPP interface.

**Returns** `PppNetworkInterfaceProperties`
