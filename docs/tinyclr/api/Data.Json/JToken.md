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

_No description available._

### ExitSerialization()

```csharp
protected void ExitSerialization()
```

_No description available._

### Indent(bool incrementAfter)

```csharp
protected string Indent(bool incrementAfter = false)
```

_No description available._

**Returns** `string`

### Outdent()

```csharp
protected void Outdent()
```

_No description available._

### ToBson()

```csharp
public byte[] ToBson()
```

_No description available._

**Returns** `byte[]`

### GetBsonType()

```csharp
public abstract BsonTypes GetBsonType()
```

_No description available._

**Returns** `BsonTypes`

### GetBsonSize()

```csharp
public abstract int GetBsonSize()
```

_No description available._

**Returns** `int`

### GetBsonSize(string ename)

```csharp
public abstract int GetBsonSize(string ename)
```

_No description available._

**Returns** `int`

### ToBson(byte[] buffer, ref int offset)

```csharp
public abstract void ToBson(byte[] buffer, ref int offset)
```

_No description available._

### ToBson(string ename, byte[] buffer, ref int offset)

```csharp
public void ToBson(string ename, byte[] buffer, ref int offset)
```

_No description available._

### MarshallEName(string ename, byte[] buffer, ref int offset)

```csharp
protected void MarshallEName(string ename, byte[] buffer, ref int offset)
```

_No description available._

### ToString(JsonSerializationOptions options)

```csharp
public abstract string ToString(JsonSerializationOptions options)
```

_No description available._

**Returns** `string`
