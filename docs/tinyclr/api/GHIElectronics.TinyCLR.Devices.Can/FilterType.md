---
title: "FilterType Enum"
sidebar_label: "FilterType"
---

# FilterType Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Can` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Can`

How a filter matches arbitration IDs.

```csharp
public enum FilterType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Range` | `0` | Accept IDs in the inclusive range [id1, id2]. |
| `Mask` | `1` | Accept IDs where (id &amp; mask) == (compare &amp; mask). |
