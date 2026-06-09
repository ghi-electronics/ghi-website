---
title: "RandomNumberGenerator Class"
sidebar_label: "RandomNumberGenerator"
---

# RandomNumberGenerator Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

Cryptographically secure RNG. Create via `Create()`; do not seed manually.

```csharp
public abstract class RandomNumberGenerator : IDisposable
```

## Methods

### Create()

```csharp
public static RandomNumberGenerator Create()
```

Creates a new secure random number generator.

**Returns** `RandomNumberGenerator`

### Fill(byte[] data)

```csharp
public static void Fill(byte[] data)
```

Fills the buffer with cryptographically strong random bytes.

### GetBytes(byte[] data)

```csharp
public abstract void GetBytes(byte[] data)
```

Fills the buffer with cryptographically strong random bytes.

### Dispose()

```csharp
public abstract void Dispose()
```

Releases the resources used by the generator.
