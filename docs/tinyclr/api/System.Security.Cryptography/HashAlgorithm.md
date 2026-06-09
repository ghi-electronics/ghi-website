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

Size of the computed hash, in bits.

### Hash

```csharp
public virtual byte[] Hash { get; set; }
```

The hash value computed by the last operation.

## Methods

### ComputeHash(byte[] buffer)

```csharp
public abstract byte[] ComputeHash(byte[] buffer)
```

Computes the hash of the given data.

**Returns** `byte[]`

### ComputeHash(byte[] buffer, int offset, int count)

```csharp
public abstract byte[] ComputeHash(byte[] buffer, int offset, int count)
```

Computes the hash of a region of the data.

**Returns** `byte[]`

### ComputeHash(Stream inputStream)

```csharp
public abstract byte[] ComputeHash(Stream inputStream)
```

Computes the hash of a stream.

**Returns** `byte[]`

### Initialize()

```csharp
public abstract void Initialize()
```

Resets the algorithm to its initial state.

### Clear()

```csharp
public void Clear()
```

Releases the resources used by the algorithm.

### Dispose()

```csharp
public virtual void Dispose()
```

Releases the resources used by the algorithm.
