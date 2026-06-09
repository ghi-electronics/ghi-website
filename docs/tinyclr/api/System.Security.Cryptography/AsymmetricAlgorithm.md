---
title: "AsymmetricAlgorithm Class"
sidebar_label: "AsymmetricAlgorithm"
---

# AsymmetricAlgorithm Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

Abstract base for asymmetric (public-key) algorithms.

```csharp
public abstract class AsymmetricAlgorithm : IDisposable
```

## Properties

### KeySize

```csharp
public virtual int KeySize { get; set; }
```

The key size, in bits.

### KeyExchangeAlgorithm

```csharp
public virtual string KeyExchangeAlgorithm { get; }
```

Name of the key-exchange algorithm, or null.

### SignatureAlgorithm

```csharp
public virtual string SignatureAlgorithm { get; }
```

Name of the signature algorithm, or null.

## Methods

### Dispose()

```csharp
public virtual void Dispose()
```

Releases the resources used by the algorithm.

### Clear()

```csharp
public void Clear()
```

Releases the resources used by the algorithm.
