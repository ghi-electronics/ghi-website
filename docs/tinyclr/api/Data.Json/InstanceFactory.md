---
title: "InstanceFactory Delegate"
sidebar_label: "InstanceFactory"
---

# InstanceFactory Delegate

**Namespace:** `GHIElectronics.TinyCLR.Data.Json` · **Assembly:** `GHIElectronics.TinyCLR.Data.Json`

Hook invoked by `JsonConverter.DeserializeObject(string, Type, InstanceFactory)` when a polymorphic field is deserialized — return the concrete instance to populate.

```csharp
public delegate object InstanceFactory(string instancePath, JToken token, Type baseType, string fieldName, int length);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `instancePath` | `string` |  |
| `token` | `JToken` |  |
| `baseType` | `Type` |  |
| `fieldName` | `string` |  |
| `length` | `int` |  |
