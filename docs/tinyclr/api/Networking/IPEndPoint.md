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

### IPEndPoint(IPAddress address, int port)

```csharp
public IPEndPoint(IPAddress address, int port)
```

_No description available._

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

_No description available._

### Port

```csharp
public int Port { get; set; }
```

_No description available._

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

_No description available._

**Returns** `EndPoint`

### ToString()

```csharp
public override string ToString()
```

_No description available._

**Returns** `string`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

_No description available._

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

_No description available._

**Returns** `int`

### Parse(string s)

```csharp
public static IPEndPoint Parse(string s)
```

_No description available._

**Returns** `IPEndPoint`

### TryParse(string s, out IPEndPoint result)

```csharp
public static bool TryParse(string s, out IPEndPoint result)
```

_No description available._

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
