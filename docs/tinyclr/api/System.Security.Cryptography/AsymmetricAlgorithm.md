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

_No description available._

### Clear()

```csharp
public void Clear()
```

_No description available._
