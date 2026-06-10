---
title: "Path Class"
sidebar_label: "Path"
---

# Path Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Static helpers for path-string manipulation — Combine, GetExtension, GetFileName, etc.

```csharp
public sealed class Path
```

## Properties

### InvalidPathChars

```csharp
public static readonly char[] InvalidPathChars { }
```

The characters that are not allowed in a path.

## Methods

### ChangeExtension(string path, string extension)

```csharp
public static string ChangeExtension(string path, string extension)
```

Returns the path with its file extension changed to the given one.

**Returns** `string`

### GetDirectoryName(string path)

```csharp
public static string GetDirectoryName(string path)
```

Returns the directory portion of a path, or null if the path is a root.

**Returns** `string`

### GetInvalidPathChars()

```csharp
public static char[] GetInvalidPathChars()
```

Returns a copy of the characters that are not allowed in a path.

**Returns** `char[]`

### GetFullPath(string path)

```csharp
public static string GetFullPath(string path)
```

Returns the absolute path for the given path, resolving it against the current directory.

**Returns** `string`

### GetExtension(string path)

```csharp
public static string GetExtension(string path)
```

Returns the extension of the path, including the leading period, or an empty string if there is none.

**Returns** `string`

### GetFileName(string path)

```csharp
public static string GetFileName(string path)
```

Returns the file name and extension portion of the path.

**Returns** `string`

### GetFileNameWithoutExtension(string path)

```csharp
public static string GetFileNameWithoutExtension(string path)
```

Returns the file name of the path without its extension.

**Returns** `string`

### GetPathRoot(string path)

```csharp
public static string GetPathRoot(string path)
```

Returns the root portion of the path.

**Returns** `string`

### HasExtension(string path)

```csharp
public static bool HasExtension(string path)
```

Returns whether the path includes a file extension.

**Returns** `bool`

### IsPathRooted(string path)

```csharp
public static bool IsPathRooted(string path)
```

Returns whether the path is rooted with a drive letter.

**Returns** `bool`

### Combine(string path1, string path2)

```csharp
public static string Combine(string path1, string path2)
```

Combines two path strings into a single path.

**Returns** `string`

## Fields

### DirectorySeparatorChar

```csharp
public static readonly char DirectorySeparatorChar
```

The character used to separate directory levels in a path.
