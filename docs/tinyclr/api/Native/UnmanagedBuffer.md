---
title: "UnmanagedBuffer Class"
sidebar_label: "UnmanagedBuffer"
---

# UnmanagedBuffer Class

**Namespace:** `GHIElectronics.TinyCLR.Native` · **Assembly:** `GHIElectronics.TinyCLR.Native`

A fixed-address byte buffer suitable for DMA targets and native interop. The `Bytes` property exposes it as a regular byte[]. Dispose to release the underlying memory.

```csharp
public class UnmanagedBuffer : IDisposable
```

## Constructors

### UnmanagedBuffer(int length)

```csharp
public UnmanagedBuffer(int length) : this(length, UnmanagedBufferLocation.UnmanagedMemory)
```

Allocates a buffer of the given length in the unmanaged heap.

| Parameter | Type | Description |
|---|---|---|
| `length` | `int` |  |

### UnmanagedBuffer(int length, UnmanagedBufferLocation location)

```csharp
public UnmanagedBuffer(int length, UnmanagedBufferLocation location)
```

Allocates a buffer of the given length from the specified heap.

| Parameter | Type | Description |
|---|---|---|
| `length` | `int` | Buffer size in bytes. |
| `location` | `UnmanagedBufferLocation` | Heap to allocate from. Only `UnmanagedBufferLocation.UnmanagedMemory` is supported. |

## Properties

### Bytes

```csharp
public byte[] Bytes { get; }
```

Byte[] view of the unmanaged region. Same address every read.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the unmanaged region.
