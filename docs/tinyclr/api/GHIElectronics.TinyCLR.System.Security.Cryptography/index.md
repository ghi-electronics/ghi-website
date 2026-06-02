---
title: "GHIElectronics.TinyCLR.System.Security.Cryptography"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.System.Security.Cryptography

NuGet package containing **18** types.

## Classes

| Class | Summary |
|---|---|
| [AsymmetricAlgorithm](./AsymmetricAlgorithm.md) | Abstract base for asymmetric (public-key) algorithms. |
| [HashAlgorithm](./HashAlgorithm.md) | Abstract base for cryptographic hash algorithms (MD5, SHA1, SHA256). Matches the .NET BCL surface. |
| [HMAC](./HMAC.md) | Abstract base for HMAC algorithms (HMAC-SHA1, HMAC-SHA256, etc.). |
| [HMACSHA1](./HMACSHA1.md) | HMAC-SHA1 keyed hash (160-bit output). |
| [HMACSHA256](./HMACSHA256.md) | HMAC-SHA256 keyed hash (256-bit output). |
| [KeyedHashAlgorithm](./KeyedHashAlgorithm.md) | Abstract base for keyed hash algorithms (HMAC family). |
| [MD5](./MD5.md) | MD5 hash (128-bit). Cryptographically broken; use for checksums, not for security. |
| [RandomNumberGenerator](./RandomNumberGenerator.md) | Cryptographically secure RNG. Create via `Create()`; do not seed manually. |
| [RSA](./RSA.md) | Abstract RSA implementation; create concrete instances via `RSACryptoServiceProvider`. |
| [RSACryptoServiceProvider](./RSACryptoServiceProvider.md) | Concrete RSA implementation. Construct with the desired key size or with externally supplied `RSAParameters`. |
| [RSAEncryptionPadding](./RSAEncryptionPadding.md) |  |
| [RSASignaturePadding](./RSASignaturePadding.md) | Signature-padding configuration. Matches the .NET Framework type. |
| [SHA1](./SHA1.md) | SHA-1 hash (160-bit). Use `HashAlgorithm.Create()` overloads or instantiate directly. |
| [SHA256](./SHA256.md) | SHA-256 hash (256-bit). |

## Structs

| Struct | Summary |
|---|---|
| [HashAlgorithmName](./HashAlgorithmName.md) |  |
| [RSAParameters](./RSAParameters.md) | RSA key parameters (modulus, exponent, and optional private components) matching the .NET Framework struct. |

## Enums

| Enum | Summary |
|---|---|
| [RSAEncryptionPaddingMode](./RSAEncryptionPaddingMode.md) | Padding scheme applied to RSA-encrypted blocks. |
| [RSASignaturePaddingMode](./RSASignaturePaddingMode.md) | Padding scheme applied to RSA signatures. |
