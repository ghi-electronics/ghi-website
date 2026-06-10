---
title: "MqttClientSetting Class"
sidebar_label: "MqttClientSetting"
---

# MqttClientSetting Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt`

Transport-level MQTT settings — broker host/port, TLS, certificates.

```csharp
public class MqttClientSetting
```

## Properties

### BrokerName

```csharp
public string BrokerName { get; set; }
```

The host name or address of the MQTT broker.

### BrokerPort

```csharp
public int BrokerPort { get; set; }
```

The TCP port of the MQTT broker.

### CaCertificate

```csharp
public X509Certificate CaCertificate { get; set; }
```

The certificate authority certificate used to validate the broker.

### ClientCertificate

```csharp
public X509Certificate ClientCertificate { get; set; }
```

The client certificate presented to the broker for mutual TLS.

### SslProtocol

```csharp
public SslProtocols SslProtocol { get; set; }
```

The TLS protocol to use, or None for an unencrypted connection.
