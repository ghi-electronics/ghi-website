---
title: "GHIElectronics.TinyCLR.Data.Json"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">Data.Json Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [DateTimeExtensions](./DateTimeExtensions.md) | `GHIElectronics.TinyCLR.Data.Json` | Helpers for converting dates between common JSON and calendar string formats. |
| [JArray](./JArray.md) | `GHIElectronics.TinyCLR.Data.Json` | A JSON array — an ordered sequence of `JToken` elements. |
| [JObject](./JObject.md) | `GHIElectronics.TinyCLR.Data.Json` | A JSON object — an unordered map of name/`JToken` pairs. |
| [JProperty](./JProperty.md) | `GHIElectronics.TinyCLR.Data.Json` | A name/value pair inside a `JObject`. |
| [JsonConverter](./JsonConverter.md) | `GHIElectronics.TinyCLR.Data.Json` | Parses JSON text into a `JToken` tree and serializes objects back to JSON. Strict-on-emit, generous-on-accept per RFC 8259. |
| [JsonSerializationOptions](./JsonSerializationOptions.md) | `GHIElectronics.TinyCLR.Data.Json` | Options that control how JSON text is formatted during serialization. |
| [JsonSerializerSettings](./JsonSerializerSettings.md) | `GHIElectronics.TinyCLR.Data.Json` | Settings that control how objects are serialized to JSON tokens. |
| [JToken](./JToken.md) | `GHIElectronics.TinyCLR.Data.Json` | Abstract base for every JSON value type: `JObject`, `JArray`, `JValue`, and `JProperty`. Use `JsonConverter` to parse JSON text into a token tree or serialize a tree back to text. |
| [JValue](./JValue.md) | `GHIElectronics.TinyCLR.Data.Json` | A JSON primitive value — string, number, boolean, or null. |
| [SerializationCtx](./SerializationCtx.md) | `GHIElectronics.TinyCLR.Data.Json` | Holds the formatting options and indentation state for one serialization pass. |
| [SerializationUtilities](./SerializationUtilities.md) | `GHIElectronics.TinyCLR.Data.Json` | Helpers for marshalling primitive values to and from a BSON byte buffer. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [BsonTypes](./BsonTypes.md) | `GHIElectronics.TinyCLR.Data.Json` | BSON element type codes used when encoding tokens to BSON. |
| [TypeNameHandling](./TypeNameHandling.md) | `GHIElectronics.TinyCLR.Data.Json` | Controls whether type names are written into the JSON for serialized objects. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [InstanceFactory](./InstanceFactory.md) | `GHIElectronics.TinyCLR.Data.Json` | Hook invoked by `JsonConverter.DeserializeObject(string, Type, InstanceFactory)` when a polymorphic field is deserialized — return the concrete instance to populate. |
