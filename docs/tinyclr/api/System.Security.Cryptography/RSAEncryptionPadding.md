---
title: "RSAEncryptionPadding Class"
sidebar_label: "RSAEncryptionPadding"
---

# RSAEncryptionPadding Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

_No description available._

```csharp
public sealed class RSAEncryptionPadding
```

## Properties

### Pkcs1

```csharp
public static RSAEncryptionPadding Pkcs1 { get; }
```

_No description available._

### OaepSHA1

```csharp
public static RSAEncryptionPadding OaepSHA1 { get; }
```

_No description available._

### OaepSHA256

```csharp
public static RSAEncryptionPadding OaepSHA256 { get; }
```

_No description available._

### Mode

```csharp
public RSAEncryptionPaddingMode Mode { get; }
```

_No description available._

### OaepHashAlgorithm

```csharp
public HashAlgorithmName OaepHashAlgorithm { get; }
```

_No description available._

## Methods

### CreateOaep(HashAlgorithmName hashAlgorithm)

```csharp
public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm)
```

_No description available._

**Returns** `RSAEncryptionPadding`

### Equals(RSAEncryptionPadding other)

```csharp
public bool Equals(RSAEncryptionPadding other)
```

_No description available._

**Returns** `bool`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

_No description available._

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

_No description available._

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

_No description available._

**Returns** `string`

### ==(RSAEncryptionPadding left, RSAEncryptionPadding right)

```csharp
public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right)
```

_No description available._

**Returns** `bool operator`

### !=(RSAEncryptionPadding left, RSAEncryptionPadding right)

```csharp
public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right)
```

_No description available._

**Returns** `bool operator`
