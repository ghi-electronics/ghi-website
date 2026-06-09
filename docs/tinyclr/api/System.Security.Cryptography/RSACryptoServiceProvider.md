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

**Returns** `RSAParameters`

### ImportParameters(RSAParameters parameters)

```csharp
public override void ImportParameters(RSAParameters parameters)
```

_No description available._

### Encrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
```

_No description available._

**Returns** `byte[]`

### Decrypt(byte[] data, RSAEncryptionPadding padding)

```csharp
public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
```

_No description available._

**Returns** `byte[]`

### SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

**Returns** `byte[]`

### SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

**Returns** `byte[]`

### VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

**Returns** `bool`

### VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)

```csharp
public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
```

_No description available._

**Returns** `bool`

### Encrypt(byte[] rgb, bool fOAEP)

```csharp
public byte[] Encrypt(byte[] rgb, bool fOAEP)
```

_No description available._

**Returns** `byte[]`

### Decrypt(byte[] rgb, bool fOAEP)

```csharp
public byte[] Decrypt(byte[] rgb, bool fOAEP)
```

_No description available._

**Returns** `byte[]`

### SignData(byte[] buffer, bool sha256)

```csharp
public byte[] SignData(byte[] buffer, bool sha256 = false)
```

_No description available._

**Returns** `byte[]`

### VerifyData(byte[] buffer, byte[] signature, bool sha256)

```csharp
public bool VerifyData(byte[] buffer, byte[] signature, bool sha256 = false)
```

_No description available._

**Returns** `bool`

### Dispose()

```csharp
public override void Dispose()
```

_No description available._
