---
title: "INetworkProvider Interface"
sidebar_label: "INetworkProvider"
---

# INetworkProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Networking` · **Assembly:** `GHIElectronics.TinyCLR.Networking`

_No description available._

```csharp
public interface INetworkProvider
```

## Methods

### Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)

```csharp
int Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
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
void Close(int socket)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |

### Shutdown(int socket, SocketShutdown how)

```csharp
void Shutdown(int socket, SocketShutdown how)
```

Powers off until either one of the selected wake-up pins asserts or the RTC alarm fires. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `how` | `SocketShutdown` |  |

### Bind(int socket, SocketAddress address)

```csharp
void Bind(int socket, SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `SocketAddress` |  |

### Listen(int socket, int backlog)

```csharp
void Listen(int socket, int backlog)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `backlog` | `int` |  |

### Accept(int socket)

```csharp
int Accept(int socket)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |

**Returns** `int`

### Connect(int socket, SocketAddress address)

```csharp
void Connect(int socket, SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `SocketAddress` |  |

### Available(int socket)

```csharp
int Available(int socket)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |

**Returns** `int`

### Poll(int socket, int microSeconds, SelectMode mode)

```csharp
bool Poll(int socket, int microSeconds, SelectMode mode)
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
int Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
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
int Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
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
int SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)
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
int ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)
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
void GetRemoteAddress(int socket, out SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `out SocketAddress` |  |

### GetLocalAddress(int socket, out SocketAddress address)

```csharp
void GetLocalAddress(int socket, out SocketAddress address)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `int` |  |
| `address` | `out SocketAddress` |  |

### GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
void GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
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
void SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
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
int AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
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
int AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)
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
int SecureRead(int handle, byte[] buffer, int offset, int count)
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
int SecureWrite(int handle, byte[] buffer, int offset, int count)
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
void GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `canonicalName` | `out string` |  |
| `addresses` | `out SocketAddress[]` |  |
