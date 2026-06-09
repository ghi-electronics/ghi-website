---
title: "GHIElectronics.TinyCLR.Networking.Mqtt"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Networking.Mqtt NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Mqtt](./Mqtt.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | MQTT client. Construct with an `MqttClientSetting`, call `Connect` with an `MqttConnectionSetting`, subscribe to topics, and publish messages. Asynchronous events deliver inbound traffic. |
| [MqttClientSetting](./MqttClientSetting.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Transport-level MQTT settings — broker host/port, TLS, certificates. |
| [MqttConnectionSetting](./MqttConnectionSetting.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Per-session MQTT settings — client ID, credentials, last-will, keepalive. |
| [MqttPacket](./MqttPacket.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [ConnectReturnCode](./ConnectReturnCode.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Result of a CONNECT request reported by the broker. |
| [PacketType](./PacketType.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |
| [QoSLevel](./QoSLevel.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | MQTT Quality-of-Service level. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [ConnectedEventHandler](./ConnectedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |
| [PublishedEventHandler](./PublishedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |
| [PublishReceivedEventHandler](./PublishReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |
| [SubscribedEventHandler](./SubscribedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |
| [UnsubscribedEventHandler](./UnsubscribedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` |  |
