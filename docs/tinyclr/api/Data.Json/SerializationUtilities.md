---
title: "SerializationUtilities Class"
sidebar_label: "SerializationUtilities"
---

# SerializationUtilities Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

Helpers for marshalling primitive values to and from a BSON byte buffer.

```csharp
public static class SerializationUtilities
```

## Methods

### Marshall(byte[] buffer, ref int offset, object arg)

```csharp
public static void Marshall(byte[] buffer, ref int offset, object arg)
```

Writes a primitive value into the buffer at the given offset, advancing it.

### Unmarshall(byte[] buffer, ref int offset, TypeCode tc)

```csharp
public static object Unmarshall(byte[] buffer, ref int offset, TypeCode tc)
```

Reads a value of the given type code from the buffer at the offset, advancing it.

**Returns** `object`
