---
title: "StatusEnum Enum"
sidebar_label: "StatusEnum"
---

# StatusEnum Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

Table 2-3.3 Error Codes

```csharp
public enum StatusEnum : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Success` | `0x0000` | The request completed successfully. |
| `InvalidCommand` | `0x0001` | The encapsulation command was not recognized. |
| `InsufficientMemory` | `0x0002` | The receiver had insufficient memory to handle the request. |
| `IncorrectData` | `0x0003` | The command-specific data was malformed or incorrect. |
| `InvalidSessionHandle` | `0x0064` | The supplied session handle was not valid. |
| `InvalidLength` | `0x0065` | The packet length field did not match the actual data. |
| `UnsupportedEncapsulationProtocol` | `0x0069` | The requested encapsulation protocol version is not supported. |
