---
title: "ConnectionType Enum"
sidebar_label: "ConnectionType"
---

# ConnectionType Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

The connection type for one direction of a Class-1 implicit connection.

```csharp
public enum ConnectionType : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Null` | `0` | No connection in this direction. |
| `Multicast` | `1` | Multicast connection. |
| `Point_to_Point` | `2` | Point-to-point (unicast) connection. |
