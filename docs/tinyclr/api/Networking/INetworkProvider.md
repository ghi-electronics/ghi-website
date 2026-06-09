---
title: "INetworkProvider Interface"
sidebar_label: "INetworkProvider"
---

# INetworkProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking`

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

**Returns** `int`

### Close(int socket)

```csharp
void Close(int socket)
```

_No description available._

### Shutdown(int socket, SocketShutdown how)

```csharp
void Shutdown(int socket, SocketShutdown how)
```

Powers off until either one of the selected wake-up pins asserts or the RTC alarm fires. _(inherited)_

### Bind(int socket, SocketAddress address)

```csharp
void Bind(int socket, SocketAddress address)
```

_No description available._

### Listen(int socket, int backlog)

```csharp
void Listen(int socket, int backlog)
```

_No description available._

### Accept(int socket)

```csharp
int Accept(int socket)
```

_No description available._

**Returns** `int`

### Connect(int socket, SocketAddress address)

```csharp
void Connect(int socket, SocketAddress address)
```

_No description available._

### Available(int socket)

```csharp
int Available(int socket)
```

_No description available._

**Returns** `int`

### Poll(int socket, int microSeconds, SelectMode mode)

```csharp
bool Poll(int socket, int microSeconds, SelectMode mode)
```

_No description available._

**Returns** `bool`

### Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)

```csharp
int Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
```

_No description available._

**Returns** `int`

### Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)

```csharp
int Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
```

_No description available._

**Returns** `int`

### SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)

```csharp
int SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)
```

_No description available._

**Returns** `int`

### ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)

```csharp
int ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)
```

_No description available._

**Returns** `int`

### GetRemoteAddress(int socket, out SocketAddress address)

```csharp
void GetRemoteAddress(int socket, out SocketAddress address)
```

_No description available._

### GetLocalAddress(int socket, out SocketAddress address)

```csharp
void GetLocalAddress(int socket, out SocketAddress address)
```

_No description available._

### GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
void GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
```

_No description available._

### SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
void SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
```

_No description available._

### AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)

```csharp
int AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
```

_No description available._

**Returns** `int`

### AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)

```csharp
int AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)
```

_No description available._

**Returns** `int`

### SecureRead(int handle, byte[] buffer, int offset, int count)

```csharp
int SecureRead(int handle, byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `int`

### SecureWrite(int handle, byte[] buffer, int offset, int count)

```csharp
int SecureWrite(int handle, byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `int`

### GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)

```csharp
void GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)
```

_No description available._
