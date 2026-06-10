---
title: "ReceivedExplicitTcpDataHandler Delegate"
sidebar_label: "ReceivedExplicitTcpDataHandler"
---

# ReceivedExplicitTcpDataHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Handles an explicit TCP encapsulation command received from a scanner.

```csharp
public delegate void ReceivedExplicitTcpDataHandler(AdapterController adapter, ushort commandCode, IPAddress ipAddress);
```
