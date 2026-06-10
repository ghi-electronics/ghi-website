---
title: "ExchangeAlgorithmType Enum"
sidebar_label: "ExchangeAlgorithmType"
---

# ExchangeAlgorithmType Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Security.Authentication`

Specifies the algorithm used to create keys shared by the client and server.

```csharp
public enum ExchangeAlgorithmType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No key exchange algorithm is used. |
| `RsaSign` | `(Alg.ClassSignture \| Alg.TypeRSA \| Alg.Any)` | The RSA public-key signature algorithm. |
| `RsaKeyX` | `(Alg.ClassKeyXch \| Alg.TypeRSA \| Alg.Any)` | The RSA public-key exchange algorithm. |
| `DiffieHellman` | `(Alg.ClassKeyXch \| Alg.TypeDH \| Alg.NameDH_Ephem)` | The Diffie-Hellman ephemeral key exchange algorithm. |
