---
title: "NativeEventHandler Delegate"
sidebar_label: "NativeEventHandler"
---

# NativeEventHandler Delegate

**Namespace:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` · **Assembly:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`

Handler signature for `NativeEvent`. The argument is whatever the native code passed to `RLP_PostManagedEvent`.

```csharp
public delegate void NativeEventHandler(uint data);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `data` | `uint` |  |
