---
title: "Memory Class"
sidebar_label: "Memory"
---

# Memory Class

**Namespace:** `GHIElectronics.TinyCLR.Native` · **Assembly:** `GHIElectronics.TinyCLR.Native`

Allocator façade exposing both the managed (GC) heap and the unmanaged heap. Most apps don't touch this directly — use `UnmanagedBuffer` when you need a fixed-address byte buffer (for DMA, native interop, etc.).

```csharp
public class Memory
```

## Properties

### ManagedMemory

```csharp
public static Memory ManagedMemory { get; }
```

The managed (GC) heap allocator.

### UnmanagedMemory

```csharp
public static Memory UnmanagedMemory { get; }
```

The unmanaged heap allocator (fixed addresses, not GC-tracked).

### UsedBytes

```csharp
public long UsedBytes { get; }
```

Bytes currently allocated from this heap.

### FreeBytes

```csharp
public long FreeBytes { get; }
```

Bytes currently free in this heap.

## Methods

### Allocate(long length)

```csharp
public IntPtr Allocate(long length)
```

Allocates `length` bytes; returns the pointer.

| Parameter | Type | Description |
|---|---|---|
| `length` | `long` |  |

**Returns** `IntPtr`

### Allocate(IntPtr length)

```csharp
public extern IntPtr Allocate(IntPtr length)
```

Allocates the given number of bytes.

| Parameter | Type | Description |
|---|---|---|
| `length` | `IntPtr` |  |

**Returns** `IntPtr`

### Free(IntPtr ptr)

```csharp
public extern void Free(IntPtr ptr)
```

Frees a pointer returned by `Allocate(long)`.

| Parameter | Type | Description |
|---|---|---|
| `ptr` | `IntPtr` |  |

### ToBytes(IntPtr ptr, long length)

```csharp
public byte[] ToBytes(IntPtr ptr, long length)
```

Returns a byte[] aliased to a fixed-address region (no copy).

| Parameter | Type | Description |
|---|---|---|
| `ptr` | `IntPtr` |  |
| `length` | `long` |  |

**Returns** `byte[]`

### ToBytes(IntPtr ptr, IntPtr length)

```csharp
public extern byte[] ToBytes(IntPtr ptr, IntPtr length)
```

Returns a byte[] aliased to a fixed-address region (no copy).

| Parameter | Type | Description |
|---|---|---|
| `ptr` | `IntPtr` |  |
| `length` | `IntPtr` |  |

**Returns** `byte[]`

### GetStats(out IntPtr used, out IntPtr free)

```csharp
public extern void GetStats(out IntPtr used, out IntPtr free)
```

Reads current heap usage and free space.

| Parameter | Type | Description |
|---|---|---|
| `used` | `out IntPtr` |  |
| `free` | `out IntPtr` |  |

### ExtendHeap()

```csharp
public static extern void ExtendHeap()
```

Permanently extends the managed heap into external SDRAM (where supported).

### IsExtendedHeap()

```csharp
public static extern bool IsExtendedHeap()
```

True when the managed heap has been extended via `ExtendHeap`.

**Returns** `bool`
