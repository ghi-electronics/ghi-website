---
title: "Xtea Class"
sidebar_label: "Xtea"
---

# Xtea Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Namespace:** `GHIElectronics.TinyCLR.Cryptography`

XTEA (eXtended Tiny Encryption Algorithm) block cipher. 128-bit key, 64-bit blocks.

```csharp
public class Xtea
```

## Constructors

### Xtea(uint[] key)

```csharp
public Xtea(uint[] key)
```

Creates an XTEA cipher with the given 128-bit key (four 32-bit words).

## Methods

### Encrypt(byte[] buffer, uint offset, uint count)

```csharp
public byte[] Encrypt(byte[] buffer, uint offset, uint count)
```

Encrypts a range of the buffer and returns the ciphertext.

**Returns** `byte[]`

### Decrypt(byte[] buffer, uint offset, uint count)

```csharp
public byte[] Decrypt(byte[] buffer, uint offset, uint count)
```

Decrypts a range of the buffer and returns the plaintext.

**Returns** `byte[]`
