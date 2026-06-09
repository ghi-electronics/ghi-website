---
title: "RSACryptoServiceProvider Class"
sidebar_label: "RSACryptoServiceProvider"
---

# RSACryptoServiceProvider Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

Concrete RSA implementation. Construct with the desired key size or with externally supplied `RSAParameters`.

```csharp
public sealed class RSACryptoServiceProvider : RSA
```

## Constructors

### RSACryptoServiceProvider()

```csharp
public RSACryptoServiceProvider()
```

_No description available._

### RSACryptoServiceProvider(int dwKeySize)

```csharp
public RSACryptoServiceProvider(int dwKeySize)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `dwKeySize` | `int` |  |

## Properties

### KeySize

```csharp
public override int KeySize { get; set; }
```

_No description available._

### KeyExchangeAlgorithm

```csharp
public override string KeyExchangeAlgorithm { get; }
```

_No description available._

## Methods

### ExportParameters(bool includePrivateParameters)

```csharp
public override RSAParameters ExportParameters(bool includePrivateParameters)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `includePrivateParameters` | `bool` |  |

**Returns** `RSAParameters`

### ImportParameters(RSAParameters parameters)

```csharp
public override void ImportParameters(RSAParameters parameters)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `parameters` | `RSAParameters` |  |

### Encrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `padding` | `RSAEncryptionPadding` |  |

**Returns** `byte[]`

### Decrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `padding` | `RSAEncryptionPadding` |  |

**Returns** `byte[]`

### SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
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
public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
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
public override bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
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
public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hash` | `byte[]` |  |
| `signature` | `byte[]` |  |
| `hashAlgorithm` | `HashAlgorithmName` |  |
| `padding` | `RSASignaturePadding` |  |

**Returns** `bool`

### Encrypt(byte[] rgb, bool fOAEP)

```csharp
public byte[] Encrypt(byte[] rgb, bool fOAEP)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `rgb` | `byte[]` |  |
| `fOAEP` | `bool` |  |

**Returns** `byte[]`

### Decrypt(byte[] rgb, bool fOAEP)

```csharp
public byte[] Decrypt(byte[] rgb, bool fOAEP)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `rgb` | `byte[]` |  |
| `fOAEP` | `bool` |  |

**Returns** `byte[]`

### SignData(byte[] buffer, bool sha256)

```csharp
public byte[] SignData(byte[] buffer, bool sha256 = false)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `sha256` | `bool` |  |

**Returns** `byte[]`

### VerifyData(byte[] buffer, byte[] signature, bool sha256)

```csharp
public bool VerifyData(byte[] buffer, byte[] signature, bool sha256 = false)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `signature` | `byte[]` |  |
| `sha256` | `bool` |  |

**Returns** `bool`

### Dispose()

```csharp
public override void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
