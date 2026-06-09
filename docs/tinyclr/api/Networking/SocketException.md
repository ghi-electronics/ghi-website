---
title: "SocketException Class"
sidebar_label: "SocketException"
---

# SocketException Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Sockets`

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

### SocketException(int errorCode)

```csharp
public SocketException(int errorCode)
```

_No description available._

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

_No description available._

### Message

```csharp
public override string Message { get; }
```

_No description available._
