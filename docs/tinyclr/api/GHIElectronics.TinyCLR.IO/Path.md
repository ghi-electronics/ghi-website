---
title: "Path Class"
sidebar_label: "Path"
---

# Path Class

**Namespace:** `System.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

_No description available._

```csharp
public sealed class Path
```

## Properties

### InvalidPathChars

```csharp
public static readonly char[] InvalidPathChars { }
```

_No description available._

## Methods

### ChangeExtension(string path, string extension)

```csharp
public static string ChangeExtension(string path, string extension)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |
| `extension` | `string` |  |

**Returns** `string`

### GetDirectoryName(string path)

```csharp
public static string GetDirectoryName(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `string`

### GetInvalidPathChars()

```csharp
public static char[] GetInvalidPathChars()
```

_No description available._

**Returns** `char[]`

### GetFullPath(string path)

```csharp
public static string GetFullPath(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `string`

### GetExtension(string path)

```csharp
public static string GetExtension(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `string`

### GetFileName(string path)

```csharp
public static string GetFileName(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `string`

### GetFileNameWithoutExtension(string path)

```csharp
public static string GetFileNameWithoutExtension(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `string`

### GetPathRoot(string path)

```csharp
public static string GetPathRoot(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `string`

### HasExtension(string path)

```csharp
public static bool HasExtension(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `bool`

### IsPathRooted(string path)

```csharp
public static bool IsPathRooted(string path)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path` | `string` |  |

**Returns** `bool`

### Combine(string path1, string path2)

```csharp
public static string Combine(string path1, string path2)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `path1` | `string` |  |
| `path2` | `string` |  |

**Returns** `string`

## Fields

### DirectorySeparatorChar

```csharp
public static readonly char DirectorySeparatorChar
```

_No description available._
