---
title: "Bitmap Class"
sidebar_label: "Bitmap"
---

# Bitmap Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

A raster bitmap loaded from a resource or stream (BMP/JPEG/GIF; PNG and TIFF are not supported).

```csharp
public class Bitmap : Image
```

## Constructors

### Bitmap(int width, int height)

```csharp
public Bitmap(int width, int height)
```

_No description available._

### Bitmap(byte[] data, int width, int height)

```csharp
public Bitmap(byte[] data, int width, int height)
```

_No description available._

### Bitmap(Stream stream)

```csharp
public Bitmap(Stream stream)
```

_No description available._

### Bitmap(byte[] buffer, BitmapImageType type)

```csharp
public Bitmap(byte[] buffer, BitmapImageType type)
```

_No description available._

### Bitmap(byte[] buffer, int offset, int count, BitmapImageType type)

```csharp
public Bitmap(byte[] buffer, int offset, int count, BitmapImageType type)
```

_No description available._

## Methods

### SetPixel(int x, int y, Color color)

```csharp
public override void SetPixel(int x, int y, Color color)
```

_No description available._

### GetPixel(int x, int y)

```csharp
public override Color GetPixel(int x, int y)
```

_No description available._

**Returns** `Color`
