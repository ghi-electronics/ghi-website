---
title: "UnmanagedBufferLocation Enum"
sidebar_label: "UnmanagedBufferLocation"
---

# UnmanagedBufferLocation Enum

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

Which heap an `UnmanagedBuffer` draws from.

```csharp
public enum UnmanagedBufferLocation
```

## Fields

| Name | Value | Description |
|---|---|---|
| `ManagedMemory` |  | Allocated from the managed (GC) heap. |
| `UnmanagedMemory` |  | Allocated from the unmanaged heap (fixed address). |
