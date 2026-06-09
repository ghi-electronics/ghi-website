---
title: "StorageDescriptor Class"
sidebar_label: "StorageDescriptor"
---

# StorageDescriptor Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Storage` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Storage`

Describes a storage medium's geometry and capabilities.

```csharp
public class StorageDescriptor
```

## Properties

### CanReadDirect

```csharp
public bool CanReadDirect { get; set; }
```

True when single-byte reads are supported (NOR-style flash, RAM).

### CanWriteDirect

```csharp
public bool CanWriteDirect { get; set; }
```

True when single-byte writes are supported.

### CanExecuteDirect

```csharp
public bool CanExecuteDirect { get; set; }
```

True when code can be executed in-place from this media (XIP).

### EraseBeforeWrite

```csharp
public bool EraseBeforeWrite { get; set; }
```

True when a sector must be erased before it can be overwritten (most flash).

### Removable

```csharp
public bool Removable { get; set; }
```

True when the media can be physically removed (SD card, USB stick).

### RegionsContiguous

```csharp
public bool RegionsContiguous { get; set; }
```

True when `RegionAddresses` form a contiguous span.

### RegionsEqualSized

```csharp
public bool RegionsEqualSized { get; set; }
```

True when every entry in `RegionSizes` has the same value.

### RegionCount

```csharp
public int RegionCount { get; set; }
```

Number of distinct erase regions reported.

### RegionAddresses

```csharp
public long[] RegionAddresses { get; set; }
```

Starting address of each erase region.

### RegionSizes

```csharp
public int[] RegionSizes { get; set; }
```

Size in bytes of each erase region (parallel to `RegionAddresses`).
