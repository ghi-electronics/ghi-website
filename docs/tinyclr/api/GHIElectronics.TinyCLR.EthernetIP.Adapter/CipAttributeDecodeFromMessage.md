---
title: "CipAttributeDecodeFromMessage Enum"
sidebar_label: "CipAttributeDecodeFromMessage"
---

# CipAttributeDecodeFromMessage Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Selects the native function used to decode an attribute value from a received message.

```csharp
public enum CipAttributeDecodeFromMessage : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No decode function. |
| `DecodeCipBool` | `0x01` | Decode a CIP BOOL value. |
| `DecodeCipByte` | `0x02` | Decode a CIP BYTE value. |
| `DecodeCipByteArray` | `0x4` | Decode a CIP byte array value. |
| `DecodeCipWord` | `0x8` | Decode a CIP WORD value. |
| `DecodeCipDword` | `0x10` | Decode a CIP DWORD value. |
| `DecodeCipLword` | `0x20` | Decode a CIP LWORD value. |
| `DecodeCipUsint` | `0x40` | Decode a CIP USINT value. |
| `DecodeCipUint` | `0x80` | Decode a CIP UINT value. |
| `DecodeCipUdint` | `0x100` | Decode a CIP UDINT value. |
| `DecodeCipUlint` | `0x200` | Decode a CIP ULINT value. |
| `DecodeCipSint` | `0x400` | Decode a CIP SINT value. |
| `DecodeCipInt` | `0x800` | Decode a CIP INT value. |
| `DecodeCipDint` | `0x1000` | Decode a CIP DINT value. |
| `DecodeCipLint` | `0x2000` | Decode a CIP LINT value. |
| `DecodeCipReal` | `0x4000` | Decode a CIP REAL value. |
| `DecodeCipLreal` | `0x8000` | Decode a CIP LREAL value. |
| `DecodeCipString` | `0x10000` | Decode a CIP STRING value. |
| `DecodeCipShortString` | `0x20000` | Decode a CIP SHORT_STRING value. |
