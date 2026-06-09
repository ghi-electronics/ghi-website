---
title: "TcpClient Class"
sidebar_label: "TcpClient"
---

# TcpClient Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

_No description available._

```csharp
public class TcpClient : IDisposable
```

## Constructors

### TcpClient()

```csharp
public TcpClient() : this(AddressFamily.Unknown)
```

_No description available._

### TcpClient(AddressFamily family)

```csharp
public TcpClient(AddressFamily family)
```

_No description available._

### TcpClient(IPEndPoint localEP)

```csharp
public TcpClient(IPEndPoint localEP)
```

_No description available._

### TcpClient(string hostname, int port)

```csharp
public TcpClient(string hostname, int port) : this(AddressFamily.Unknown)
```

_No description available._

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

### Connected

```csharp
public bool Connected { get; }
```

Whether or not the device is connected. _(inherited)_

### ReceiveBufferSize

```csharp
public int ReceiveBufferSize { get; set; }
```

_No description available._

### SendBufferSize

```csharp
public int SendBufferSize { get; set; }
```

_No description available._

### ReceiveTimeout

```csharp
public int ReceiveTimeout { get; set; }
```

_No description available._

### SendTimeout

```csharp
public int SendTimeout { get; set; }
```

_No description available._

## Methods

### Connect(string hostname, int port)

```csharp
public void Connect(string hostname, int port)
```

_No description available._

### Connect(IPAddress address, int port)

```csharp
public void Connect(IPAddress address, int port)
```

_No description available._

### Connect(IPEndPoint remoteEP)

```csharp
public void Connect(IPEndPoint remoteEP)
```

_No description available._

### Connect(IPAddress[] ipAddresses, int port)

```csharp
public void Connect(IPAddress[] ipAddresses, int port)
```

_No description available._

### GetStream()

```csharp
public NetworkStream GetStream()
```

_No description available._

**Returns** `NetworkStream`

### Close()

```csharp
public void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
