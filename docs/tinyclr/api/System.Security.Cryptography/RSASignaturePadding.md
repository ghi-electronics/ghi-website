---
title: "RSASignaturePadding Class"
sidebar_label: "RSASignaturePadding"
---

# RSASignaturePadding Class

**Namespace:** `System.Security.Cryptography` · **Assembly:** `GHIElectronics.TinyCLR.System.Security.Cryptography`

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

SPI mode (clock polarity + phase). See `SpiMode`. _(inherited)_

## Methods

### Equals(RSASignaturePadding other)

```csharp
public bool Equals(RSASignaturePadding other)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `other` | `RSASignaturePadding` |  |

**Returns** `bool`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `obj` | `object` |  |

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table _(inherited)_

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`

### ==(RSASignaturePadding left, RSASignaturePadding right)

```csharp
public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
```

Equals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `left` | `RSASignaturePadding` |  |
| `right` | `RSASignaturePadding` |  |

**Returns** `bool operator`

### !=(RSASignaturePadding left, RSASignaturePadding right)

```csharp
public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
```

NotEquals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `left` | `RSASignaturePadding` |  |
| `right` | `RSASignaturePadding` |  |

**Returns** `bool operator`
