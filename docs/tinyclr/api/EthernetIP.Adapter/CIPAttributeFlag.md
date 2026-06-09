---
title: "CIPAttributeFlag Enum"
sidebar_label: "CIPAttributeFlag"
---

# CIPAttributeFlag Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

_No description available._

```csharp
public enum CIPAttributeFlag : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `kNotSetOrGetable` | `0x00` |  |
| `kGetableAll` | `0x01` |  |
| `kGetableSingle` | `0x02` |  |
| `kSetable` | `0x04` |  |
| `kSetAndGetAble` | `0x07` |  |
| `kGetableSingleAndAll` | `0x03` |  |
| `kGetableAllDummy` | `0x08` |  |
| `kPreGetFunc` | `0x10` |  |
| `kPostGetFunc` | `0x20` |  |
| `kPreSetFunc` | `0x40` |  |
| `kPostSetFunc` | `0x80` |  |
| `kNvDataFunc` | `0x80` |  |
