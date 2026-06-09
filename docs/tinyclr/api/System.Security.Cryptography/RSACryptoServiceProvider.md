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

Creates an RSA provider with the default key size.

### RSACryptoServiceProvider(int dwKeySize)

```csharp
public RSACryptoServiceProvider(int dwKeySize)
```

Creates an RSA provider with the given key size, in bits.

## Properties

### KeySize

```csharp
public override int KeySize { get; set; }
```

The key size, in bits. Set it via the constructor.

### KeyExchangeAlgorithm

```csharp
public override string KeyExchangeAlgorithm { get; }
```

Name of the key-exchange algorithm.

## Methods

### ExportParameters(bool includePrivateParameters)

```csharp
public override RSAParameters ExportParameters(bool includePrivateParameters)
```

Exports the RSA key, optionally including the private parameters.

**Returns** `RSAParameters`

### ImportParameters(RSAParameters parameters)

```csharp
public override void ImportParameters(RSAParameters parameters)
```

Imports the given RSA key parameters.

### Encrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
```

Encrypts data with the public key. Only PKCS#1 padding is supported.

**Returns** `byte[]`

### Decrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
```

Decrypts data with the private key. Only PKCS#1 padding is supported.

**Returns** `byte[]`

### SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

Signs data with the private key. Only PKCS#1 padding is supported.

**Returns** `byte[]`

### SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

Signs a precomputed hash with the private key. Only PKCS#1 padding is supported.

**Returns** `byte[]`

### VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

Verifies a data signature against the public key. Only PKCS#1 padding is supported.

**Returns** `bool`

### VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

Verifies a hash signature against the public key. Only PKCS#1 padding is supported.

**Returns** `bool`

### Encrypt(byte[] rgb, bool fOAEP)

```csharp
public byte[] Encrypt(byte[] rgb, bool fOAEP)
```

Encrypts data with the public key (legacy overload). OAEP is not supported.

**Returns** `byte[]`

### Decrypt(byte[] rgb, bool fOAEP)

```csharp
public byte[] Decrypt(byte[] rgb, bool fOAEP)
```

Decrypts data with the private key (legacy overload). OAEP is not supported.

**Returns** `byte[]`

### SignData(byte[] buffer, bool sha256)

```csharp
public byte[] SignData(byte[] buffer, bool sha256 = false)
```

Signs data with the private key (legacy overload). Set `sha256` to use SHA-256 instead of SHA-1.

**Returns** `byte[]`

### VerifyData(byte[] buffer, byte[] signature, bool sha256)

```csharp
public bool VerifyData(byte[] buffer, byte[] signature, bool sha256 = false)
```

Verifies a data signature (legacy overload). Set `sha256` to use SHA-256 instead of SHA-1.

**Returns** `bool`

### Dispose()

```csharp
public override void Dispose()
```

Releases the resources used by the provider.
