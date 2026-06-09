---
title: "HashAlgorithmName Struct"
sidebar_label: "HashAlgorithmName"
---

# HashAlgorithmName Struct

**NuGet:** `GHIElectronics.TinyCLR.Cryptography`<br/>**Assembly:** `System.Security.Cryptography`<br/>**Namespace:** `System.Security.Cryptography`

_No description available._

```csharp
public struct HashAlgorithmName
```

## Constructors

### HashAlgorithmName(string name)

```csharp
public HashAlgorithmName(string name)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

## Properties

### Name

```csharp
public string Name { get; }
```

The native API name. _(inherited)_

### MD5

```csharp
public static HashAlgorithmName MD5 { get; }
```

_No description available._

### SHA1

```csharp
public static HashAlgorithmName SHA1 { get; }
```

_No description available._

### SHA256

```csharp
public static HashAlgorithmName SHA256 { get; }
```

_No description available._

### SHA384

```csharp
public static HashAlgorithmName SHA384 { get; }
```

_No description available._

### SHA512

```csharp
public static HashAlgorithmName SHA512 { get; }
```

_No description available._

## Methods

### Equals(HashAlgorithmName other)

```csharp
public bool Equals(HashAlgorithmName other)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `other` | `HashAlgorithmName` |  |

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

### ==(HashAlgorithmName left, HashAlgorithmName right)

```csharp
public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
```

Equals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `left` | `HashAlgorithmName` |  |
| `right` | `HashAlgorithmName` |  |

**Returns** `bool operator`

### !=(HashAlgorithmName left, HashAlgorithmName right)

```csharp
public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
```

NotEquals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `left` | `HashAlgorithmName` |  |
| `right` | `HashAlgorithmName` |  |

**Returns** `bool operator`
