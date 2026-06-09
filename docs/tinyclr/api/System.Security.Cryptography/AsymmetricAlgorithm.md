---
title: "AsymmetricAlgorithm Class"
sidebar_label: "AsymmetricAlgorithm"
---

# AsymmetricAlgorithm Class

**Namespace:** `System.Security.Cryptography` · **Assembly:** `GHIElectronics.TinyCLR.System.Security.Cryptography`

Abstract base for asymmetric (public-key) algorithms.

```csharp
public abstract class AsymmetricAlgorithm : IDisposable
```

## Properties

### KeySize

```csharp
public virtual int KeySize { get; set; }
```

_No description available._

### KeyExchangeAlgorithm

```csharp
public virtual string KeyExchangeAlgorithm { get; }
```

_No description available._

### SignatureAlgorithm

```csharp
public virtual string SignatureAlgorithm { get; }
```

_No description available._

## Methods

### Dispose()

```csharp
public virtual void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_
