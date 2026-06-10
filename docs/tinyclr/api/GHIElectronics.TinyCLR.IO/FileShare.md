---
title: "FileShare Enum"
sidebar_label: "FileShare"
---

# FileShare Enum

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Controls the access other openers may have to a file that is already open.

```csharp
public enum FileShare
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | No sharing; the file cannot be reopened until it is closed. |
| `Read` | `1` | Allows the file to be subsequently opened for reading. |
| `Write` | `2` | Allows the file to be subsequently opened for writing. |
| `ReadWrite` | `3` | Allows the file to be subsequently opened for reading or writing. |
