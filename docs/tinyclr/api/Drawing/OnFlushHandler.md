---
title: "OnFlushHandler Delegate"
sidebar_label: "OnFlushHandler"
---

# OnFlushHandler Delegate

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

Represents the method that handles the flush event for a drawing surface.

```csharp
public delegate void OnFlushHandler(Graphics sender, byte[] data, int x, int y, int width, int height, int originalWidth);
```
