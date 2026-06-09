---
title: "ErrorReceivedEventArgs Class"
sidebar_label: "ErrorReceivedEventArgs"
---

# ErrorReceivedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Can` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Can`

Arguments for `CanController.ErrorReceived`.

```csharp
public class ErrorReceivedEventArgs
```

## Properties

### Error

```csharp
public CanError Error { get; }
```

The kind of error reported.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the error.
