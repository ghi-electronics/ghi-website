---
title: "MulticastOption Class"
sidebar_label: "MulticastOption"
---

# MulticastOption Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

_No description available._

```csharp
public class MulticastOption
```

## Constructors

### MulticastOption(IPAddress group, IPAddress mcint)

```csharp
public MulticastOption(IPAddress group, IPAddress mcint)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `group` | `IPAddress` |  |
| `mcint` | `IPAddress` |  |

### MulticastOption(IPAddress group)

```csharp
public MulticastOption(IPAddress group)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `group` | `IPAddress` |  |

## Properties

### Group

```csharp
public IPAddress Group { get; set; }
```

_No description available._

### LocalAddress

```csharp
public IPAddress LocalAddress { get; set; }
```

_No description available._

### InterfaceIndex

```csharp
public int InterfaceIndex { get; set; }
```

The logical device interface index. _(inherited)_

## Methods

### ToBytes()

```csharp
public byte[] ToBytes()
```

_No description available._

**Returns** `byte[]`
