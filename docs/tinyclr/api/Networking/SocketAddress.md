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

| Parameter | Type | Description |
|---|---|---|
| `family` | `AddressFamily` |  |
| `size` | `int` |  |

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

Total size of the loaded image. _(inherited)_

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

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `comparand` | `object` |  |

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table _(inherited)_

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`
