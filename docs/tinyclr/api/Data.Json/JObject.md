---
title: "JObject Class"
sidebar_label: "JObject"
---

# JObject Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

A JSON object — an unordered map of name/`JToken` pairs.

```csharp
public class JObject : JToken
```

## Properties

### name]

```csharp
public JProperty this[string name] { get; set; }
```

_No description available._

### Members

```csharp
public ICollection Members { get; }
```

_No description available._

## Methods

### Contains(string name)

```csharp
public bool Contains(string name)
```

Determines whether a element is in the UIElementCollection. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `bool`

### Add(string name, JToken value)

```csharp
public void Add(string name, JToken value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `value` | `JToken` |  |

### Serialize(Type type, object oSource, JsonSerializerSettings settings)

```csharp
public static JObject Serialize(Type type, object oSource, JsonSerializerSettings settings = null)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `type` | `Type` |  |
| `oSource` | `object` |  |
| `settings` | `JsonSerializerSettings` |  |

**Returns** `JObject`

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
