---
title: "MulticastOption Class"
sidebar_label: "MulticastOption"
---

# MulticastOption Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

Contains IP address values for setting IP multicast options.

```csharp
public class MulticastOption
```

## Constructors

### MulticastOption(IPAddress group, IPAddress mcint)

```csharp
public MulticastOption(IPAddress group, IPAddress mcint)
```

Initializes a new instance for the specified multicast group and local address.

### MulticastOption(IPAddress group)

```csharp
public MulticastOption(IPAddress group)
```

Initializes a new instance for the specified multicast group using the default local address.

## Properties

### Group

```csharp
public IPAddress Group { get; set; }
```

The IP address of the multicast group.

### LocalAddress

```csharp
public IPAddress LocalAddress { get; set; }
```

The local address associated with the multicast group.

### InterfaceIndex

```csharp
public int InterfaceIndex { get; set; }
```

The index of the local network interface to use for the multicast group.

## Methods

### ToBytes()

```csharp
public byte[] ToBytes()
```

Returns the multicast group and local addresses as a byte array.

**Returns** `byte[]`
