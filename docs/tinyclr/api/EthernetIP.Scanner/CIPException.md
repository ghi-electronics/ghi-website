---
title: "CIPException Class"
sidebar_label: "CIPException"
---

# CIPException Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

Thrown when the target returns a non-success CIP general status code.

```csharp
public class CIPException : Exception
```

## Constructors

### CIPException()

```csharp
public CIPException()
```

Initializes a new CIP exception with no message.

### CIPException(string message)

```csharp
public CIPException(string message) : base(message)
```

Initializes a new CIP exception with the given message.

### CIPException(string message, Exception inner)

```csharp
public CIPException(string message, Exception inner) : base(message, inner)
```

Initializes a new CIP exception with the given message and inner exception.
