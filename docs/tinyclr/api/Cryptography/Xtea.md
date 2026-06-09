---
title: "Xtea Class"
sidebar_label: "Xtea"
---

# Xtea Class

**Namespace:** `GHIElectronics.TinyCLR.Cryptography` · **Assembly:** `GHIElectronics.TinyCLR.Cryptography`

XTEA (eXtended Tiny Encryption Algorithm) block cipher. 128-bit key, 64-bit blocks.

```csharp
public class Xtea
```

## Constructors

### Xtea(uint[] key)

```csharp
public Xtea(uint[] key)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `key` | `uint[]` |  |

## Methods

### Encrypt(byte[] buffer, uint offset, uint count)

```csharp
public byte[] Encrypt(byte[] buffer, uint offset, uint count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `uint` |  |
| `count` | `uint` |  |

**Returns** `byte[]`

### Decrypt(byte[] buffer, uint offset, uint count)

```csharp
public byte[] Decrypt(byte[] buffer, uint offset, uint count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `uint` |  |
| `count` | `uint` |  |

**Returns** `byte[]`
