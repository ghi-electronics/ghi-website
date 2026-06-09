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

_No description available._

**Returns** `string[]`

### CreateDirectory(string path)

```csharp
public static DirectoryInfo CreateDirectory(string path)
```

_No description available._

**Returns** `DirectoryInfo`

### Exists(string path)

```csharp
public static bool Exists(string path)
```

Determines if the specified file exists. _(inherited)_

**Returns** `bool` — true if the file exists otherwise false.

### EnumerateFiles(string path)

```csharp
public static IEnumerable EnumerateFiles(string path)
```

_No description available._

**Returns** `IEnumerable`

### EnumerateDirectories(string path)

```csharp
public static IEnumerable EnumerateDirectories(string path)
```

_No description available._

**Returns** `IEnumerable`

### EnumerateFileSystemEntries(string path)

```csharp
public static IEnumerable EnumerateFileSystemEntries(string path)
```

_No description available._

**Returns** `IEnumerable`

### GetFiles(string path)

```csharp
public static string[] GetFiles(string path)
```

_No description available._

**Returns** `string[]`

### GetDirectories(string path)

```csharp
public static string[] GetDirectories(string path)
```

_No description available._

**Returns** `string[]`

### GetCurrentDirectory()

```csharp
public static string GetCurrentDirectory()
```

_No description available._

**Returns** `string`

### SetCurrentDirectory(string path)

```csharp
public static void SetCurrentDirectory(string path)
```

_No description available._

### Move(string sourceDirName, string destDirName)

```csharp
public static void Move(string sourceDirName, string destDirName)
```

Moves a file from the source to the destination. _(inherited)_

### Delete(string path)

```csharp
public static void Delete(string path)
```

Deletes a file from the device. _(inherited)_

### Delete(string path, bool recursive)

```csharp
public static void Delete(string path, bool recursive)
```

_No description available._
