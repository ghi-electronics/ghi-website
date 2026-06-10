---
title: "CipAttributeEncodeInMessage Enum"
sidebar_label: "CipAttributeEncodeInMessage"
---

# CipAttributeEncodeInMessage Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Selects the native function used to encode an attribute value into an outgoing message.

```csharp
public enum CipAttributeEncodeInMessage : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No encode function. |
| `EncodeCipBool` | `0x01` | Encode a CIP BOOL value. |
| `EncodeCipByte` | `0x02` | Encode a CIP BYTE value. |
| `EncodeCipWord` | `0x4` | Encode a CIP WORD value. |
| `EncodeCipDword` | `0x8` | Encode a CIP DWORD value. |
| `EncodeCipLword` | `0x10` | Encode a CIP LWORD value. |
| `EncodeCipUsint` | `0x20` | Encode a CIP USINT value. |
| `EncodeCipUint` | `0x40` | Encode a CIP UINT value. |
| `EncodeCipUdint` | `0x80` | Encode a CIP UDINT value. |
| `EncodeCipUlint` | `0x100` | Encode a CIP ULINT value. |
| `EncodeCipSint` | `0x200` | Encode a CIP SINT value. |
| `EncodeCipInt` | `0x400` | Encode a CIP INT value. |
| `EncodeCipDint` | `0x800` | Encode a CIP DINT value. |
| `EncodeCipLint` | `0x1000` | Encode a CIP LINT value. |
| `EncodeCipReal` | `0x2000` | Encode a CIP REAL value. |
| `EncodeCipLreal` | `0x4000` | Encode a CIP LREAL value. |
| `EncodeCipShortString` | `0x8000` | Encode a CIP SHORT_STRING value. |
| `EncodeCipString` | `0x10000` | Encode a CIP STRING value. |
| `EncodeCipString2` | `0x20000` | Encode a CIP STRING2 value. |
| `EncodeCipStringN` | `0x40000` | Encode a CIP STRINGN value. |
| `EncodeCipStringI` | `0x80000` | Encode a CIP STRINGI value. |
| `EncodeCipByteArray` | `0x100000` | Encode a CIP byte array value. |
| `EncodeCipEPath` | `0x2000000` | Encode a padded CIP EPATH value. |
| `EncodeEPath` | `0x4000000` | Encode a packed EPATH value. |
| `EncodeCipEthernetLinkPhyisicalAddress` | `0x8000000` | Encode an Ethernet Link object physical (MAC) address. |
