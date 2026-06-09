---
title: "PppAuthenticationType Enum"
sidebar_label: "PppAuthenticationType"
---

# PppAuthenticationType Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network`

PPP authentication protocol.

```csharp
public enum PppAuthenticationType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No authentication. |
| `Any` | `1` | Allow whichever the peer offers (PAP or CHAP). |
| `Pap` | `2` | PAP — Password Authentication Protocol (cleartext). |
| `Chap` | `3` | CHAP — Challenge-Handshake Authentication Protocol. |
