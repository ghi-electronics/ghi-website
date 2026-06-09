---
title: "TcpListener Class"
sidebar_label: "TcpListener"
---

# TcpListener Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

_No description available._

```csharp
public class TcpListener
```

## Constructors

### TcpListener(IPEndPoint localEP)

```csharp
public TcpListener(IPEndPoint localEP)
```

_No description available._

### TcpListener(IPAddress localaddr, int port)

```csharp
public TcpListener(IPAddress localaddr, int port) : this(new IPEndPoint(localaddr, port))
```

_No description available._

## Properties

### Server

```csharp
public Socket Server { get; }
```

_No description available._

### Active

```csharp
protected bool Active { get; }
```

_No description available._

### LocalEndpoint

```csharp
public EndPoint LocalEndpoint { get; }
```

_No description available._

## Methods

### Start()

```csharp
public void Start()
```

_No description available._

### Start(int backlog)

```csharp
public void Start(int backlog)
```

_No description available._

### Stop()

```csharp
public void Stop()
```

_No description available._

### Pending()

```csharp
public bool Pending()
```

_No description available._

**Returns** `bool`

### AcceptSocket()

```csharp
public Socket AcceptSocket()
```

_No description available._

**Returns** `Socket`

### AcceptTcpClient()

```csharp
public TcpClient AcceptTcpClient()
```

_No description available._

**Returns** `TcpClient`

### Create(int port)

```csharp
public static TcpListener Create(int port)
```

_No description available._

**Returns** `TcpListener`
