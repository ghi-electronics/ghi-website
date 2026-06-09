---
title: "JArray Class"
sidebar_label: "JArray"
---

# JArray Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

A JSON array — an ordered sequence of `JToken` elements.

```csharp
public class JArray : JToken
```

## Constructors

### JArray()

```csharp
public JArray()
```

_No description available._

### JArray(JToken[] values)

```csharp
public JArray(JToken[] values)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `values` | `JToken[]` |  |

## Properties

### Length

```csharp
public int Length { get; }
```

Gets length of bytes in the stream. _(inherited)_

### Items

```csharp
public JToken[] Items { get; }
```

_No description available._

### i]

```csharp
public JToken this[int i] { get; }
```

Gets an individual member of the collection. _(inherited)_

## Methods

### Serialize(Type type, object oSource, JsonSerializerSettings settings)

```csharp
public static JArray Serialize(Type type, object oSource, JsonSerializerSettings settings = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `type` | `Type` |  |
| `oSource` | `object` |  |
| `settings` | `JsonSerializerSettings` |  |

**Returns** `JArray`

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`

### ToString(JsonSerializationOptions options)

```csharp
public override string ToString(JsonSerializationOptions options)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `options` | `JsonSerializationOptions` |  |

**Returns** `string`

### GetBsonSize()

```csharp
public override int GetBsonSize()
```

_No description available._

**Returns** `int`

### GetBsonSize(string ename)

```csharp
public override int GetBsonSize(string ename)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `ename` | `string` |  |

**Returns** `int`

### ToBson(byte[] buffer, ref int offset)

```csharp
public override void ToBson(byte[] buffer, ref int offset)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `ref int` |  |

### GetBsonType()

```csharp
public override BsonTypes GetBsonType()
```

_No description available._

**Returns** `BsonTypes`
