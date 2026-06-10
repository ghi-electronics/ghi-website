---
title: "JToken Class"
sidebar_label: "JToken"
---

# JToken Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

Abstract base for every JSON value type: `JObject`, `JArray`, `JValue`, and `JProperty`. Use `JsonConverter` to parse JSON text into a token tree or serialize a tree back to text.

```csharp
public abstract class JToken
```

## Methods

### EnterSerialization(JsonSerializationOptions options)

```csharp
protected void EnterSerialization(JsonSerializationOptions options = null)
```

Begins a serialization scope, establishing the shared formatting context if none exists.

### ExitSerialization()

```csharp
protected void ExitSerialization()
```

Ends the serialization scope, releasing the shared formatting context if this token owns it.

### Indent(bool incrementAfter)

```csharp
protected string Indent(bool incrementAfter = false)
```

Returns the indentation string for the current nesting level, optionally increasing the level afterwards.

**Returns** `string`

### Outdent()

```csharp
protected void Outdent()
```

Decreases the current indentation nesting level by one.

### ToBson()

```csharp
public byte[] ToBson()
```

Encodes this token as a standalone BSON document and returns the bytes.

**Returns** `byte[]`

### GetBsonType()

```csharp
public abstract BsonTypes GetBsonType()
```

Gets the BSON type code for this token.

**Returns** `BsonTypes`

### GetBsonSize()

```csharp
public abstract int GetBsonSize()
```

Gets the number of bytes this token occupies when encoded as BSON.

**Returns** `int`

### GetBsonSize(string ename)

```csharp
public abstract int GetBsonSize(string ename)
```

Gets the number of BSON bytes for this token including the given element name.

**Returns** `int`

### ToBson(byte[] buffer, ref int offset)

```csharp
public abstract void ToBson(byte[] buffer, ref int offset)
```

Writes this token to the buffer as BSON, advancing the offset.

### ToBson(string ename, byte[] buffer, ref int offset)

```csharp
public void ToBson(string ename, byte[] buffer, ref int offset)
```

Writes this token as a named BSON element (type byte, name, then value), advancing the offset.

### MarshallEName(string ename, byte[] buffer, ref int offset)

```csharp
protected void MarshallEName(string ename, byte[] buffer, ref int offset)
```

Writes a BSON element name as a null-terminated UTF-8 string, advancing the offset.

### ToString(JsonSerializationOptions options)

```csharp
public abstract string ToString(JsonSerializationOptions options)
```

Returns the JSON text for this token using the given formatting options.

**Returns** `string`
