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

_No description available._

**Returns** `RandomNumberGenerator`

### Fill(byte[] data)

```csharp
public static void Fill(byte[] data)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |

### GetBytes(byte[] data)

```csharp
public abstract void GetBytes(byte[] data)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |

### Dispose()

```csharp
public abstract void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
