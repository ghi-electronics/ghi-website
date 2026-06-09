---
title: "SHA1 Class"
sidebar_label: "SHA1"
---

# SHA1 Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

SHA-1 hash (160-bit). Use `HashAlgorithm.Create()` overloads or instantiate directly.

```csharp
public sealed class SHA1 : HashAlgorithm
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
public static SHA1 Create()
```

_No description available._

**Returns** `SHA1`

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
