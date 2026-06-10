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

Initializes a new blank bitmap of the given pixel size.

### Bitmap(byte[] data, int width, int height)

```csharp
public Bitmap(byte[] data, int width, int height)
```

Initializes a new bitmap from raw pixel data of the given pixel size.

### Bitmap(Stream stream)

```csharp
public Bitmap(Stream stream)
```

Initializes a new bitmap by decoding image data from the given stream.

### Bitmap(byte[] buffer, BitmapImageType type)

```csharp
public Bitmap(byte[] buffer, BitmapImageType type)
```

Initializes a new bitmap by decoding image data of the given type.

### Bitmap(byte[] buffer, int offset, int count, BitmapImageType type)

```csharp
public Bitmap(byte[] buffer, int offset, int count, BitmapImageType type)
```

Initializes a new bitmap by decoding a range of image data of the given type.

## Methods

### SetPixel(int x, int y, Color color)

```csharp
public override void SetPixel(int x, int y, Color color)
```

Sets the color of the pixel at the given coordinates.

### GetPixel(int x, int y)

```csharp
public override Color GetPixel(int x, int y)
```

Gets the color of the pixel at the given coordinates.

**Returns** `Color`
