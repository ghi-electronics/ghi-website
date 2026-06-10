---
title: "Image Class"
sidebar_label: "Image"
---

# Image Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

Abstract base for raster images. Concrete subclass: `Bitmap`.

```csharp
public abstract class Image : MarshalByRefObject, ICloneable, IDisposable
```

## Properties

### Width

```csharp
public int Width { get; }
```

Gets the width of this image in pixels.

### Height

```csharp
public int Height { get; }
```

Gets the height of this image in pixels.

## Methods

### Clone()

```csharp
public object Clone()
```

Creates a copy of this image.

**Returns** `object`

### FromStream(Stream stream)

```csharp
public static Image FromStream(Stream stream)
```

Creates an image from data in the given stream.

**Returns** `Image`

### Save(Stream stream, ImageFormat format)

```csharp
public void Save(Stream stream, ImageFormat format)
```

Saves this image to the given stream in the specified format (only RawBitmap and Bmp are supported).

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the resources used by this image.

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by this image.

### SetPixel(int x, int y, Color color)

```csharp
public virtual void SetPixel(int x, int y, Color color)
```

Sets the color of the pixel at the given coordinates.

### GetPixel(int x, int y)

```csharp
public virtual Color GetPixel(int x, int y)
```

Gets the color of the pixel at the given coordinates.

**Returns** `Color`

### GetBitmap()

```csharp
public byte[] GetBitmap()
```

Gets the raw pixel data of this image.

**Returns** `byte[]`

### GetBitmap(int x, int y, int width, int height)

```csharp
public byte[] GetBitmap(int x, int y, int width, int height)
```

Gets the raw pixel data for a rectangular region of this image.

**Returns** `byte[]`

### MakeTransparent(Color color)

```csharp
public void MakeTransparent(Color color)
```

Makes the given color transparent in this image.
