---
title: "FTPCommand Class"
sidebar_label: "FTPCommand"
---

# FTPCommand Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `System.Net`

Ftp command class

```csharp
public class FTPCommand
```

## Constructors

### FTPCommand(string name, string content)

```csharp
public FTPCommand(string name, string content)
```

Creates an FTP command from a name and its content.

## Fields

### CommandName

```csharp
public string CommandName
```

The FTP command name (upper-cased).

### CommandContent

```csharp
public string CommandContent
```

The argument text that follows the command name.
