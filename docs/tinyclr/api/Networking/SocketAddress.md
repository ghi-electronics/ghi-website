---
title: "SocketAddress Class"
sidebar_label: "SocketAddress"
---

# SocketAddress Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

_No description available._

```csharp
public class SocketAddress
```

## Constructors

### SocketAddress(AddressFamily family, int size)

```csharp
public SocketAddress(AddressFamily family, int size)
```

_No description available._

## Properties

### Family

```csharp
public AddressFamily Family { get; }
```

_No description available._

### Size

```csharp
public int Size { get; }
```

_No description available._

### offset]

```csharp
public byte this[int offset] { get; set; }
```

_No description available._

## Methods

### Equals(object comparand)

```csharp
public override bool Equals(object comparand)
```

_No description available._

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

_No description available._

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

_No description available._

**Returns** `string`
