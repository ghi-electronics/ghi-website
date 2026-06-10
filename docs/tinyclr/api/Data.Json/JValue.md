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

Initializes a new JSON value holding null.

### JValue(object value)

```csharp
public JValue(object value)
```

Initializes a new JSON value wrapping the given primitive value.

## Properties

### Value

```csharp
public object Value { get; set; }
```

Gets or sets the underlying primitive value.

## Methods

### Serialize(Type type, object oValue)

```csharp
public static JValue Serialize(Type type, object oValue)
```

Wraps a primitive value in a JSON value.

**Returns** `JValue`

### ToString()

```csharp
public override string ToString()
```

Returns the JSON text for this value.

**Returns** `string`

### ToString(JsonSerializationOptions options)

```csharp
public override string ToString(JsonSerializationOptions options)
```

Returns the JSON text for this value using the given formatting options.

**Returns** `string`

### GetBsonSize()

```csharp
public override int GetBsonSize()
```

Gets the number of bytes this value occupies when encoded as BSON.

**Returns** `int`

### GetBsonSize(string ename)

```csharp
public override int GetBsonSize(string ename)
```

Gets the number of BSON bytes for this value including the given element name.

**Returns** `int`

### ToBson(byte[] buffer, ref int offset)

```csharp
public override void ToBson(byte[] buffer, ref int offset)
```

Writes this value to the buffer as BSON, advancing the offset.

### GetBsonType()

```csharp
public override BsonTypes GetBsonType()
```

Gets the BSON type code matching the underlying value's type.

**Returns** `BsonTypes`
