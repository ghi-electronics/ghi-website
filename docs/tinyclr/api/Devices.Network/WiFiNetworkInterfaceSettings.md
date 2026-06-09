---
title: "WiFiNetworkInterfaceSettings Class"
sidebar_label: "WiFiNetworkInterfaceSettings"
---

# WiFiNetworkInterfaceSettings Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network`

WiFi-specific interface settings.

```csharp
public class WiFiNetworkInterfaceSettings : NetworkInterfaceSettings
```

## Properties

### Ssid

```csharp
public string Ssid { get; set; }
```

Network SSID. In Station mode, the AP to join; in AccessPoint mode, the SSID to broadcast.

### Password

```csharp
public string Password { get; set; }
```

Pre-shared key for WPA/WPA2 / WEP.

### Channel

```csharp
public uint Channel { get; set; }
```

AP channel (1..13). AccessPoint mode only.

### Mode

```csharp
public WiFiMode Mode { get; set; }
```

WiFi role — Station or AccessPoint.

### SecurityMode

```csharp
public WiFiSecurityMode SecurityMode { get; set; }
```

Encryption protocol for the WiFi connection.

## Events

### AccessPointClientConnectionChanged

```csharp
public event AccessPointClientConnectionChangedEventHandler AccessPointClientConnectionChanged
```

Raised when a station connects to this access point.
