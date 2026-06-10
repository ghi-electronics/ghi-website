---
title: "X509Certificate Class"
sidebar_label: "X509Certificate"
---

# X509Certificate Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Security.Cryptography.X509Certificates`

Represents an X.509 certificate.

```csharp
public class X509Certificate
```

## Constructors

### X509Certificate(byte[] certificate)

```csharp
public X509Certificate(byte[] certificate)
```

Initializes a new certificate from the specified raw certificate data.

## Properties

### PrivateKey

```csharp
public byte[] PrivateKey { get; set; }
```

The private key associated with the certificate.

### Password

```csharp
public string Password { get; set; }
```

The password used to access the certificate's private key.

## Methods

### GetRawCertData()

```csharp
public byte[] GetRawCertData()
```

Returns the raw data of the certificate.

**Returns** `byte[]`
