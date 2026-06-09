---
title: "JsonConverter Class"
sidebar_label: "JsonConverter"
---

# JsonConverter Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

Parses JSON text into a `JToken` tree and serializes objects back to JSON. Strict-on-emit, generous-on-accept per RFC 8259.

```csharp
public static class JsonConverter
```

## Methods

### object()

```csharp
public static object SyncObj = new object()
```

_No description available._

**Returns** `object SyncObj = new`

### Serialize(object oSource, JsonSerializerSettings settings)

```csharp
public static JToken Serialize(object oSource, JsonSerializerSettings settings = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `oSource` | `object` |  |
| `settings` | `JsonSerializerSettings` |  |

**Returns** `JToken`

### DeserializeObject(string sourceString, Type type, InstanceFactory factory)

```csharp
public static object DeserializeObject(string sourceString, Type type, InstanceFactory factory = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `sourceString` | `string` |  |
| `type` | `Type` |  |
| `factory` | `InstanceFactory` |  |

**Returns** `object`

### DeserializeObject(Stream stream, Type type, InstanceFactory factory)

```csharp
public static object DeserializeObject(Stream stream, Type type, InstanceFactory factory = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `stream` | `Stream` |  |
| `type` | `Type` |  |
| `factory` | `InstanceFactory` |  |

**Returns** `object`

### DeserializeObject(StreamReader sr, Type type, InstanceFactory factory)

```csharp
public static object DeserializeObject(StreamReader sr, Type type, InstanceFactory factory = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `sr` | `StreamReader` |  |
| `type` | `Type` |  |
| `factory` | `InstanceFactory` |  |

**Returns** `object`

### Deserialize(string sourceString)

```csharp
public static JToken Deserialize(string sourceString)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `sourceString` | `string` |  |

**Returns** `JToken`

### Deserialize(Stream sourceStream)

```csharp
public static JToken Deserialize(Stream sourceStream)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `sourceStream` | `Stream` |  |

**Returns** `JToken`

### Deserialize(StreamReader sourceReader)

```csharp
public static JToken Deserialize(StreamReader sourceReader)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `sourceReader` | `StreamReader` |  |

**Returns** `JToken`

### FromBson(byte[] buffer, InstanceFactory factory)

```csharp
public static JToken FromBson(byte[] buffer, InstanceFactory factory = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `factory` | `InstanceFactory` |  |

**Returns** `JToken`

### FromBson(byte[] buffer, Type resultType, InstanceFactory factory)

```csharp
public static object FromBson(byte[] buffer, Type resultType, InstanceFactory factory = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `resultType` | `Type` |  |
| `factory` | `InstanceFactory` |  |

**Returns** `object`

## Fields

### SerializationContext

```csharp
public static SerializationCtx SerializationContext
```

_No description available._
