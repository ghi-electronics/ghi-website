---
title: "IPEndPoint Class"
sidebar_label: "IPEndPoint"
---

# IPEndPoint Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

Represents a network endpoint as an IP address and a port number.

```csharp
public class IPEndPoint : EndPoint
```

## Constructors

### IPEndPoint(long address, int port)

```csharp
public IPEndPoint(long address, int port)
```

Initializes a new instance with the specified address and port.

### IPEndPoint(IPAddress address, int port)

```csharp
public IPEndPoint(IPAddress address, int port)
```

Initializes a new instance with the specified address and port.

## Properties

### AddressFamily

```csharp
public override AddressFamily AddressFamily { get; }
```

The address family to which the endpoint belongs. _(inherited)_

### Address

```csharp
public IPAddress Address { get; set; }
```

The IP address of the endpoint.

### Port

```csharp
public int Port { get; set; }
```

The port number of the endpoint.

## Methods

### Serialize()

```csharp
public override SocketAddress Serialize()
```

Serializes endpoint information into a SocketAddress instance. _(inherited)_

**Returns** `SocketAddress`

### Create(SocketAddress socketAddress)

```csharp
public override EndPoint Create(SocketAddress socketAddress)
```

Creates an endpoint from a socket address. _(inherited)_

**Returns** `EndPoint`

### ToString()

```csharp
public override string ToString()
```

Returns the endpoint as an "address:port" string.

**Returns** `string`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Determines whether the specified object is equal to this endpoint.

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Returns a hash code for this endpoint.

**Returns** `int`

### Parse(string s)

```csharp
public static IPEndPoint Parse(string s)
```

Parses an "address:port" string into an IP endpoint.

**Returns** `IPEndPoint`

### TryParse(string s, out IPEndPoint result)

```csharp
public static bool TryParse(string s, out IPEndPoint result)
```

Attempts to parse an "address:port" string into an IP endpoint, returning whether it succeeded.

**Returns** `bool`

## Fields

### MinPort

```csharp
public const int MinPort
```

The minimum value that can be assigned to the Port property.

### MaxPort

```csharp
public const int MaxPort
```

The maximum value that can be assigned to the Port property.
