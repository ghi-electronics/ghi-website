---
title: "RSASignaturePadding Class"
sidebar_label: "RSASignaturePadding"
---

# RSASignaturePadding Class

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

Signature-padding configuration. Matches the .NET Framework type.

```csharp
public sealed class RSASignaturePadding
```

## Properties

### Pkcs1

```csharp
public static RSASignaturePadding Pkcs1 { get; }
```

_No description available._

### Pss

```csharp
public static RSASignaturePadding Pss { get; }
```

_No description available._

### Mode

```csharp
public RSASignaturePaddingMode Mode { get; }
```

_No description available._

## Methods

### Equals(RSASignaturePadding other)

```csharp
public bool Equals(RSASignaturePadding other)
```

_No description available._

**Returns** `bool`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

_No description available._

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

_No description available._

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

_No description available._

**Returns** `string`

### ==(RSASignaturePadding left, RSASignaturePadding right)

```csharp
public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
```

_No description available._

**Returns** `bool operator`

### !=(RSASignaturePadding left, RSASignaturePadding right)

```csharp
public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
```

_No description available._

**Returns** `bool operator`
