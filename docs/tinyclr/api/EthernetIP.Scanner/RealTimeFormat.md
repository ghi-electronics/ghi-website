---
title: "RealTimeFormat Enum"
sidebar_label: "RealTimeFormat"
---

# RealTimeFormat Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

The real-time data format used for one direction of a Class-1 implicit connection.

```csharp
public enum RealTimeFormat : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Modeless` | `0` | Pure data with no run/idle header. |
| `ZeroLength` | `1` | Zero-length data (idle indication only). |
| `Heartbeat` | `2` | Heartbeat with no data payload. |
| `Header32Bit` | `3` | 32-bit run/idle real-time header preceding the data. |
