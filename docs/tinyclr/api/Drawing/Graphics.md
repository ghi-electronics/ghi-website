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

**Returns** `uint`

### SetPixel(int x, int y, Color color)

```csharp
public void SetPixel(int x, int y, Color color)
```

_No description available._

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

**Returns** `SizeF`

### MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)

```csharp
public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)
```

_No description available._

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

**Returns** `Graphics`

### FromImage(Image image)

```csharp
public static Graphics FromImage(Image image)
```

_No description available._

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

### DrawImage(Image image, int x, int y, int width, int height)

```csharp
public void DrawImage(Image image, int x, int y, int width, int height)
```

_No description available._

### DrawImage(Image image, int x, int y)

```csharp
public void DrawImage(Image image, int x, int y)
```

_No description available._

### DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit)

```csharp
public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit)
```

_No description available._

### DrawLine(Pen pen, int x1, int y1, int x2, int y2)

```csharp
public void DrawLine(Pen pen, int x1, int y1, int x2, int y2)
```

_No description available._

### DrawString(string s, Font font, Brush brush, float x, float y)

```csharp
public void DrawString(string s, Font font, Brush brush, float x, float y)
```

_No description available._

### DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle)

```csharp
public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle)
```

_No description available._

### DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)

```csharp
public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)
```

_No description available._

### DrawEllipse(Pen pen, int x, int y, int width, int height)

```csharp
public void DrawEllipse(Pen pen, int x, int y, int width, int height)
```

_No description available._

### DrawRectangle(Pen pen, int x, int y, int width, int height)

```csharp
public void DrawRectangle(Pen pen, int x, int y, int width, int height)
```

_No description available._

### FillEllipse(Brush brush, int x, int y, int width, int height)

```csharp
public void FillEllipse(Brush brush, int x, int y, int width, int height)
```

_No description available._

### FillRectangle(Brush brush, int x, int y, int width, int height)

```csharp
public void FillRectangle(Brush brush, int x, int y, int width, int height)
```

_No description available._

### DrawImage(int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)

```csharp
public void DrawImage(int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)
```

_No description available._

### Flush(int x, int y, int width, int height)

```csharp
public void Flush(int x, int y, int width, int height)
```

_No description available._

### SetClippingRectangle(int x, int y, int width, int height)

```csharp
public void SetClippingRectangle(int x, int y, int width, int height)
```

_No description available._

### DrawTextInRect(string text, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)

```csharp
public void DrawTextInRect(string text, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)
```

_No description available._

### DrawTextInRect(ref string text, ref int xRelStart, ref int yRelStart, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)

```csharp
public bool DrawTextInRect(ref string text, ref int xRelStart, ref int yRelStart, int x, int y, int width, int height, DrawTextAlignment dtFlags, Color color, Font font)
```

_No description available._

**Returns** `bool`

### RotateImage(int angle, int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)

```csharp
public void RotateImage(int angle, int xDst, int yDst, Image image, int xSrc, int ySrc, int width, int height, ushort opacity)
```

_No description available._

### MakeTransparent(Color color)

```csharp
public void MakeTransparent(Color color)
```

_No description available._

### StretchImage(int xDst, int yDst, int widthDst, int heightDst, Image image, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)

```csharp
public void StretchImage(int xDst, int yDst, int widthDst, int heightDst, Image image, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)
```

_No description available._

### TileImage(int xDst, int yDst, Image image, int width, int height, ushort opacity)

```csharp
public void TileImage(int xDst, int yDst, Image image, int width, int height, ushort opacity)
```

_No description available._

### Scale9Image(int xDst, int yDst, int widthDst, int heightDst, Image image, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)

```csharp
public void Scale9Image(int xDst, int yDst, int widthDst, int heightDst, Image image, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)
```

_No description available._

## Events

### OnFlushEvent

```csharp
static public event OnFlushHandler OnFlushEvent
```

_No description available._
