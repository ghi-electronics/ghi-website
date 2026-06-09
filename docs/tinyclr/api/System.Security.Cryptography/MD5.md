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

_No description available._

## Methods

### Create()

```csharp
public static MD5 Create()
```

_No description available._

**Returns** `MD5`

### ComputeHash(byte[] buffer)

```csharp
public override byte[] ComputeHash(byte[] buffer)
```

_No description available._

**Returns** `byte[]`

### ComputeHash(byte[] buffer, int offset, int count)

```csharp
public override byte[] ComputeHash(byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `byte[]`

### ComputeHash(Stream inputStream)

```csharp
public override byte[] ComputeHash(Stream inputStream)
```

_No description available._

**Returns** `byte[]`

### Initialize()

```csharp
public override void Initialize()
```

_No description available._

### Dispose()

```csharp
public override void Dispose()
```

_No description available._
