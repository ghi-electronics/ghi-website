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

## Properties

### Name

```csharp
public string Name { get; }
```

_No description available._

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

### ==(HashAlgorithmName left, HashAlgorithmName right)

```csharp
public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
```

_No description available._

**Returns** `bool operator`

### !=(HashAlgorithmName left, HashAlgorithmName right)

```csharp
public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
```

_No description available._

**Returns** `bool operator`
