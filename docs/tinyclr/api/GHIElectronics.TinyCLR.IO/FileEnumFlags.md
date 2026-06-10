---
title: "FileEnumFlags Enum"
sidebar_label: "FileEnumFlags"
---

# FileEnumFlags Enum

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Selects which kinds of entries a file enumeration returns.

```csharp
public enum FileEnumFlags
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Files` | `0x0001` | Enumerate only files. |
| `Directories` | `0x0002` | Enumerate only directories. |
| `FilesAndDirectories` | `Files \| Directories` | Enumerate both files and directories. |
