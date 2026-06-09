---
title: "ProtocolViolationException Class"
sidebar_label: "ProtocolViolationException"
---

# ProtocolViolationException Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Namespace:** `System.Net`

The exception that is thrown when an error is made while using a network protocol.

```csharp
public class ProtocolViolationException : InvalidOperationException
```

## Constructors

### ProtocolViolationException()

```csharp
public ProtocolViolationException()
```

Initializes a new instance of the ProtocolViolationException class.

### ProtocolViolationException(string message)

```csharp
public ProtocolViolationException(string message) : base(message)
```

Initializes a new instance of the ProtocolViolationException class with the specified message.

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` | The error message string. |
