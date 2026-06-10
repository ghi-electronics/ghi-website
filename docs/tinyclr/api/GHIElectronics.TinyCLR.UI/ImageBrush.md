---
title: "ImageBrush Class"
sidebar_label: "ImageBrush"
---

# ImageBrush Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Media`

A brush that paints a region with an image.

```csharp
public sealed class ImageBrush : Brush
```

## Constructors

### ImageBrush(ImageSource imagesource)

```csharp
public ImageBrush(ImageSource imagesource)
```

Creates a brush that paints with the given image.

## Fields

### ImageSource

```csharp
public ImageSource ImageSource
```

The image painted by the brush.

### Stretch

```csharp
public Stretch Stretch
```

How the image is stretched to fill the region.
