---
title: "INetworkProvider Interface"
sidebar_label: "INetworkProvider"
---

# INetworkProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking`

Defines the low-level operations a network stack must implement to back sockets.

```csharp
public interface INetworkProvider
```

## Methods

### Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)

```csharp
int Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
```

Creates a new socket and returns its handle.

**Returns** `int`

### Close(int socket)

```csharp
void Close(int socket)
```

Closes the specified socket.

### Shutdown(int socket, SocketShutdown how)

```csharp
void Shutdown(int socket, SocketShutdown how)
```

Disables send and/or receive operations on the socket.

### Bind(int socket, SocketAddress address)

```csharp
void Bind(int socket, SocketAddress address)
```

Binds the socket to the specified local address.

### Listen(int socket, int backlog)

```csharp
void Listen(int socket, int backlog)
```

Places the socket in a listening state with the specified backlog.

### Accept(int socket)

```csharp
int Accept(int socket)
```

Accepts a pending connection and returns the new socket handle.

**Returns** `int`

### Connect(int socket, SocketAddress address)

```csharp
void Connect(int socket, SocketAddress address)
```

Connects the socket to the specified remote address.

### Available(int socket)

```csharp
int Available(int socket)
```

Returns the number of bytes available to read from the socket.

**Returns** `int`

### Poll(int socket, int microSeconds, SelectMode mode)

```csharp
bool Poll(int socket, int microSeconds, SelectMode mode)
```

Polls the socket for the specified status within the given timeout.

**Returns** `bool`

### Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)

```csharp
int Send(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
```

Sends data on a connected socket and returns the number of bytes sent.

**Returns** `int`

### Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)

```csharp
int Receive(int socket, byte[] buffer, int offset, int count, SocketFlags flags)
```

Receives data from a connected socket and returns the number of bytes read.

**Returns** `int`

### SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)

```csharp
int SendTo(int socket, byte[] buffer, int offset, int count, SocketFlags flags, SocketAddress address)
```

Sends data to the specified address and returns the number of bytes sent.

**Returns** `int`

### ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)

```csharp
int ReceiveFrom(int socket, byte[] buffer, int offset, int count, SocketFlags flags, ref SocketAddress address)
```

Receives data and reports the sender's address, returning the number of bytes read.

**Returns** `int`

### GetRemoteAddress(int socket, out SocketAddress address)

```csharp
void GetRemoteAddress(int socket, out SocketAddress address)
```

Gets the remote address the socket is connected to.

### GetLocalAddress(int socket, out SocketAddress address)

```csharp
void GetLocalAddress(int socket, out SocketAddress address)
```

Gets the local address the socket is bound to.

### GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
void GetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
```

Reads the value of the specified socket option.

### SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)

```csharp
void SetOption(int socket, SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
```

Sets the value of the specified socket option.

### AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)

```csharp
int AuthenticateAsClient(int socketHandle, string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
```

Performs the client side of an SSL/TLS handshake on the socket.

**Returns** `int`

### AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)

```csharp
int AuthenticateAsServer(int socketHandle, X509Certificate certificate, SslProtocols sslProtocols)
```

Performs the server side of an SSL/TLS handshake on the socket.

**Returns** `int`

### SecureRead(int handle, byte[] buffer, int offset, int count)

```csharp
int SecureRead(int handle, byte[] buffer, int offset, int count)
```

Reads decrypted data from a secured socket.

**Returns** `int`

### SecureWrite(int handle, byte[] buffer, int offset, int count)

```csharp
int SecureWrite(int handle, byte[] buffer, int offset, int count)
```

Writes data to be encrypted on a secured socket.

**Returns** `int`

### GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)

```csharp
void GetHostByName(string name, out string canonicalName, out SocketAddress[] addresses)
```

Resolves a host name to its canonical name and addresses.
