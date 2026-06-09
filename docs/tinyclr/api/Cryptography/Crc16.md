---
title: "Crc16 Class"
sidebar_label: "Crc16"
---

# Crc16 Class

**Namespace:** `GHIElectronics.TinyCLR.Cryptography` · **Assembly:** `GHIElectronics.TinyCLR.Cryptography`

CRC-16 hash. Computes a 16-bit CRC over a byte buffer, optionally with a non-zero seed.

```csharp
public class Crc16
```

## Constructors

### Crc16()

```csharp
public Crc16()
```

_No description available._

## Methods

### ComputeHash(byte[] data)

```csharp
public ushort ComputeHash(byte[] data)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |

**Returns** `ushort`

### ComputeHash(byte[] data, int offset, int count)

```csharp
public ushort ComputeHash(byte[] data, int offset, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `ushort`

### ComputeHash(byte[] data, int offset, int count, ushort seed)

```csharp
public ushort ComputeHash(byte[] data, int offset, int count, ushort seed)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `seed` | `ushort` |  |

**Returns** `ushort`
