---
title: "UdpClient Class"
sidebar_label: "UdpClient"
---

# UdpClient Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Provides User Datagram Protocol (UDP) network services.

```csharp
public class UdpClient : IDisposable
```

## Constructors

### UdpClient()

```csharp
public UdpClient() : this(AddressFamily.InterNetwork)
```

Initializes a new instance using the default address family.

### UdpClient(AddressFamily family)

```csharp
public UdpClient(AddressFamily family)
```

Initializes a new instance using the specified address family.

### UdpClient(int port)

```csharp
public UdpClient(int port) : this(port, AddressFamily.InterNetwork)
```

Initializes a new instance bound to the specified local port.

### UdpClient(int port, AddressFamily family)

```csharp
public UdpClient(int port, AddressFamily family)
```

Initializes a new instance bound to the specified local port and address family.

### UdpClient(IPEndPoint localEP)

```csharp
public UdpClient(IPEndPoint localEP)
```

Initializes a new instance bound to the specified local endpoint.

### UdpClient(string hostname, int port)

```csharp
public UdpClient(string hostname, int port)
```

Initializes a new instance and connects to the specified host and port.

## Properties

### Active

```csharp
protected bool Active { get; set; }
```

Whether a default remote host has been established.

### Available

```csharp
public int Available { get; }
```

The number of bytes available to be read.

### Client

```csharp
public Socket Client { get; set; }
```

The underlying socket used by the client.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by the client.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the resources used by the client.

### BeginSend(byte[] datagram, int bytes)

```csharp
public int BeginSend(byte[] datagram, int bytes)
```

Sends a datagram on the connected socket and returns the number of bytes sent.

**Returns** `int`

### BeginSend(byte[] datagram, int bytes, string hostname, int port)

```csharp
public int BeginSend(byte[] datagram, int bytes, string hostname, int port)
```

Sends a datagram to the specified host and port and returns the number of bytes sent.

**Returns** `int`

### BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint)

```csharp
public int BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint)
```

Sends a datagram to the specified endpoint and returns the number of bytes sent.

**Returns** `int`

### EndSend(IAsyncResult asyncResult)

```csharp
public int EndSend(IAsyncResult asyncResult)
```

Not implemented; always throws NotImplementedException.

**Returns** `int`

### BeginReceive(int port)

```csharp
public int BeginReceive(int port)
```

Receives a datagram into the internal buffer and returns the number of bytes read.

**Returns** `int`

### EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)

```csharp
public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
```

Returns the buffer holding the data received by a previous BeginReceive call.

**Returns** `byte[]`

### JoinMulticastGroup(IPAddress multicastAddr)

```csharp
public void JoinMulticastGroup(IPAddress multicastAddr)
```

Joins the specified multicast group.

### Close()

```csharp
public void Close()
```

Closes the client and releases its resources.

### Connect(string hostname, int port)

```csharp
public void Connect(string hostname, int port)
```

Establishes a default remote host using the specified host name and port.

### Connect(IPAddress addr, int port)

```csharp
public void Connect(IPAddress addr, int port)
```

Establishes a default remote host using the specified IP address and port.

### Connect(IPEndPoint endPoint)

```csharp
public void Connect(IPEndPoint endPoint)
```

Establishes a default remote host using the specified endpoint.

### Receive(ref IPEndPoint remoteEP)

```csharp
public byte[] Receive(ref IPEndPoint remoteEP)
```

Receives a datagram and returns its data, reporting the sender's endpoint.

**Returns** `byte[]`

### Send(byte[] dgram, int bytes, IPEndPoint endPoint)

```csharp
public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
```

Sends the specified number of bytes of a datagram to the given endpoint.

**Returns** `int`

### Send(byte[] datagram, IPEndPoint endPoint)

```csharp
public int Send(byte[] datagram, IPEndPoint endPoint)
```

Sends a UDP datagram to the host at the specified remote endpoint.

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` | An `ReadOnlySpan{T}` of Type `byte` that specifies the UDP datagram that you intend to send. |
| `endPoint` | `IPEndPoint` | An `IPEndPoint` that represents the host and port to which to send the datagram. |

**Returns** `int` — The number of bytes sent.

### Send(byte[] dgram, int bytes, string hostname, int port)

```csharp
public int Send(byte[] dgram, int bytes, string hostname, int port)
```

Sends the specified number of bytes of a datagram to the given host and port.

**Returns** `int`

### Send(byte[] datagram, string hostname, int port)

```csharp
public int Send(byte[] datagram, string hostname, int port)
```

Sends a UDP datagram to a specified port on a specified remote host.

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` | An `ReadOnlySpan{T}` of Type `byte` that specifies the UDP datagram that you intend to send. |
| `hostname` | `string` | The name of the remote host to which you intend to send the datagram. |
| `port` | `int` | The remote port number with which you intend to communicate. |

**Returns** `int` — The number of bytes sent.

### Send(byte[] dgram, int bytes)

```csharp
public int Send(byte[] dgram, int bytes)
```

Sends the specified number of bytes of a datagram to the connected remote host.

**Returns** `int`

### Send(byte[] datagram)

```csharp
public int Send(byte[] datagram)
```

Sends a UDP datagram to a remote host.

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` | An `ReadOnlySpan{T}` of Type `byte` that specifies the UDP datagram that you intend to send. |

**Returns** `int` — The number of bytes sent.
