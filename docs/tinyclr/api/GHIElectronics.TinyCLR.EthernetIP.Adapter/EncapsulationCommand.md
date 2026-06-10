---
title: "EncapsulationCommand Enum"
sidebar_label: "EncapsulationCommand"
---

# EncapsulationCommand Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

EtherNet/IP encapsulation command codes reported by the explicit-data events.

```csharp
public enum EncapsulationCommand : ushort
```

## Fields

| Name | Value | Description |
|---|---|---|
| `NoOperation` | `0x0000` | No operation (TCP only). |
| `ListServices` | `0x0004` | List Services command (TCP and UDP). |
| `ListIdentity` | `0x0063` | List Identity command (TCP and UDP). |
| `ListInterfaces` | `0x0064` | List Interfaces command (optional, TCP and UDP). |
| `RegisterSession` | `0x0065` | Register Session command (TCP only). |
| `UnregisterSession` | `0x0066` | Unregister Session command (TCP only). |
| `SendRequestReplyData` | `0x006F` | Send RR (request/reply) Data command (TCP only). |
| `SendUnitData` | `0x0070` | Send Unit Data command (TCP only). |
