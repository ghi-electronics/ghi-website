---
title: "PacketType Enum"
sidebar_label: "PacketType"
---

# PacketType Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt`

Identifies the type of an MQTT control packet.

```csharp
public enum PacketType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Connect` | `1` | Client request to connect to the broker. |
| `ConnAck` | `2` | Broker acknowledgement of a connect request. |
| `Publish` | `3` | Message published to a topic. |
| `PubAck` | `4` | Acknowledgement of a QoS 1 publish. |
| `Pubrec` | `5` | First QoS 2 publish acknowledgement (publish received). |
| `Pubrel` | `6` | Second QoS 2 publish acknowledgement (publish release). |
| `PubComp` | `7` | Final QoS 2 publish acknowledgement (publish complete). |
| `Subscribe` | `8` | Client request to subscribe to one or more topics. |
| `Suback` | `9` | Broker acknowledgement of a subscribe request. |
| `Unsubscribe` | `10` | Client request to unsubscribe from one or more topics. |
| `Unsuback` | `11` | Broker acknowledgement of an unsubscribe request. |
| `PingReq` | `12` | Keep-alive ping request sent to the broker. |
| `PingResp` | `13` | Keep-alive ping response from the broker. |
| `Disconnect` | `14` | Client notification that it is disconnecting. |
