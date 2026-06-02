---
title: "GHIElectronics.TinyCLR.Data.Json"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Data.Json

NuGet package containing **14** types.

## Classes

| Class | Summary |
|---|---|
| [DateTimeExtensions](./DateTimeExtensions.md) |  |
| [JArray](./JArray.md) | A JSON array — an ordered sequence of `JToken` elements. |
| [JObject](./JObject.md) | A JSON object — an unordered map of name/`JToken` pairs. |
| [JProperty](./JProperty.md) | A name/value pair inside a `JObject`. |
| [JsonConverter](./JsonConverter.md) | Parses JSON text into a `JToken` tree and serializes objects back to JSON. Strict-on-emit, generous-on-accept per RFC 8259. |
| [JsonSerializationOptions](./JsonSerializationOptions.md) |  |
| [JsonSerializerSettings](./JsonSerializerSettings.md) |  |
| [JToken](./JToken.md) | Abstract base for every JSON value type: `JObject`, `JArray`, `JValue`, and `JProperty`. Use `JsonConverter` to parse JSON text into a token tree or serialize a tree back to text. |
| [JValue](./JValue.md) | A JSON primitive value — string, number, boolean, or null. |
| [SerializationCtx](./SerializationCtx.md) |  |
| [SerializationUtilities](./SerializationUtilities.md) |  |

## Enums

| Enum | Summary |
|---|---|
| [BsonTypes](./BsonTypes.md) |  |
| [TypeNameHandling](./TypeNameHandling.md) |  |

## Delegates

| Delegate | Summary |
|---|---|
| [InstanceFactory](./InstanceFactory.md) | Hook invoked by `JsonConverter.DeserializeObject(string, Type, InstanceFactory)` when a polymorphic field is deserialized — return the concrete instance to populate. |
