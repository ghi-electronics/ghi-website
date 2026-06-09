---
title: "ClearToSendChangedEventArgs Class"
sidebar_label: "ClearToSendChangedEventArgs"
---

# ClearToSendChangedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`

Arguments for `UartController.ClearToSendChanged`.

```csharp
public sealed class ClearToSendChangedEventArgs
```

## Properties

### State

```csharp
public bool State { get; }
```

New CTS state.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the transition.
