---
title: "INetworkControllerProvider Interface"
sidebar_label: "INetworkControllerProvider"
---

# INetworkControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network.Provider`

Provider contract for a network controller.

```csharp
public interface INetworkControllerProvider : IDisposable, INetworkProvider
```

## Properties

### InterfaceType

```csharp
NetworkInterfaceType InterfaceType { get; }
```

Transport type of the interface — Ethernet, WiFi, or PPP.

### CommunicationInterface

```csharp
NetworkCommunicationInterface CommunicationInterface { get; }
```

Physical bus carrying the interface — built-in MAC, SPI, or UART.

## Methods

### Enable()

```csharp
void Enable()
```

Brings the interface up.

### Disable()

```csharp
void Disable()
```

Brings the interface down.

### Suspend()

```csharp
void Suspend()
```

Suspends the interface to a low-power state.

### Resume()

```csharp
void Resume()
```

Resumes a suspended interface.

### GetLinkConnected()

```csharp
bool GetLinkConnected()
```

Returns true when the physical link is up.

**Returns** `bool`

### GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)

```csharp
bool GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)
```

Returns true when a station is connected to this access point.

**Returns** `bool`

### GetIPProperties()

```csharp
NetworkIPProperties GetIPProperties()
```

Returns the current IP address, subnet, gateway, and DNS servers.

**Returns** `NetworkIPProperties`

### GetInterfaceProperties()

```csharp
NetworkInterfaceProperties GetInterfaceProperties()
```

Returns interface-specific properties such as the MAC address.

**Returns** `NetworkInterfaceProperties`

### SetInterfaceSettings(NetworkInterfaceSettings settings)

```csharp
void SetInterfaceSettings(NetworkInterfaceSettings settings)
```

Applies the interface settings (IP address, DHCP, DNS).

### SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)

```csharp
void SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)
```

Applies the underlying physical-bus settings.

## Events

### NetworkLinkConnectedChanged

```csharp
event NetworkLinkConnectedChangedEventHandler NetworkLinkConnectedChanged
```

Raised when the physical link goes up or down.

### NetworkAddressChanged

```csharp
event NetworkAddressChangedEventHandler NetworkAddressChanged
```

Raised when the IP address, gateway, or DNS servers change.
