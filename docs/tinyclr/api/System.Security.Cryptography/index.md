---
title: "GHIElectronics.TinyCLR.System.Security.Cryptography"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">System.Security.Cryptography Library</h1>

:::info
The standard-.NET `System.Security.Cryptography` API for TinyCLR. It ships inside the **[GHIElectronics.TinyCLR.Cryptography](../Cryptography/index.md)** NuGet — there is no separate package to install.
:::

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [AsymmetricAlgorithm](./AsymmetricAlgorithm.md) | `System.Security.Cryptography` | Abstract base for asymmetric (public-key) algorithms. |
| [HashAlgorithm](./HashAlgorithm.md) | `System.Security.Cryptography` | Abstract base for cryptographic hash algorithms (MD5, SHA1, SHA256). Matches the .NET BCL surface. |
| [HMAC](./HMAC.md) | `System.Security.Cryptography` | Abstract base for HMAC algorithms (HMAC-SHA1, HMAC-SHA256, etc.). |
| [HMACSHA1](./HMACSHA1.md) | `System.Security.Cryptography` | HMAC-SHA1 keyed hash (160-bit output). |
| [HMACSHA256](./HMACSHA256.md) | `System.Security.Cryptography` | HMAC-SHA256 keyed hash (256-bit output). |
| [KeyedHashAlgorithm](./KeyedHashAlgorithm.md) | `System.Security.Cryptography` | Abstract base for keyed hash algorithms (HMAC family). |
| [MD5](./MD5.md) | `System.Security.Cryptography` | MD5 hash (128-bit). Cryptographically broken; use for checksums, not for security. |
| [RandomNumberGenerator](./RandomNumberGenerator.md) | `System.Security.Cryptography` | Cryptographically secure RNG. Create via `Create()`; do not seed manually. |
| [RSA](./RSA.md) | `System.Security.Cryptography` | Abstract RSA implementation; create concrete instances via `RSACryptoServiceProvider`. |
| [RSACryptoServiceProvider](./RSACryptoServiceProvider.md) | `System.Security.Cryptography` | Concrete RSA implementation. Construct with the desired key size or with externally supplied `RSAParameters`. |
| [RSAEncryptionPadding](./RSAEncryptionPadding.md) | `System.Security.Cryptography` |  |
| [RSASignaturePadding](./RSASignaturePadding.md) | `System.Security.Cryptography` | Signature-padding configuration. Matches the .NET Framework type. |
| [SHA1](./SHA1.md) | `System.Security.Cryptography` | SHA-1 hash (160-bit). Use `HashAlgorithm.Create()` overloads or instantiate directly. |
| [SHA256](./SHA256.md) | `System.Security.Cryptography` | SHA-256 hash (256-bit). |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [HashAlgorithmName](./HashAlgorithmName.md) | `System.Security.Cryptography` |  |
| [RSAParameters](./RSAParameters.md) | `System.Security.Cryptography` | RSA key parameters (modulus, exponent, and optional private components) matching the .NET Framework struct. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [RSAEncryptionPaddingMode](./RSAEncryptionPaddingMode.md) | `System.Security.Cryptography` | Padding scheme applied to RSA-encrypted blocks. |
| [RSASignaturePaddingMode](./RSASignaturePaddingMode.md) | `System.Security.Cryptography` | Padding scheme applied to RSA signatures. |
