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

Creates a name from the given algorithm string.

## Properties

### Name

```csharp
public string Name { get; }
```

The algorithm name.

### MD5

```csharp
public static HashAlgorithmName MD5 { get; }
```

The MD5 algorithm name.

### SHA1

```csharp
public static HashAlgorithmName SHA1 { get; }
```

The SHA-1 algorithm name.

### SHA256

```csharp
public static HashAlgorithmName SHA256 { get; }
```

The SHA-256 algorithm name.

### SHA384

```csharp
public static HashAlgorithmName SHA384 { get; }
```

The SHA-384 algorithm name.

### SHA512

```csharp
public static HashAlgorithmName SHA512 { get; }
```

The SHA-512 algorithm name.

## Methods

### Equals(HashAlgorithmName other)

```csharp
public bool Equals(HashAlgorithmName other)
```

Returns true if the two names are equal.

**Returns** `bool`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Returns true if the object is an equal name.

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Returns the hash code for this name.

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

Returns the algorithm name.

**Returns** `string`

### ==(HashAlgorithmName left, HashAlgorithmName right)

```csharp
public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
```

Returns true if the two names are equal.

**Returns** `bool operator`

### !=(HashAlgorithmName left, HashAlgorithmName right)

```csharp
public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
```

Returns true if the two names differ.

**Returns** `bool operator`
