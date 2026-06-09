---
title: "JValue Class"
sidebar_label: "JValue"
---

# JValue Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

A JSON primitive value — string, number, boolean, or null.

```csharp
public class JValue : JToken
```

## Constructors

### JValue()

```csharp
public JValue()
```

_No description available._

### JValue(object value)

```csharp
public JValue(object value)
```

_No description available._

## Properties

### Value

```csharp
public object Value { get; set; }
```

_No description available._

## Methods

### Serialize(Type type, object oValue)

```csharp
public static JValue Serialize(Type type, object oValue)
```

_No description available._

**Returns** `JValue`

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
