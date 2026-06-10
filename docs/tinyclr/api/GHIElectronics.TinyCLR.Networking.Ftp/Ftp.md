---
title: "Ftp Class"
sidebar_label: "Ftp"
---

# Ftp Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `System.Net`

Represents the types of FTP protocol methods that can be used with an FTP request.

```csharp
public static class Ftp
```

## Fields

### DeleteFile

```csharp
public const string DeleteFile
```

Represents the FTP DELE protocol method that deletes a file on an FTP server.

### DownloadFile

```csharp
public const string DownloadFile
```

Represents the FTP RETR protocol method that downloads a file from an FTP server.

### GetFileSize

```csharp
public const string GetFileSize
```

Represents the FTP SIZE protocol method that retrieves the size of a file on an FTP server.

### ListDirectory

```csharp
public const string ListDirectory
```

Represents the FTP NLST protocol method that gets a short listing of the files on an FTP server.

### ListDirectoryDetails

```csharp
public const string ListDirectoryDetails
```

Represents the FTP LIST protocol method that gets a detailed listing of the files on an FTP server.

### MakeDirectory

```csharp
public const string MakeDirectory
```

Represents the FTP MKD protocol method that creates a directory on an FTP server.

### RemoveDirectory

```csharp
public const string RemoveDirectory
```

Represents the FTP RMD protocol method that removes a directory.

### Rename

```csharp
public const string Rename
```

Represents the FTP RENAME protocol method that renames a file or directory.

### UploadFile

```csharp
public const string UploadFile
```

Represents the FTP STOR protocol method that uploads a file to an FTP server.
