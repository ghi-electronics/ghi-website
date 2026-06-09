---
title: "SynchronizationMode Enum"
sidebar_label: "SynchronizationMode"
---

# SynchronizationMode Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Camera` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Camera`

How the camera frames its data.

```csharp
public enum SynchronizationMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Hardware` | `0` | Discrete HSYNC/VSYNC signals. |
| `Embedded` | `1` | Synchronization codes embedded in the data stream (ITU-R BT.656 style). |
