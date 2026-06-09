---
title: "Filter Class"
sidebar_label: "Filter"
---

# Filter Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Can`

Acceptance-filter configuration for a CAN controller.

```csharp
public class Filter
```

## Methods

### AddRangeFilter(IdType idType, uint startId, uint endId)

```csharp
public void AddRangeFilter(IdType idType, uint startId, uint endId)
```

Accepts IDs in the inclusive range [`startId`, `endId`].

### AddMaskFilter(IdType idType, uint compare, uint mask)

```csharp
public void AddMaskFilter(IdType idType, uint compare, uint mask)
```

Accepts IDs where the bits selected by `mask` equal those in `compare`.

### RejectRemoteFrame(IdType idType)

```csharp
public void RejectRemoteFrame(IdType idType)
```

Filters out remote-transmission-request (RTR) frames of the given ID width.

### Clear()

```csharp
public void Clear()
```

Removes every previously installed filter (controller will pass all frames).
