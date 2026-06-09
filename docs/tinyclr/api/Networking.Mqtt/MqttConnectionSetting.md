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

_No description available._

### CleanSession

```csharp
public bool CleanSession { get; set; }
```

_No description available._

### UserName

```csharp
public string UserName { get; set; }
```

Set or get user name. _(inherited)_

### Password

```csharp
public string Password { get; set; }
```

Set or get password. _(inherited)_

### LastWillTopic

```csharp
public string LastWillTopic { get; set; }
```

_No description available._

### LastWillQos

```csharp
public QoSLevel LastWillQos { get; set; }
```

_No description available._

### LastWillMessage

```csharp
public string LastWillMessage { get; set; }
```

_No description available._

### LastWillRetain

```csharp
public bool LastWillRetain { get; set; }
```

_No description available._

### KeepAliveTimeout

```csharp
public int KeepAliveTimeout { get; set; }
```

_No description available._
