---
title: "EndPoint Class"
sidebar_label: "EndPoint"
---

# EndPoint Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

_No description available._

```csharp
public abstract class EndPoint
```

## Properties

### AddressFamily

```csharp
public virtual AddressFamily AddressFamily { get; }
```

_No description available._

## Methods

### Serialize()

```csharp
public abstract SocketAddress Serialize()
```

_No description available._

**Returns** `SocketAddress`

### Create(SocketAddress socketAddress)

```csharp
public abstract EndPoint Create(SocketAddress socketAddress)
```

Creates a WebRequest . _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `socketAddress` | `SocketAddress` |  |

**Returns** `EndPoint`
