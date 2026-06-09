---
title: "IPEndPoint Class"
sidebar_label: "IPEndPoint"
---

# IPEndPoint Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

_No description available._

```csharp
public class IPEndPoint : EndPoint
```

## Constructors

### IPEndPoint(long address, int port)

```csharp
public IPEndPoint(long address, int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `address` | `long` |  |
| `port` | `int` |  |

### IPEndPoint(IPAddress address, int port)

```csharp
public IPEndPoint(IPAddress address, int port)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `address` | `IPAddress` |  |
| `port` | `int` |  |

## Properties

### AddressFamily

```csharp
public override AddressFamily AddressFamily { get; }
```

_No description available._

### Address

```csharp
public IPAddress Address { get; set; }
```

Gets or sets the address of the proxy server. _(inherited)_

### Port

```csharp
public int Port { get; set; }
```

Gets the port number of this URI. _(inherited)_

## Methods

### Serialize()

```csharp
public override SocketAddress Serialize()
```

_No description available._

**Returns** `SocketAddress`

### Create(SocketAddress socketAddress)

```csharp
public override EndPoint Create(SocketAddress socketAddress)
```

Creates a WebRequest . _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `socketAddress` | `SocketAddress` |  |

**Returns** `EndPoint`

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `obj` | `object` |  |

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table _(inherited)_

**Returns** `int`

### Parse(string s)

```csharp
public static IPEndPoint Parse(string s)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `s` | `string` |  |

**Returns** `IPEndPoint`

### TryParse(string s, out IPEndPoint result)

```csharp
public static bool TryParse(string s, out IPEndPoint result)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `s` | `string` |  |
| `result` | `out IPEndPoint` |  |

**Returns** `bool`

## Fields

### MinPort

```csharp
public const int MinPort
```

_No description available._

### MaxPort

```csharp
public const int MaxPort
```

_No description available._
