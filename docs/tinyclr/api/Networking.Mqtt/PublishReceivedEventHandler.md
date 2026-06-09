---
title: "PublishReceivedEventHandler Delegate"
sidebar_label: "PublishReceivedEventHandler"
---

# PublishReceivedEventHandler Delegate

**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`

_No description available._

```csharp
public delegate void PublishReceivedEventHandler(object sender, string topic, byte[] data, bool duplicate, QoSLevel qosLevel, bool retain);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `sender` | `object` |  |
| `topic` | `string` |  |
| `data` | `byte[]` |  |
| `duplicate` | `bool` |  |
| `qosLevel` | `QoSLevel` |  |
| `retain` | `bool` |  |
