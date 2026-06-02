---
title: "GHIElectronics.TinyCLR.Networking.Mqtt"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Networking.Mqtt

NuGet package containing **12** types.

## Classes

| Class | Summary |
|---|---|
| [Mqtt](./Mqtt.md) | MQTT client. Construct with an `MqttClientSetting`, call `Connect` with an `MqttConnectionSetting`, subscribe to topics, and publish messages. Asynchronous events deliver inbound traffic. |
| [MqttClientSetting](./MqttClientSetting.md) | Transport-level MQTT settings — broker host/port, TLS, certificates. |
| [MqttConnectionSetting](./MqttConnectionSetting.md) | Per-session MQTT settings — client ID, credentials, last-will, keepalive. |
| [MqttPacket](./MqttPacket.md) |  |

## Enums

| Enum | Summary |
|---|---|
| [ConnectReturnCode](./ConnectReturnCode.md) | Result of a CONNECT request reported by the broker. |
| [PacketType](./PacketType.md) |  |
| [QoSLevel](./QoSLevel.md) | MQTT Quality-of-Service level. |

## Delegates

| Delegate | Summary |
|---|---|
| [ConnectedEventHandler](./ConnectedEventHandler.md) |  |
| [PublishedEventHandler](./PublishedEventHandler.md) |  |
| [PublishReceivedEventHandler](./PublishReceivedEventHandler.md) |  |
| [SubscribedEventHandler](./SubscribedEventHandler.md) |  |
| [UnsubscribedEventHandler](./UnsubscribedEventHandler.md) |  |
