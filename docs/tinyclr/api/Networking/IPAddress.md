---
title: "IPAddress Class"
sidebar_label: "IPAddress"
---

# IPAddress Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

_No description available._

```csharp
public class IPAddress
```

## Constructors

### IPAddress(long newAddress)

```csharp
public IPAddress(long newAddress)
```

_No description available._

### IPAddress(byte[] newAddressBytes)

```csharp
public IPAddress(byte[] newAddressBytes) : this(((((newAddressBytes[3] << 0x18) | (newAddressBytes[2] << 0x10)) | (newAddressBytes[1] << 0x08)) | newAddressBytes[0]) & ((long)0xFFFFFFFF))
```

_No description available._

## Properties

### AddressFamily

```csharp
public AddressFamily AddressFamily { get; }
```

_No description available._

## Methods

### IPAddress( 0x0000000000000000)

```csharp
public static readonly IPAddress Any = new IPAddress(0x0000000000000000)
```

_No description available._

**Returns** `IPAddress Any = new`

### IPAddress( 0x000000000100007F)

```csharp
public static readonly IPAddress Loopback = new IPAddress(0x000000000100007F)
```

_No description available._

**Returns** `IPAddress Loopback = new`

### IPAddress( 0x00000000FFFFFFFF)

```csharp
public static readonly IPAddress Broadcast = new IPAddress(0x00000000FFFFFFFF)
```

_No description available._

**Returns** `IPAddress Broadcast = new`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

_No description available._

**Returns** `bool`

### GetAddressBytes()

```csharp
public byte[] GetAddressBytes()
```

_No description available._

**Returns** `byte[]`

### TryParse(string ipString, out IPAddress address)

```csharp
public static bool TryParse(string ipString, out IPAddress address)
```

_No description available._

**Returns** `bool`

### Parse(string ipString)

```csharp
public static IPAddress Parse(string ipString)
```

_No description available._

**Returns** `IPAddress`

### GetHashCode()

```csharp
public override int GetHashCode()
```

_No description available._

**Returns** `int`

### IsLoopback(IPAddress address)

```csharp
public static bool IsLoopback(IPAddress address)
```

_No description available._

**Returns** `bool`

### HostToNetworkOrder(short host)

```csharp
public static short HostToNetworkOrder(short host)
```

_No description available._

**Returns** `short`

### HostToNetworkOrder(int host)

```csharp
public static int HostToNetworkOrder(int host)
```

_No description available._

**Returns** `int`

### HostToNetworkOrder(long host)

```csharp
public static long HostToNetworkOrder(long host)
```

_No description available._

**Returns** `long`

### NetworkToHostOrder(short network)

```csharp
public static short NetworkToHostOrder(short network)
```

_No description available._

**Returns** `short`

### NetworkToHostOrder(int network)

```csharp
public static int NetworkToHostOrder(int network)
```

_No description available._

**Returns** `int`

### NetworkToHostOrder(long network)

```csharp
public static long NetworkToHostOrder(long network)
```

_No description available._

**Returns** `long`

### ToString()

```csharp
public override string ToString()
```

_No description available._

**Returns** `string`

## Fields

### None

```csharp
public static readonly IPAddress None
```

_No description available._
