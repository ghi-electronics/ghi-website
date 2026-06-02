---
title: "JProperty Class"
sidebar_label: "JProperty"
---

# JProperty Class

**Namespace:** `GHIElectronics.TinyCLR.Data.Json` · **Assembly:** `GHIElectronics.TinyCLR.Data.Json`

A name/value pair inside a `JObject`.

```csharp
public class JProperty : JToken
```

## Constructors

### JProperty()

```csharp
public JProperty()
```

_No description available._

### JProperty(string name, JToken value)

```csharp
public JProperty(string name, JToken value)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |
| `value` | `JToken` |  |

## Properties

### Name

```csharp
public string Name { get; set; }
```

The native API name. _(inherited)_

### Value

```csharp
public JToken Value { get; set; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_

## Methods

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
