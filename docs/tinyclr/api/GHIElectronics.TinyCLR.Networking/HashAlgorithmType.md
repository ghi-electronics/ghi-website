---
title: "HashAlgorithmType Enum"
sidebar_label: "HashAlgorithmType"
---

# HashAlgorithmType Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Security.Authentication`

Specifies the hash algorithm used for message authentication.

```csharp
public enum HashAlgorithmType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No hash algorithm is used. |
| `Md5` | `(Alg.ClassHash \| Alg.Any \| Alg.NameMD5)` | The MD5 hash algorithm. |
| `Sha1` | `(Alg.ClassHash \| Alg.Any \| Alg.NameSHA)` | The SHA-1 hash algorithm. |
| `Sha256` | `(Alg.ClassHash \| Alg.Any \| Alg.NameSHA256)` | The SHA-256 hash algorithm. |
| `Sha384` | `(Alg.ClassHash \| Alg.Any \| Alg.NameSHA384)` | The SHA-384 hash algorithm. |
| `Sha512` | `(Alg.ClassHash \| Alg.Any \| Alg.NameSHA512)` | The SHA-512 hash algorithm. |
