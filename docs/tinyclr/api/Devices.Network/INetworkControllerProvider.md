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

_No description available._

### CommunicationInterface

```csharp
NetworkCommunicationInterface CommunicationInterface { get; }
```

_No description available._

## Methods

### Enable()

```csharp
void Enable()
```

_No description available._

### Disable()

```csharp
void Disable()
```

_No description available._

### Suspend()

```csharp
void Suspend()
```

_No description available._

### Resume()

```csharp
void Resume()
```

_No description available._

### GetLinkConnected()

```csharp
bool GetLinkConnected()
```

_No description available._

**Returns** `bool`

### GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)

```csharp
bool GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)
```

_No description available._

**Returns** `bool`

### GetIPProperties()

```csharp
NetworkIPProperties GetIPProperties()
```

_No description available._

**Returns** `NetworkIPProperties`

### GetInterfaceProperties()

```csharp
NetworkInterfaceProperties GetInterfaceProperties()
```

_No description available._

**Returns** `NetworkInterfaceProperties`

### SetInterfaceSettings(NetworkInterfaceSettings settings)

```csharp
void SetInterfaceSettings(NetworkInterfaceSettings settings)
```

_No description available._

### SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)

```csharp
void SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)
```

_No description available._

## Events

### NetworkLinkConnectedChanged

```csharp
event NetworkLinkConnectedChangedEventHandler NetworkLinkConnectedChanged
```

_No description available._

### NetworkAddressChanged

```csharp
event NetworkAddressChangedEventHandler NetworkAddressChanged
```

_No description available._
