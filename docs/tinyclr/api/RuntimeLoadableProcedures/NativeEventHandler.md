---
title: "NativeEventHandler Delegate"
sidebar_label: "NativeEventHandler"
---

# NativeEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`<br/>**Assembly:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`<br/>**Namespace:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`

Handler signature for `NativeEvent`. The argument is whatever the native code passed to `RLP_PostManagedEvent`.

```csharp
public delegate void NativeEventHandler(uint data);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `data` | `uint` |  |
