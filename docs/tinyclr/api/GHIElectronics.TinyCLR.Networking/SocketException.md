---
title: "SocketException Class"
sidebar_label: "SocketException"
---

# SocketException Class

**Namespace:** `System.Net.Sockets` · **Assembly:** `GHIElectronics.TinyCLR.Networking`

_No description available._

```csharp
public class SocketException : Exception
```

## Constructors

### SocketException()

```csharp
public SocketException() : this((int)SocketError.SocketError)
```

_No description available._

### SocketException(SocketError errorCode)

```csharp
public SocketException(SocketError errorCode) : this((int)errorCode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `errorCode` | `SocketError` |  |

### SocketException(int errorCode)

```csharp
public SocketException(int errorCode)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `errorCode` | `int` |  |

## Properties

### SocketErrorCode

```csharp
public SocketError SocketErrorCode { get; }
```

_No description available._

### ErrorCode

```csharp
public int ErrorCode { get; }
```

Gets the modbus error code _(inherited)_

### Message

```csharp
public override string Message { get; }
```

_No description available._
