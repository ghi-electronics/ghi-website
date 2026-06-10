---
title: "MqttConnectionSetting Class"
sidebar_label: "MqttConnectionSetting"
---

# MqttConnectionSetting Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt`

Per-session MQTT settings — client ID, credentials, last-will, keepalive.

```csharp
public class MqttConnectionSetting
```

## Properties

### ClientId

```csharp
public string ClientId { get; set; }
```

The unique client identifier presented to the broker.

### CleanSession

```csharp
public bool CleanSession { get; set; }
```

Whether the broker should start a clean session rather than resume a previous one.

### UserName

```csharp
public string UserName { get; set; }
```

The user name used to authenticate with the broker.

### Password

```csharp
public string Password { get; set; }
```

The password used to authenticate with the broker.

### LastWillTopic

```csharp
public string LastWillTopic { get; set; }
```

The topic the broker publishes the last-will message to if the client disconnects unexpectedly.

### LastWillQos

```csharp
public QoSLevel LastWillQos { get; set; }
```

The quality-of-service level used for the last-will message.

### LastWillMessage

```csharp
public string LastWillMessage { get; set; }
```

The message the broker publishes if the client disconnects unexpectedly.

### LastWillRetain

```csharp
public bool LastWillRetain { get; set; }
```

Whether the broker should retain the last-will message.

### KeepAliveTimeout

```csharp
public int KeepAliveTimeout { get; set; }
```

The keep-alive interval, in seconds, between client communications.
