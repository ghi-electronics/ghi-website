---
title: "HashAlgorithm Class"
sidebar_label: "HashAlgorithm"
---

# HashAlgorithm Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

Abstract base for cryptographic hash algorithms (MD5, SHA1, SHA256). Matches the .NET BCL surface.

```csharp
public abstract class HashAlgorithm : IDisposable
```

## Properties

### HashSize

```csharp
public virtual int HashSize { get; set; }
```

_No description available._

### Hash

```csharp
public virtual byte[] Hash { get; set; }
```

_No description available._

## Methods

### ComputeHash(byte[] buffer)

```csharp
public abstract byte[] ComputeHash(byte[] buffer)
```

_No description available._

**Returns** `byte[]`

### ComputeHash(byte[] buffer, int offset, int count)

```csharp
public abstract byte[] ComputeHash(byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `byte[]`

### ComputeHash(Stream inputStream)

```csharp
public abstract byte[] ComputeHash(Stream inputStream)
```

_No description available._

**Returns** `byte[]`

### Initialize()

```csharp
public abstract void Initialize()
```

_No description available._

### Clear()

```csharp
public void Clear()
```

_No description available._

### Dispose()

```csharp
public virtual void Dispose()
```

_No description available._
