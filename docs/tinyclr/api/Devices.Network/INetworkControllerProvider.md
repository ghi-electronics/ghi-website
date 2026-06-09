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

Interface type — Ethernet, WiFi, or PPP. _(inherited)_

### CommunicationInterface

```csharp
NetworkCommunicationInterface CommunicationInterface { get; }
```

Physical bus carrying the interface — built-in MAC, SPI, or UART. _(inherited)_

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

### Suspend()

```csharp
void Suspend()
```

Suspends the interface (low-power state with state preserved). _(inherited)_

### Resume()

```csharp
void Resume()
```

Resumes a previously `Suspend`ed interface. _(inherited)_

### GetLinkConnected()

```csharp
bool GetLinkConnected()
```

True when the physical link is currently up. _(inherited)_

**Returns** `bool`

### GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)

```csharp
bool GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `settings` | `WiFiNetworkInterfaceSettings` |  |

**Returns** `bool`

### GetIPProperties()

```csharp
NetworkIPProperties GetIPProperties()
```

Returns the current IP address, subnet, gateway, and DNS servers. _(inherited)_

**Returns** `NetworkIPProperties`

### GetInterfaceProperties()

```csharp
NetworkInterfaceProperties GetInterfaceProperties()
```

Returns interface-specific properties (MAC address and friends). _(inherited)_

**Returns** `NetworkInterfaceProperties`

### SetInterfaceSettings(NetworkInterfaceSettings settings)

```csharp
void SetInterfaceSettings(NetworkInterfaceSettings settings)
```

Applies `NetworkInterfaceSettings` (IP address, DHCP, DNS). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `settings` | `NetworkInterfaceSettings` |  |

### SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)

```csharp
void SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)
```

Applies the underlying physical-bus settings (built-in MAC, SPI, or UART). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `settings` | `NetworkCommunicationInterfaceSettings` |  |

## Events

### NetworkLinkConnectedChanged

```csharp
event NetworkLinkConnectedChangedEventHandler NetworkLinkConnectedChanged
```

Raised when the physical link goes up or down. _(inherited)_

### NetworkAddressChanged

```csharp
event NetworkAddressChangedEventHandler NetworkAddressChanged
```

Raised when the IP address, gateway, or DNS servers change (e.g. on DHCP lease assignment). _(inherited)_
