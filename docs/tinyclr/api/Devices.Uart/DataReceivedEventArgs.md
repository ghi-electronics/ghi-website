---
title: "DataReceivedEventArgs Class"
sidebar_label: "DataReceivedEventArgs"
---

# DataReceivedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`

Arguments for `UartController.DataReceived`.

```csharp
public class DataReceivedEventArgs
```

## Properties

### Count

```csharp
public int Count { get; }
```

Number of bytes that have just become available to read.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the receive event.
