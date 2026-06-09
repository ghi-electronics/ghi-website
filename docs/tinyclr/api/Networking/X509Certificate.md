---
title: "X509Certificate Class"
sidebar_label: "X509Certificate"
---

# X509Certificate Class

**Namespace:** `System.Security.Cryptography.X509Certificates` · **Assembly:** `GHIElectronics.TinyCLR.Networking`

_No description available._

```csharp
public class X509Certificate
```

## Constructors

### X509Certificate(byte[] certificate)

```csharp
public X509Certificate(byte[] certificate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `certificate` | `byte[]` |  |

## Properties

### PrivateKey

```csharp
public byte[] PrivateKey { get; set; }
```

_No description available._

### Password

```csharp
public string Password { get; set; }
```

Set or get password. _(inherited)_

## Methods

### GetRawCertData()

```csharp
public byte[] GetRawCertData()
```

_No description available._

**Returns** `byte[]`
