---
title: "BsonTypes Enum"
sidebar_label: "BsonTypes"
---

# BsonTypes Enum

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

BSON element type codes used when encoding tokens to BSON.

```csharp
public enum BsonTypes : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `BsonDouble` | `0x01` | 64-bit floating point value. |
| `BsonString` | `0x02` | UTF-8 string value. |
| `BsonDocument` | `0x03` | Embedded document (object). |
| `BsonArray` | `0x04` | Array value. |
| `BsonBoolean` | `0x08` | Boolean value. |
| `BsonDateTime` | `0x09` | UTC date-time value. |
| `BsonNull` | `0x0a` | Null value. |
| `BsonInt32` | `0x10` | 32-bit signed integer value. |
| `BsonInt64` | `0x12` | 64-bit signed integer value. |
