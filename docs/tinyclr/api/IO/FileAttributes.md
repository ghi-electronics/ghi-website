---
title: "FileAttributes Enum"
sidebar_label: "FileAttributes"
---

# FileAttributes Enum

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Attributes that can be set on a file or directory.

```csharp
public enum FileAttributes
```

## Fields

| Name | Value | Description |
|---|---|---|
| `ReadOnly` | `0x1` | The file or directory is read-only. |
| `Hidden` | `0x2` | The file or directory is hidden. |
| `System` | `0x4` | The file or directory is part of the operating system. |
| `Directory` | `0x10` | The entry is a directory. |
| `Archive` | `0x20` | The file is marked for backup or removal. |
| `Normal` | `0x80` | The file has no other attributes set. |
