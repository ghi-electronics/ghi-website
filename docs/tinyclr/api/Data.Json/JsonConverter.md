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

Lock object guarding access to the shared serialization context.

**Returns** `object SyncObj = new`

### Serialize(object oSource, JsonSerializerSettings settings)

```csharp
public static JToken Serialize(object oSource, JsonSerializerSettings settings = null)
```

Serializes an object into a JSON token tree.

**Returns** `JToken`

### DeserializeObject(string sourceString, Type type, InstanceFactory factory)

```csharp
public static object DeserializeObject(string sourceString, Type type, InstanceFactory factory = null)
```

Parses JSON text and populates a new instance of the given type.

**Returns** `object`

### DeserializeObject(Stream stream, Type type, InstanceFactory factory)

```csharp
public static object DeserializeObject(Stream stream, Type type, InstanceFactory factory = null)
```

Parses JSON from a stream and populates a new instance of the given type.

**Returns** `object`

### DeserializeObject(StreamReader sr, Type type, InstanceFactory factory)

```csharp
public static object DeserializeObject(StreamReader sr, Type type, InstanceFactory factory = null)
```

Parses JSON from a reader and populates a new instance of the given type.

**Returns** `object`

### Deserialize(string sourceString)

```csharp
public static JToken Deserialize(string sourceString)
```

Parses JSON text into a token tree.

**Returns** `JToken`

### Deserialize(Stream sourceStream)

```csharp
public static JToken Deserialize(Stream sourceStream)
```

Parses JSON from a stream into a token tree.

**Returns** `JToken`

### Deserialize(StreamReader sourceReader)

```csharp
public static JToken Deserialize(StreamReader sourceReader)
```

Parses JSON from a reader into a token tree.

**Returns** `JToken`

### FromBson(byte[] buffer, InstanceFactory factory)

```csharp
public static JToken FromBson(byte[] buffer, InstanceFactory factory = null)
```

Decodes a BSON byte buffer into a JSON token tree.

**Returns** `JToken`

### FromBson(byte[] buffer, Type resultType, InstanceFactory factory)

```csharp
public static object FromBson(byte[] buffer, Type resultType, InstanceFactory factory = null)
```

Decodes a BSON byte buffer and populates a new instance of the given type.

**Returns** `object`

## Fields

### SerializationContext

```csharp
public static SerializationCtx SerializationContext
```

The serialization context shared across the current serialization pass.
