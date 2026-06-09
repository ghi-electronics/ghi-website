---
title: "SerializationUtilities Class"
sidebar_label: "SerializationUtilities"
---

# SerializationUtilities Class

**Namespace:** `GHIElectronics.TinyCLR.Data.Json` · **Assembly:** `GHIElectronics.TinyCLR.Data.Json`

_No description available._

```csharp
public static class SerializationUtilities
```

## Methods

### Marshall(byte[] buffer, ref int offset, object arg)

```csharp
public static void Marshall(byte[] buffer, ref int offset, object arg)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `ref int` |  |
| `arg` | `object` |  |

### Unmarshall(byte[] buffer, ref int offset, TypeCode tc)

```csharp
public static object Unmarshall(byte[] buffer, ref int offset, TypeCode tc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `ref int` |  |
| `tc` | `TypeCode` |  |

**Returns** `object`
