---
title: "TcpListener Class"
sidebar_label: "TcpListener"
---

# TcpListener Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Listens for connections from TCP network clients.

```csharp
public class TcpListener
```

## Constructors

### TcpListener(IPEndPoint localEP)

```csharp
public TcpListener(IPEndPoint localEP)
```

Initializes a new instance that listens on the specified local endpoint.

### TcpListener(IPAddress localaddr, int port)

```csharp
public TcpListener(IPAddress localaddr, int port) : this(new IPEndPoint(localaddr, port))
```

Initializes a new instance that listens on the specified local address and port.

## Properties

### Server

```csharp
public Socket Server { get; }
```

The underlying socket used by the listener.

### Active

```csharp
protected bool Active { get; }
```

Whether the listener is actively listening for connections.

### LocalEndpoint

```csharp
public EndPoint LocalEndpoint { get; }
```

The local endpoint the listener is bound to.

## Methods

### Start()

```csharp
public void Start()
```

Starts listening for incoming connection requests.

### Start(int backlog)

```csharp
public void Start(int backlog)
```

Starts listening with the specified maximum length of the pending connection queue.

### Stop()

```csharp
public void Stop()
```

Stops listening for incoming connection requests.

### Pending()

```csharp
public bool Pending()
```

Determines whether a connection request is pending.

**Returns** `bool`

### AcceptSocket()

```csharp
public Socket AcceptSocket()
```

Accepts a pending connection request and returns a Socket.

**Returns** `Socket`

### AcceptTcpClient()

```csharp
public TcpClient AcceptTcpClient()
```

Accepts a pending connection request and returns a TcpClient.

**Returns** `TcpClient`

### Create(int port)

```csharp
public static TcpListener Create(int port)
```

Creates a listener that listens on any local interface using the specified port.

**Returns** `TcpListener`
