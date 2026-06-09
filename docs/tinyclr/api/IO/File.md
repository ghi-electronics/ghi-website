---
title: "File Class"
sidebar_label: "File"
---

# File Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

_No description available._

```csharp
public static class File
```

## Methods

### Copy(string sourceFileName, string destFileName)

```csharp
public static void Copy(string sourceFileName, string destFileName)
```

_No description available._

### Copy(string sourceFileName, string destFileName, bool overwrite)

```csharp
public static void Copy(string sourceFileName, string destFileName, bool overwrite)
```

_No description available._

### Create(string path)

```csharp
public static FileStream Create(string path)
```

_No description available._

**Returns** `FileStream`

### Create(string path, int bufferSize)

```csharp
public static FileStream Create(string path, int bufferSize)
```

_No description available._

**Returns** `FileStream`

### Delete(string path)

```csharp
public static void Delete(string path)
```

_No description available._

### Exists(string path)

```csharp
public static bool Exists(string path)
```

_No description available._

**Returns** `bool`

### Open(string path, FileMode mode)

```csharp
public static FileStream Open(string path, FileMode mode)
```

_No description available._

**Returns** `FileStream`

### Open(string path, FileMode mode, FileAccess access)

```csharp
public static FileStream Open(string path, FileMode mode, FileAccess access)
```

_No description available._

**Returns** `FileStream`

### Open(string path, FileMode mode, FileAccess access, FileShare share)

```csharp
public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
```

_No description available._

**Returns** `FileStream`

### GetAttributes(string path)

```csharp
public static FileAttributes GetAttributes(string path)
```

_No description available._

**Returns** `FileAttributes`

### SetAttributes(string path, FileAttributes fileAttributes)

```csharp
public static void SetAttributes(string path, FileAttributes fileAttributes)
```

_No description available._

### OpenRead(string path)

```csharp
public static FileStream OpenRead(string path)
```

_No description available._

**Returns** `FileStream`

### OpenWrite(string path)

```csharp
public static FileStream OpenWrite(string path)
```

_No description available._

**Returns** `FileStream`

### ReadAllBytes(string path)

```csharp
public static byte[] ReadAllBytes(string path)
```

_No description available._

**Returns** `byte[]`

### WriteAllBytes(string path, byte[] bytes)

```csharp
public static void WriteAllBytes(string path, byte[] bytes)
```

_No description available._

### Move(string sourceFileName, string destFileName)

```csharp
public static void Move(string sourceFileName, string destFileName)
```

_No description available._
