---
title: "JProperty Class"
sidebar_label: "JProperty"
---

# JProperty Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

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

## Properties

### Name

```csharp
public string Name { get; set; }
```

_No description available._

### Value

```csharp
public JToken Value { get; set; }
```

_No description available._

## Methods

### ToString()

```csharp
public override string ToString()
```

_No description available._

**Returns** `string`

### ToString(JsonSerializationOptions options)

```csharp
public override string ToString(JsonSerializationOptions options)
```

_No description available._

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

**Returns** `int`

### ToBson(byte[] buffer, ref int offset)

```csharp
public override void ToBson(byte[] buffer, ref int offset)
```

_No description available._

### GetBsonType()

```csharp
public override BsonTypes GetBsonType()
```

_No description available._

**Returns** `BsonTypes`
