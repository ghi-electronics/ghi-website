---
title: "ErrorReceivedEventArgs Class"
sidebar_label: "ErrorReceivedEventArgs"
---

# ErrorReceivedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c`

Arguments for `I2cDevice.ErrorReceived`.

```csharp
public sealed class ErrorReceivedEventArgs
```

## Properties

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the error.

### Error

```csharp
public I2cError Error { get; }
```

The kind of error detected.

### Address

```csharp
public uint Address { get; }
```

The address (if any) the error was associated with.
