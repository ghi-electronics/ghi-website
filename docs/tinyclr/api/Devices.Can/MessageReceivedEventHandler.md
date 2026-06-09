---
title: "MessageReceivedEventHandler Delegate"
sidebar_label: "MessageReceivedEventHandler"
---

# MessageReceivedEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Can`

Handler signature for `CanController.MessageReceived`.

```csharp
public delegate void MessageReceivedEventHandler(CanController sender, MessageReceivedEventArgs e);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `CanController` |  |
| `e` | `MessageReceivedEventArgs` |  |
