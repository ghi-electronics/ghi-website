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

_No description available._

### Height

```csharp
public int Height { get; }
```

_No description available._

## Methods

### Clone()

```csharp
public object Clone()
```

_No description available._

**Returns** `object`

### FromStream(Stream stream)

```csharp
public static Image FromStream(Stream stream)
```

_No description available._

**Returns** `Image`

### Save(Stream stream, ImageFormat format)

```csharp
public void Save(Stream stream, ImageFormat format)
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### SetPixel(int x, int y, Color color)

```csharp
public virtual void SetPixel(int x, int y, Color color)
```

_No description available._

### GetPixel(int x, int y)

```csharp
public virtual Color GetPixel(int x, int y)
```

_No description available._

**Returns** `Color`

### GetBitmap()

```csharp
public byte[] GetBitmap()
```

_No description available._

**Returns** `byte[]`

### GetBitmap(int x, int y, int width, int height)

```csharp
public byte[] GetBitmap(int x, int y, int width, int height)
```

_No description available._

**Returns** `byte[]`

### MakeTransparent(Color color)

```csharp
public void MakeTransparent(Color color)
```

_No description available._
