---
title: "SerializationCtx Class"
sidebar_label: "SerializationCtx"
---

# SerializationCtx Class

**NuGet:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.Json`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.Json`

Holds the formatting options and indentation state for one serialization pass.

```csharp
public class SerializationCtx
```

## Constructors

### SerializationCtx(JsonSerializationOptions options)

```csharp
public SerializationCtx(JsonSerializationOptions options)
```

Initializes a new serialization context with the given options.

## Fields

### options

```csharp
public readonly JsonSerializationOptions options
```

The formatting options in effect for this serialization pass.

### IndentLevel

```csharp
public int IndentLevel
```

The current indentation nesting level.
