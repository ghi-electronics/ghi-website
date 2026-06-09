---
title: "Graphics Class"
sidebar_label: "Graphics"
---

# Graphics Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

2-D drawing surface backed by a `Bitmap`. Issue line, rectangle, ellipse, text, and image draws against this surface, then push the result to the display via `Flush(IntPtr)`.

```csharp
public class Graphics : MarshalByRefObject, IDisposable
```

## Properties

### Width

```csharp
public int Width { get; }
```

Column width in pixels. _(inherited)_

### Height

```csharp
public int Height { get; }
```

Frame height in pixels. _(inherited)_

### PageUnit

```csharp
public GraphicsUnit PageUnit { get; }
```

_No description available._

## Methods

### GetPixel(int x, int y)

```csharp
public uint GetPixel(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `uint`

### SetPixel(int x, int y, Color color)

```csharp
public void SetPixel(int x, int y, Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `color` | `Color` |  |

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

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

**Returns** `byte[]`

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### MeasureString(string text, Font font)

```csharp
public SizeF MeasureString(string text, Font font)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |
| `font` | `Font` |  |

**Returns** `SizeF`

### MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)

```csharp
public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |
| `font` | `Font` |  |
| `layoutArea` | `SizeF` |  |
| `stringFormat` | `StringFormat` |  |

**Returns** `SizeF`

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_

### FromHdc(IntPtr hdc)

```csharp
public static Graphics FromHdc(IntPtr hdc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `hdc` | `IntPtr` |  |

**Returns** `Graphics`

### FromImage(Image image)

```csharp
public static Graphics FromImage(Image image)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `image` | `Image` |  |

**Returns** `Graphics`

### Flush()

```csharp
public void Flush()
```

Writes unwritten data to the file. _(inherited)_

### DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit)

```csharp
public void DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `image` | `Image` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `srcRect` | `Rectangle` |  |
| `srcUnit` | `GraphicsUnit` |  |

### DrawImage(Image image, int x, int y, int width, int height)

```csharp
public void DrawImage(Image image, int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `image` | `Image` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### DrawImage(Image image, int x, int y)

```csharp
public void DrawImage(Image image, int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `image` | `Image` |  |
| `x` | `int` |  |
| `y` | `int` |  |

### DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit)

```csharp
public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `image` | `Image` |  |
| `destRect` | `Rectangle` |  |
| `srcRect` | `Rectangle` |  |
| `srcUnit` | `GraphicsUnit` |  |

### DrawLine(Pen pen, int x1, int y1, int x2, int y2)

```csharp
public void DrawLine(Pen pen, int x1, int y1, int x2, int y2)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pen` | `Pen` |  |
| `x1` | `int` |  |
| `y1` | `int` |  |
| `x2` | `int` |  |
| `y2` | `int` |  |

### DrawString(string s, Font font, Brush brush, float x, float y)

```csharp
public void DrawString(string s, Font font, Brush brush, float x, float y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `s` | `string` |  |
| `font` | `Font` |  |
| `brush` | `Brush` |  |
| `x` | `float` |  |
| `y` | `float` |  |

### DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle)

```csharp
public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `s` | `string` |  |
| `font` | `Font` |  |
| `brush` | `Brush` |  |
| `layoutRectangle` | `RectangleF` |  |

### DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)

```csharp
public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `s` | `string` |  |
| `font` | `Font` |  |
| `brush` | `Brush` |  |
| `layoutRectangle` | `RectangleF` |  |
| `format` | `StringFormat` |  |

### DrawEllipse(Pen pen, int x, int y, int width, int height)

```csharp
public void DrawEllipse(Pen pen, int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pen` | `Pen` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### DrawRectangle(Pen pen, int x, int y, int width, int height)

```csharp
public void DrawRectangle(Pen pen, int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pen` | `Pen` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### FillEllipse(Brush brush, int x, int y, int width, int height)

```csharp
public void FillEllipse(Brush brush, int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### FillRectangle(Brush brush, int x, int y, int width, int height)

```csharp
public void FillRectangle(Brush brush, int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### DrawImage(int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)

```csharp
public void DrawImage(int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `image` | `Image` |  |
| `xSrc` | `int` |  |
| `ySrc` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `opacity` | `ushort` |  |

### Flush(int x, int y, int width, int height)

```csharp
public void Flush(int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### SetClippingRectangle(int x, int y, int width, int height)

```csharp
public void SetClippingRectangle(int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### DrawTextInRect(string text, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)

```csharp
public void DrawTextInRect(string text, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `dtFlags` | `DrawTextAlignment` |  |
| `color` | `Color` |  |
| `font` | `Font` |  |

### DrawTextInRect(ref string text, ref int xRelStart, ref int yRelStart, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)

```csharp
public bool DrawTextInRect(ref string text, ref int xRelStart, ref int yRelStart, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `ref string` |  |
| `xRelStart` | `ref int` |  |
| `yRelStart` | `ref int` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `dtFlags` | `DrawTextAlignment` |  |
| `color` | `Color` |  |
| `font` | `Font` |  |

**Returns** `bool`

### RotateImage(int angle, int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)

```csharp
public void RotateImage(int angle, int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `angle` | `int` |  |
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `image` | `Image` |  |
| `xSrc` | `int` |  |
| `ySrc` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `opacity` | `ushort` |  |

### MakeTransparent(Color color)

```csharp
public void MakeTransparent(Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `color` | `Color` |  |

### StretchImage(int xDst, int yDst, int widthDst, int heightDst, Image image, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)

```csharp
public void StretchImage(int xDst, int yDst, int widthDst, int heightDst, Image image, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `widthDst` | `int` |  |
| `heightDst` | `int` |  |
| `image` | `Image` |  |
| `xSrc` | `int` |  |
| `ySrc` | `int` |  |
| `widthSrc` | `int` |  |
| `heightSrc` | `int` |  |
| `opacity` | `ushort` |  |

### TileImage(int xDst, int yDst, Image image, int width, int height, ushort opacity)

```csharp
public void TileImage(int xDst, int yDst, Image image, int width, int height, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `image` | `Image` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `opacity` | `ushort` |  |

### Scale9Image(int xDst, int yDst, int widthDst, int heightDst, Image image, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)

```csharp
public void Scale9Image(int xDst, int yDst, int widthDst, int heightDst, Image image, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `widthDst` | `int` |  |
| `heightDst` | `int` |  |
| `image` | `Image` |  |
| `leftBorder` | `int` |  |
| `topBorder` | `int` |  |
| `rightBorder` | `int` |  |
| `bottomBorder` | `int` |  |
| `opacity` | `ushort` |  |

## Events

### OnFlushEvent

```csharp
static public event OnFlushHandler OnFlushEvent
```

_No description available._
