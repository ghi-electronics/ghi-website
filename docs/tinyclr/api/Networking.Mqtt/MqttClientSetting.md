---
title: "MqttClientSetting Class"
sidebar_label: "MqttClientSetting"
---

# MqttClientSetting Class

**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`

Transport-level MQTT settings — broker host/port, TLS, certificates.

```csharp
public class MqttClientSetting
```

## Properties

### BrokerName

```csharp
public string BrokerName { get; set; }
```

_No description available._

### BrokerPort

```csharp
public int BrokerPort { get; set; }
```

_No description available._

### CaCertificate

```csharp
public X509Certificate CaCertificate { get; set; }
```

_No description available._

### ClientCertificate

```csharp
public X509Certificate ClientCertificate { get; set; }
```

_No description available._

### SslProtocol

```csharp
public SslProtocols SslProtocol { get; set; }
```

_No description available._
