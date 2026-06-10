---
title: "GHIElectronics.TinyCLR.Networking.Mqtt"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Networking.Mqtt</h1>

**NuGet:** `GHIElectronics.TinyCLR.Networking.Mqtt`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Mqtt](./Mqtt.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | MQTT client. Construct with an `MqttClientSetting`, call `Connect` with an `MqttConnectionSetting`, subscribe to topics, and publish messages. Asynchronous events deliver inbound traffic. |
| [MqttClientSetting](./MqttClientSetting.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Transport-level MQTT settings — broker host/port, TLS, certificates. |
| [MqttConnectionSetting](./MqttConnectionSetting.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Per-session MQTT settings — client ID, credentials, last-will, keepalive. |
| [MqttPacket](./MqttPacket.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Represents a single MQTT control packet and encodes it to bytes for sending. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [ConnectReturnCode](./ConnectReturnCode.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Result of a CONNECT request reported by the broker. |
| [PacketType](./PacketType.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Identifies the type of an MQTT control packet. |
| [QoSLevel](./QoSLevel.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | MQTT Quality-of-Service level. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [ConnectedEventHandler](./ConnectedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Handles a change in the connection state with the broker. |
| [PublishedEventHandler](./PublishedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Handles the result of a publish request. |
| [PublishReceivedEventHandler](./PublishReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Handles a message received on a subscribed topic. |
| [SubscribedEventHandler](./SubscribedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Handles a completed subscribe request and the granted quality-of-service levels. |
| [UnsubscribedEventHandler](./UnsubscribedEventHandler.md) | `GHIElectronics.TinyCLR.Networking.Mqtt` | Handles a completed unsubscribe request. |
