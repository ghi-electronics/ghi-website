---
title: "HMACSHA1 Class"
sidebar_label: "HMACSHA1"
---

# HMACSHA1 Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

HMAC-SHA1 keyed hash (160-bit output).

```csharp
public sealed class HMACSHA1 : HMAC
```

## Constructors

### HMACSHA1()

```csharp
public HMACSHA1()
```

Creates an HMAC-SHA1 with a random key.

### HMACSHA1(byte[] key)

```csharp
public HMACSHA1(byte[] key)
```

Creates an HMAC-SHA1 with the given key.

## Properties

### Hash

```csharp
public override byte[] Hash { get; set; }
```

The hash value computed by the last operation.

### Key

```csharp
public override byte[] Key { get; set; }
```

The secret key used by the algorithm.

## Methods

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
