---
title: "QoSLevel Enum"
sidebar_label: "QoSLevel"
---

# QoSLevel Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt`

MQTT Quality-of-Service level.

```csharp
public enum QoSLevel
```

## Fields

| Name | Value | Description |
|---|---|---|
| `AtMostOnce` | `0` | Fire-and-forget; the message may be lost. |
| `AtLeastOnce` | `1` | Acknowledged delivery; the message may be delivered more than once. |
| `ExactlyOnce` | `2` | Acknowledged delivery; the message is delivered exactly once. |
