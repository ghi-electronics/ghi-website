---
title: "RSAEncryptionPadding Class"
sidebar_label: "RSAEncryptionPadding"
---

# RSAEncryptionPadding Class

**Namespace:** `System.Security.Cryptography` · **Assembly:** `GHIElectronics.TinyCLR.System.Security.Cryptography`

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

SPI mode (clock polarity + phase). See `SpiMode`. _(inherited)_

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

| Parameter | Type | Description |
|---|---|---|
| `hashAlgorithm` | `HashAlgorithmName` |  |

**Returns** `RSAEncryptionPadding`

### Equals(RSAEncryptionPadding other)

```csharp
public bool Equals(RSAEncryptionPadding other)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `other` | `RSAEncryptionPadding` |  |

**Returns** `bool`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `obj` | `object` |  |

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table _(inherited)_

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`

### ==(RSAEncryptionPadding left, RSAEncryptionPadding right)

```csharp
public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right)
```

Equals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `left` | `RSAEncryptionPadding` |  |
| `right` | `RSAEncryptionPadding` |  |

**Returns** `bool operator`

### !=(RSAEncryptionPadding left, RSAEncryptionPadding right)

```csharp
public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right)
```

NotEquals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `left` | `RSAEncryptionPadding` |  |
| `right` | `RSAEncryptionPadding` |  |

**Returns** `bool operator`
