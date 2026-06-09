---
title: "RSA Class"
sidebar_label: "RSA"
---

# RSA Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

Abstract RSA implementation; create concrete instances via `RSACryptoServiceProvider`.

```csharp
public abstract class RSA : AsymmetricAlgorithm
```

## Methods

### ExportParameters(bool includePrivateParameters)

```csharp
public abstract RSAParameters ExportParameters(bool includePrivateParameters)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `includePrivateParameters` | `bool` |  |

**Returns** `RSAParameters`

### ImportParameters(RSAParameters parameters)

```csharp
public abstract void ImportParameters(RSAParameters parameters)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `parameters` | `RSAParameters` |  |

### Encrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `padding` | `RSAEncryptionPadding` |  |

**Returns** `byte[]`

### Decrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `padding` | `RSAEncryptionPadding` |  |

**Returns** `byte[]`

### SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public virtual byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `hashAlgorithm` | `HashAlgorithmName` |  |
| `padding` | `RSASignaturePadding` |  |

**Returns** `byte[]`

### SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hash` | `byte[]` |  |
| `hashAlgorithm` | `HashAlgorithmName` |  |
| `padding` | `RSASignaturePadding` |  |

**Returns** `byte[]`

### VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public virtual bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `signature` | `byte[]` |  |
| `hashAlgorithm` | `HashAlgorithmName` |  |
| `padding` | `RSASignaturePadding` |  |

**Returns** `bool`

### VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hash` | `byte[]` |  |
| `signature` | `byte[]` |  |
| `hashAlgorithm` | `HashAlgorithmName` |  |
| `padding` | `RSASignaturePadding` |  |

**Returns** `bool`
