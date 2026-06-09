---
title: "ConnectReturnCode Enum"
sidebar_label: "ConnectReturnCode"
---

# ConnectReturnCode Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Mqtt`<br/>**Namespace:** `GHIElectronics.TinyCLR.Networking.Mqtt`

Result of a CONNECT request reported by the broker.

```csharp
public enum ConnectReturnCode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `ConnectionAccepted` | `0` | Connection succeeded. |
| `UnacceptableProtocol` | `1` | Broker does not support the requested MQTT protocol version. |
| `IdentifierRejected` | `2` | The supplied client ID is not valid or is in use. |
| `ServerUnavailable` | `3` | Broker reachable but currently rejecting connections. |
| `BadUserNameOrPassword` | `4` | Authentication failed. |
| `NotAuthorized` | `5` | Authenticated client is not authorized for this operation. |
| `Unknown` | `-1` | No CONNACK received or the code didn't match a known value. |
