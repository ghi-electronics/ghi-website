---
title: "Directory Class"
sidebar_label: "Directory"
---

# Directory Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Static helpers for directory management — create, delete, enumerate, get current directory.

```csharp
public sealed class Directory
```

## Methods

### GetLogicalDrives()

```csharp
public static string[] GetLogicalDrives()
```

Returns the names of all mounted logical drives.

**Returns** `string[]`

### CreateDirectory(string path)

```csharp
public static DirectoryInfo CreateDirectory(string path)
```

Creates the directory at the path, including any missing parents, and returns it.

**Returns** `DirectoryInfo`

### Exists(string path)

```csharp
public static bool Exists(string path)
```

Returns whether the directory at the path exists.

**Returns** `bool`

### EnumerateFiles(string path)

```csharp
public static IEnumerable EnumerateFiles(string path)
```

Returns an enumerable over the file names in the directory.

**Returns** `IEnumerable`

### EnumerateDirectories(string path)

```csharp
public static IEnumerable EnumerateDirectories(string path)
```

Returns an enumerable over the subdirectory names in the directory.

**Returns** `IEnumerable`

### EnumerateFileSystemEntries(string path)

```csharp
public static IEnumerable EnumerateFileSystemEntries(string path)
```

Returns an enumerable over the file and subdirectory names in the directory.

**Returns** `IEnumerable`

### GetFiles(string path)

```csharp
public static string[] GetFiles(string path)
```

Returns the names of the files in the directory.

**Returns** `string[]`

### GetDirectories(string path)

```csharp
public static string[] GetDirectories(string path)
```

Returns the names of the subdirectories in the directory.

**Returns** `string[]`

### GetCurrentDirectory()

```csharp
public static string GetCurrentDirectory()
```

Returns the application's current working directory.

**Returns** `string`

### SetCurrentDirectory(string path)

```csharp
public static void SetCurrentDirectory(string path)
```

Sets the application's current working directory.

### Move(string sourceDirName, string destDirName)

```csharp
public static void Move(string sourceDirName, string destDirName)
```

Moves a directory and its contents to a new location.

### Delete(string path)

```csharp
public static void Delete(string path)
```

Deletes the empty directory at the path.

### Delete(string path, bool recursive)

```csharp
public static void Delete(string path, bool recursive)
```

Deletes the directory at the path, optionally including its contents.
