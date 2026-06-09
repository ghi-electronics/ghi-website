---
title: "NativeEventHandler Delegate"
sidebar_label: "NativeEventHandler"
---

# NativeEventHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

Handler signature for `NativeEventDispatcher.OnInterrupt`.

```csharp
public delegate void NativeEventHandler(string data0, long data1, long data2, long data3, IntPtr data4, DateTime timestamp);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `data0` | `string` |  |
| `data1` | `long` |  |
| `data2` | `long` |  |
| `data3` | `long` |  |
| `data4` | `IntPtr` |  |
| `timestamp` | `DateTime` |  |
