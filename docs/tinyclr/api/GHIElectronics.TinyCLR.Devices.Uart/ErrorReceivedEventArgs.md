---
title: "ErrorReceivedEventArgs Class"
sidebar_label: "ErrorReceivedEventArgs"
---

# ErrorReceivedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart`

Arguments for `UartController.ErrorReceived`.

```csharp
public class ErrorReceivedEventArgs
```

## Properties

### Error

```csharp
public UartError Error { get; }
```

The kind of error detected.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the error.
