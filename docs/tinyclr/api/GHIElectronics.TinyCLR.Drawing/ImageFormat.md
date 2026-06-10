---
title: "ImageFormat Class"
sidebar_label: "ImageFormat"
---

# ImageFormat Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing.Imaging`

Identifies the file format of an image by a unique GUID.

```csharp
public sealed class ImageFormat
```

## Constructors

### ImageFormat(Guid guid)

```csharp
public ImageFormat(Guid guid)
```

Initializes a new image format identified by the given GUID.

## Properties

### Guid

```csharp
public Guid Guid { get; }
```

Gets the GUID that identifies this image format.

### RawBitmap

```csharp
public static ImageFormat RawBitmap { get; }
```

Gets the raw (uncompressed) bitmap format.

### Bmp

```csharp
public static ImageFormat Bmp { get; }
```

Gets the Windows bitmap (BMP) format.

### Emf

```csharp
public static ImageFormat Emf { get; }
```

Gets the enhanced metafile (EMF) format.

### Wmf

```csharp
public static ImageFormat Wmf { get; }
```

Gets the Windows metafile (WMF) format.

### Gif

```csharp
public static ImageFormat Gif { get; }
```

Gets the GIF format.

### Jpeg

```csharp
public static ImageFormat Jpeg { get; }
```

Gets the JPEG format.

### Png

```csharp
public static ImageFormat Png { get; }
```

Gets the PNG format.

### Tiff

```csharp
public static ImageFormat Tiff { get; }
```

Gets the TIFF format.

### Exif

```csharp
public static ImageFormat Exif { get; }
```

Gets the EXIF format.

### Icon

```csharp
public static ImageFormat Icon { get; }
```

Gets the icon format.

## Methods

### Equals(object o)

```csharp
public override bool Equals(object o)
```

Determines whether the specified object is an image format with the same GUID.

**Returns** `bool`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Returns a hash code for this image format.

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

Returns the name of this image format.

**Returns** `string`
