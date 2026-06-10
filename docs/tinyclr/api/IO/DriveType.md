---
title: "DriveType Enum"
sidebar_label: "DriveType"
---

# DriveType Enum

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

Classification of a mounted volume.

```csharp
public enum DriveType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Unknown` | `0` | The drive type is unknown. |
| `NoRootDirectory` | `1` | The drive has no root directory. |
| `Removable` | `2` | The drive is removable, such as an SD card or USB stick. |
| `Fixed` | `3` | The drive is a fixed disk. |
| `Network` | `4` | The drive is a network drive. |
| `CDRom` | `5` | The drive is an optical disc. |
| `Ram` | `6` | The drive is a RAM disk. |
