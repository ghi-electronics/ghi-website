---
title: "HMACSHA256 Class"
sidebar_label: "HMACSHA256"
---

# HMACSHA256 Class

**Namespace:** `System.Security.Cryptography` · **Assembly:** `GHIElectronics.TinyCLR.System.Security.Cryptography`

HMAC-SHA256 keyed hash (256-bit output).

```csharp
public sealed class HMACSHA256 : HMAC
```

## Constructors

### HMACSHA256()

```csharp
public HMACSHA256()
```

_No description available._

### HMACSHA256(byte[] key)

```csharp
public HMACSHA256(byte[] key)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `key` | `byte[]` |  |

## Properties

### Hash

```csharp
public override byte[] Hash { get; set; }
```

_No description available._

### Key

```csharp
public override byte[] Key { get; set; }
```

_No description available._

## Methods

### ComputeHash(byte[] buffer)

```csharp
public override byte[] ComputeHash(byte[] buffer)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

**Returns** `byte[]`

### ComputeHash(byte[] buffer, int offset, int count)

```csharp
public override byte[] ComputeHash(byte[] buffer, int offset, int count)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |

**Returns** `byte[]`

### ComputeHash(Stream inputStream)

```csharp
public override byte[] ComputeHash(Stream inputStream)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `inputStream` | `Stream` |  |

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

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
