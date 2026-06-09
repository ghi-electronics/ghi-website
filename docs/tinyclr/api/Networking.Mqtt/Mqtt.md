---
title: "Mqtt Class"
sidebar_label: "Mqtt"
---

# Mqtt Class

**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`

MQTT client. Construct with an `MqttClientSetting`, call `Connect` with an `MqttConnectionSetting`, subscribe to topics, and publish messages. Asynchronous events deliver inbound traffic.

```csharp
public class Mqtt
```

## Constructors

### Mqtt(MqttClientSetting setting)

```csharp
public Mqtt(MqttClientSetting setting)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `setting` | `MqttClientSetting` |  |

## Properties

### IsConnected

```csharp
public bool IsConnected { get; set; }
```

_No description available._

### ClientId

```csharp
public string ClientId { get; }
```

_No description available._

### ClientSetting

```csharp
public MqttClientSetting ClientSetting { get; }
```

_No description available._

### ConnectionSetting

```csharp
public MqttConnectionSetting ConnectionSetting { get; set; }
```

_No description available._

## Methods

### Connect(MqttConnectionSetting setting)

```csharp
public ConnectReturnCode Connect(MqttConnectionSetting setting)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `setting` | `MqttConnectionSetting` |  |

**Returns** `ConnectReturnCode`

### Disconnect()

```csharp
public void Disconnect()
```

_No description available._

### Subscribe(string[] topics, QoSLevel[] qosLevels, ushort packetId)

```csharp
public void Subscribe(string[] topics, QoSLevel[] qosLevels, ushort packetId)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `topics` | `string[]` |  |
| `qosLevels` | `QoSLevel[]` |  |
| `packetId` | `ushort` |  |

### Unsubscribe(string[] topics, ushort packetId)

```csharp
public void Unsubscribe(string[] topics, ushort packetId)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `topics` | `string[]` |  |
| `packetId` | `ushort` |  |

### Publish(string topic, byte[] data, QoSLevel qosLevel, bool retain, ushort packetId)

```csharp
public void Publish(string topic, byte[] data, QoSLevel qosLevel, bool retain, ushort packetId)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `topic` | `string` |  |
| `data` | `byte[]` |  |
| `qosLevel` | `QoSLevel` |  |
| `retain` | `bool` |  |
| `packetId` | `ushort` |  |

## Events

### PublishReceivedChanged

```csharp
public event PublishReceivedEventHandler PublishReceivedChanged
```

_No description available._

### PublishedChanged

```csharp
public event PublishedEventHandler PublishedChanged
```

_No description available._

### SubscribedChanged

```csharp
public event SubscribedEventHandler SubscribedChanged
```

_No description available._

### UnsubscribedChanged

```csharp
public event UnsubscribedEventHandler UnsubscribedChanged
```

_No description available._

### ConnectedChanged

```csharp
public event ConnectedEventHandler ConnectedChanged
```

_No description available._
