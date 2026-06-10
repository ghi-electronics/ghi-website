---
title: "CIPAttributeFlag Enum"
sidebar_label: "CIPAttributeFlag"
---

# CIPAttributeFlag Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Access and callback flags applied to a CIP attribute.

```csharp
public enum CIPAttributeFlag : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `kNotSetOrGetable` | `0x00` | Neither settable nor gettable. |
| `kGetableAll` | `0x01` | Gettable, also part of the Get Attribute All service. |
| `kGetableSingle` | `0x02` | Gettable via Get Attribute Single. |
| `kSetable` | `0x04` | Settable via Set Attribute. |
| `kSetAndGetAble` | `0x07` | Both settable and gettable. |
| `kGetableSingleAndAll` | `0x03` | Gettable via both single and all. |
| `kGetableAllDummy` | `0x08` | Gettable but a dummy attribute. |
| `kPreGetFunc` | `0x10` | Enable the pre-get callback. |
| `kPostGetFunc` | `0x20` | Enable the post-get callback. |
| `kPreSetFunc` | `0x40` | Enable the pre-set callback. |
| `kPostSetFunc` | `0x80` | Enable the post-set callback. |
| `kNvDataFunc` | `0x80` | Enable the non-volatile data callback (same value as the post-set callback). |
