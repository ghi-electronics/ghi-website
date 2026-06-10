---
title: "CommandsEnum Enum"
sidebar_label: "CommandsEnum"
---

# CommandsEnum Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

Table 2-3.2 Encapsulation Commands

```csharp
public enum CommandsEnum : ushort
```

## Fields

| Name | Value | Description |
|---|---|---|
| `NOP` | `0x0000` | No-operation command. |
| `ListServices` | `0x0004` | Requests the list of encapsulation services the target supports. |
| `ListIdentity` | `0x0063` | Requests identity information from devices. |
| `ListInterfaces` | `0x0064` | Requests the list of non-CIP communication interfaces. |
| `RegisterSession` | `0x0065` | Opens an encapsulation session with the target. |
| `UnRegisterSession` | `0x0066` | Closes an encapsulation session with the target. |
| `SendRRData` | `0x006F` | Sends an unconnected (explicit) request/response message. |
| `SendUnitData` | `0x0070` | Sends a connected (implicit) data message. |
| `IndicateStatus` | `0x0072` | Requests the target's status. |
| `Cancel` | `0x0073` | Cancels a pending request. |
