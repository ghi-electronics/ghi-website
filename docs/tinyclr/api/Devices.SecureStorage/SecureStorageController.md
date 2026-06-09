---
title: "SecureStorageController Class"
sidebar_label: "SecureStorageController"
---

# SecureStorageController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.SecureStorage` · **Assembly:** `GHIElectronics.TinyCLR.Devices.SecureStorage`

Reads and writes blocks in one of the chip's secure non-volatile regions. Pick the region in the constructor; subsequent calls operate on that region.

```csharp
public class SecureStorageController
```

## Constructors

### SecureStorageController(SecureStorage secureStorage)

```csharp
public SecureStorageController(SecureStorage secureStorage)
```

Opens a controller bound to the given region.

| Parameter | Type | Description |
|---|---|---|
| `secureStorage` | `SecureStorage` | Which region to operate on. |

## Properties

### BlockSize

```csharp
public uint BlockSize { get; }
```

Block (write) granularity of the region, in bytes.

### TotalSize

```csharp
public uint TotalSize { get; }
```

Total size of the region, in bytes.

## Methods

### Write(uint blockIndex, byte[] data)

```csharp
public int Write(uint blockIndex, byte[] data)
```

Writes one block at the given block index.

| Parameter | Type | Description |
|---|---|---|
| `blockIndex` | `uint` | Index of the block to write (0-based). |
| `data` | `byte[]` | Block contents. Length must equal `BlockSize`. |

**Returns** `int` — Bytes actually written.

### Read(uint blockIndex, byte[] data)

```csharp
public int Read(uint blockIndex, byte[] data)
```

Reads one block at the given block index.

| Parameter | Type | Description |
|---|---|---|
| `blockIndex` | `uint` | Index of the block to read (0-based). |
| `data` | `byte[]` | Destination buffer. Length must equal `BlockSize`. |

**Returns** `int` — Bytes actually read.

### Erase()

```csharp
public void Erase()
```

Erases the entire region. Not supported for OTP storage.

### IsBlank(uint blockIndex)

```csharp
public bool IsBlank(uint blockIndex)
```

Returns true if the addressed block is in its erased (all-0xFF) state.

| Parameter | Type | Description |
|---|---|---|
| `blockIndex` | `uint` |  |

**Returns** `bool`
