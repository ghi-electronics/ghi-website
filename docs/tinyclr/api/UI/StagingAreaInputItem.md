---
title: "StagingAreaInputItem Class"
sidebar_label: "StagingAreaInputItem"
---

# StagingAreaInputItem Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

This class encapsulates an input event while it is being processed by the input manager.

```csharp
public class StagingAreaInputItem
```

## Methods

### GetData(object key)

```csharp
public object GetData(object key)
```

Provides storage for arbitrary data needed during the processing of this input event.

| Parameter | Type | Description |
|---|---|---|
| `key` | `object` | An arbitrary key for the data. This cannot be null. |

**Returns** `object` — The data previously set for this key, or null.

### SetData(object key, object value)

```csharp
public void SetData(object key, object value)
```

Provides storage for arbitrary data needed during the processing of this input event.

| Parameter | Type | Description |
|---|---|---|
| `key` | `object` | An arbitrary key for the data. This cannot be null. |
| `value` | `object` | The data to set for this key. This can be null. |

## Fields

### Input

```csharp
public readonly InputEventArgs Input
```

Returns the input event.
