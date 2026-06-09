---
title: "UdpClient Class"
sidebar_label: "UdpClient"
---

# UdpClient Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

_No description available._

```csharp
public class UdpClient : IDisposable
```

## Constructors

### UdpClient()

```csharp
public UdpClient() : this(AddressFamily.InterNetwork)
```

_No description available._

### UdpClient(AddressFamily family)

```csharp
public UdpClient(AddressFamily family)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `family` | `AddressFamily` |  |

### UdpClient(int port)

```csharp
public UdpClient(int port) : this(port, AddressFamily.InterNetwork)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `port` | `int` |  |

### UdpClient(int port, AddressFamily family)

```csharp
public UdpClient(int port, AddressFamily family)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `port` | `int` |  |
| `family` | `AddressFamily` |  |

### UdpClient(IPEndPoint localEP)

```csharp
public UdpClient(IPEndPoint localEP)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `localEP` | `IPEndPoint` |  |

### UdpClient(string hostname, int port)

```csharp
public UdpClient(string hostname, int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hostname` | `string` |  |
| `port` | `int` |  |

## Properties

### Active

```csharp
protected bool Active { get; set; }
```

_No description available._

### Available

```csharp
public int Available { get; }
```

_No description available._

### Client

```csharp
public Socket Client { get; set; }
```

_No description available._

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### BeginSend(byte[] datagram, int bytes)

```csharp
public int BeginSend(byte[] datagram, int bytes)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` |  |
| `bytes` | `int` |  |

**Returns** `int`

### BeginSend(byte[] datagram, int bytes, string hostname, int port)

```csharp
public int BeginSend(byte[] datagram, int bytes, string hostname, int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` |  |
| `bytes` | `int` |  |
| `hostname` | `string` |  |
| `port` | `int` |  |

**Returns** `int`

### BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint)

```csharp
public int BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` |  |
| `bytes` | `int` |  |
| `endPoint` | `IPEndPoint` |  |

**Returns** `int`

### EndSend(IAsyncResult asyncResult)

```csharp
public int EndSend(IAsyncResult asyncResult)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `asyncResult` | `IAsyncResult` |  |

**Returns** `int`

### BeginReceive(int port)

```csharp
public int BeginReceive(int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `port` | `int` |  |

**Returns** `int`

### EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)

```csharp
public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `asyncResult` | `IAsyncResult` |  |
| `remoteEP` | `ref IPEndPoint` |  |

**Returns** `byte[]`

### JoinMulticastGroup(IPAddress multicastAddr)

```csharp
public void JoinMulticastGroup(IPAddress multicastAddr)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `multicastAddr` | `IPAddress` |  |

### Close()

```csharp
public void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### Connect(string hostname, int port)

```csharp
public void Connect(string hostname, int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hostname` | `string` |  |
| `port` | `int` |  |

### Connect(IPAddress addr, int port)

```csharp
public void Connect(IPAddress addr, int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `addr` | `IPAddress` |  |
| `port` | `int` |  |

### Connect(IPEndPoint endPoint)

```csharp
public void Connect(IPEndPoint endPoint)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `endPoint` | `IPEndPoint` |  |

### Receive(ref IPEndPoint remoteEP)

```csharp
public byte[] Receive(ref IPEndPoint remoteEP)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `remoteEP` | `ref IPEndPoint` |  |

**Returns** `byte[]`

### Send(byte[] dgram, int bytes, IPEndPoint endPoint)

```csharp
public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
```

Sends a UDP datagram to a specified port on a specified remote host. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dgram` | `byte[]` |  |
| `bytes` | `int` |  |
| `endPoint` | `IPEndPoint` |  |

**Returns** `int` — The number of bytes sent.

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

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `dgram` | `byte[]` |  |
| `bytes` | `int` |  |
| `hostname` | `string` |  |
| `port` | `int` |  |

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

Sends a UDP datagram to the host at the specified remote endpoint. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dgram` | `byte[]` |  |
| `bytes` | `int` |  |

**Returns** `int` — The number of bytes sent.

### Send(byte[] datagram)

```csharp
public int Send(byte[] datagram)
```

Sends a UDP datagram to a remote host.

| Parameter | Type | Description |
|---|---|---|
| `datagram` | `byte[]` | An `ReadOnlySpan{T}` of Type `byte` that specifies the UDP datagram that you intend to send. |

**Returns** `int` — The number of bytes sent.
