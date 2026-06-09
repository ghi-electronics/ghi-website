---
title: "MD5 Class"
sidebar_label: "MD5"
---

# MD5 Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

MD5 hash (128-bit). Cryptographically broken; use for checksums, not for security.

```csharp
public sealed class MD5 : HashAlgorithm
```

## Properties

### Hash

```csharp
public override byte[] Hash { get; set; }
```

The hash value computed by the last operation.

## Methods

### Create()

```csharp
public static MD5 Create()
```

Creates a new MD5 instance.

**Returns** `MD5`

### ComputeHash(byte[] buffer)

```csharp
public override byte[] ComputeHash(byte[] buffer)
```

Computes the hash of the given data.

**Returns** `byte[]`

### ComputeHash(byte[] buffer, int offset, int count)

```csharp
public override byte[] ComputeHash(byte[] buffer, int offset, int count)
```

Computes the hash of a region of the data.

**Returns** `byte[]`

### ComputeHash(Stream inputStream)

```csharp
public override byte[] ComputeHash(Stream inputStream)
```

Computes the hash of a stream.

**Returns** `byte[]`

### Initialize()

```csharp
public override void Initialize()
```

Resets the algorithm to its initial state.

### Dispose()

```csharp
public override void Dispose()
```

Releases the resources used by the algorithm.
