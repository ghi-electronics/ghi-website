---
title: "MessageReceivedEventArgs Class"
sidebar_label: "MessageReceivedEventArgs"
---

# MessageReceivedEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Can` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Can`

Arguments for `CanController.MessageReceived`.

```csharp
public class MessageReceivedEventArgs
```

## Properties

### Count

```csharp
public int Count { get; }
```

Number of messages that have just become available.

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the receive event.
