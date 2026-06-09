---
title: "NetworkControllerApiWrapper Class"
sidebar_label: "NetworkControllerApiWrapper"
---

# NetworkControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network.Provider`

Concrete `INetworkControllerProvider` backed by the native TinyCLR network HAL (lwIP + mbedTLS).

```csharp
public sealed class NetworkControllerApiWrapper : INetworkControllerProvider
```

## Constructors

### NetworkControllerApiWrapper(NativeApi api)

```csharp
public NetworkControllerApiWrapper(NativeApi api)
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

### InterfaceType

```csharp
public extern NetworkInterfaceType InterfaceType { get; }
```

Interface type — Ethernet, WiFi, or PPP. _(inherited)_

### CommunicationInterface

```csharp
public extern NetworkCommunicationInterface CommunicationInterface { get; }
```

Physical bus carrying the interface — built-in MAC, SPI, or UART. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### SetNetworkLinkConnectedChangedEventEnabled(bool enabled)

```csharp
public extern void SetNetworkLinkConnectedChangedEventEnabled(bool enabled)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `enabled` | `bool` |  |

### SetNetworkAddressChangedEventEnabled(bool enabled)

```csharp
public extern void SetNetworkAddressChangedEventEnabled(bool enabled)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `enabled` | `bool` |  |

### Enable()

```csharp
public extern void Enable()
```

Re-enables interrupts after a matching `Disable`. _(inherited)_

### EnableAsync()

```csharp
public extern void EnableAsync()
```

Non-blocking variant of `Enable`. Returns immediately while the slow PHY autonegotiation / WiFi firmware boot runs in a native RTOS task. The interface is NOT ready when this returns — subscribe to `NetworkLinkConnectedChanged` (link becomes physical-up) and `NetworkAddressChanged` (DHCP / static IP assigned) to learn when it is. Call at most once per controller per boot. _(inherited)_

### Disable()

```csharp
public extern void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

### Suspend()

```csharp
public extern void Suspend()
```

Suspends the interface (low-power state with state preserved). _(inherited)_

### Resume()

```csharp
public extern void Resume()
```

Resumes a previously `Suspend`ed interface. _(inherited)_

### SetAsDefault()

```csharp
public extern void SetAsDefault()
```

_No description available._

### SetInterfaceSettings(NetworkInterfaceSettings settings)

```csharp
public void SetInterfaceSettings(NetworkInterfaceSettings settings)
```

Applies `NetworkInterfaceSettings` (IP address, DHCP, DNS). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `settings` | `NetworkInterfaceSettings` |  |

### SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)

```csharp
public void SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)
```

Applies the underlying physical-bus settings (built-in MAC, SPI, or UART). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `settings` | `NetworkCommunicationInterfaceSettings` |  |

### GetLinkConnected()

```csharp
public extern bool GetLinkConnected()
```

True when the physical link is currently up. _(inherited)_

**Returns** `bool`

### GetIPProperties()

```csharp
public extern NetworkIPProperties GetIPProperties()
```

Returns the current IP address, subnet, gateway, and DNS servers. _(inherited)_

**Returns** `NetworkIPProperties`

### GetInterfaceProperties()

```csharp
public extern NetworkInterfaceProperties GetInterfaceProperties()
```

Returns interface-specific properties (MAC address and friends). _(inherited)_

**Returns** `NetworkInterfaceProperties`

### Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)

```csharp
public extern int Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `addressFamily` | `AddressFamily` |  |
| `socketType` | `SocketType` |  |
| `protocolType` | `ProtocolType` |  |

**Returns** `int`

### Close(int socket)

```csharp
public extern void Close(int socket)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |

### Bind(int socket, SocketAddress address)

```csharp
public extern void Bind(int socket, SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `SocketAddress` |  |

### Listen(int socket, int backlog)

```csharp
public extern void Listen(int socket, int backlog)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `backlog` | `int` |  |

### Accept(int socket)

```csharp
public extern int Accept(int socket)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |

**Returns** `int`

### Connect(int socket, SocketAddress address)

```csharp
public extern void Connect(int socket, SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `SocketAddress` |  |

### Available(int socket)

```csharp
public extern int Available(int socket)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |

**Returns** `int`

### Poll(int socket, int microSeconds, SelectMode mode)

```csharp
public extern bool Poll(int socket, int microSeconds, SelectMode mode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `microSeconds` | `int` |  |
| `mode` | `SelectMode` |  |

**Returns** `bool`

### Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)

```csharp
public extern int Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `flags` | `SocketFlags` |  |

**Returns** `int`

### Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)

```csharp
public extern int Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `flags` | `SocketFlags` |  |

**Returns** `int`

### SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)

```csharp
public extern int SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `flags` | `SocketFlags` |  |
| `address` | `SocketAddress` |  |

**Returns** `int`

### ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)

```csharp
public extern int ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `flags` | `SocketFlags` |  |
| `address` | `ref SocketAddress` |  |

**Returns** `int`

### GetRemoteAddress(int socket, out SocketAddress address)

```csharp
public extern void GetRemoteAddress(int socket, out SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `out SocketAddress` |  |

### GetLocalAddress(int socket, out SocketAddress address)

```csharp
public extern void GetLocalAddress(int socket, out SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `out SocketAddress` |  |

### GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
public extern void GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `optionLevel` | `SocketOptionLevel` |  |
| `optionName` | `SocketOptionName` |  |
| `optionValue` | `byte[]` |  |

### SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
public extern void SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `optionLevel` | `SocketOptionLevel` |  |
| `optionName` | `SocketOptionName` |  |
| `optionValue` | `byte[]` |  |

### AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)

```csharp
public extern int AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socketHandle` | `int` |  |
| `targetHost` | `string` |  |
| `caCertificate` | `X509Certificate` |  |
| `clientCertificate` | `X509Certificate` |  |
| `sslProtocols` | `SslProtocols` |  |
| `sslVerification` | `SslVerification` |  |

**Returns** `int`

### AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)

```csharp
public extern int AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socketHandle` | `int` |  |
| `certificate` | `X509Certificate` |  |
| `sslProtocols` | `SslProtocols` |  |

**Returns** `int`

### SecureRead(int handle, byte[] buffer, int offset, int count)

```csharp
public extern int SecureRead(int handle, byte[] buffer, int offset, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `handle` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### SecureWrite(int handle, byte[] buffer, int offset, int count)

```csharp
public extern int SecureWrite(int handle, byte[] buffer, int offset, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `handle` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `int`

### GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)

```csharp
public extern void GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `canonicalName` | `out string` |  |
| `addresses` | `out SocketAddress[]` |  |

### GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)

```csharp
public extern bool GetAccessPointClientLinkConnect(WiFiNetworkInterfaceSettings settings)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `settings` | `WiFiNetworkInterfaceSettings` |  |

**Returns** `bool`

### Shutdown(int socket, SocketShutdown how)

```csharp
public extern void Shutdown(int socket, SocketShutdown how)
```

Powers off until either one of the selected wake-up pins asserts or the RTC alarm fires. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `how` | `SocketShutdown` |  |

## Events

### NetworkLinkConnectedChanged

```csharp
public event NetworkLinkConnectedChangedEventHandler NetworkLinkConnectedChanged
```

Raised when the physical link goes up or down. _(inherited)_

### NetworkAddressChanged

```csharp
public event NetworkAddressChangedEventHandler NetworkAddressChanged
```

Raised when the IP address, gateway, or DNS servers change (e.g. on DHCP lease assignment). _(inherited)_
