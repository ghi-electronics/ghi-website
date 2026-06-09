---
title: "DrawingContext Class"
sidebar_label: "DrawingContext"
---

# DrawingContext Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Media`

Drawing Context.

```csharp
public class DrawingContext : DispatcherObject, IDisposable
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

### Translate(int dx, int dy)

```csharp
public void Translate(int dx, int dy)
```

_No description available._

### GetTranslation(out int x, out int y)

```csharp
public void GetTranslation(out int x, out int y)
```

_No description available._

### Clear()

```csharp
public void Clear()
```

_No description available._

### DrawPolygon(Brush brush, Pen pen, int[] pts)

```csharp
public void DrawPolygon(Brush brush, Pen pen, int[] pts)
```

_No description available._

### SetPixel(Color color, int x, int y)

```csharp
public void SetPixel(Color color, int x, int y)
```

_No description available._

### DrawLine(Pen pen, int x0, int y0, int x1, int y1)

```csharp
public void DrawLine(Pen pen, int x0, int y0, int x1, int y1)
```

_No description available._

### DrawEllipse(Brush brush, Pen pen, int x, int y, int xRadius, int yRadius)

```csharp
public void DrawEllipse(Brush brush, Pen pen, int x, int y, int xRadius, int yRadius)
```

_No description available._

### DrawImage(ImageSource source, int x, int y)

```csharp
public void DrawImage(ImageSource source, int x, int y)
```

_No description available._

### DrawImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight)

```csharp
public void DrawImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight)
```

_No description available._

### BlendImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)

```csharp
public void BlendImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)
```

_No description available._

### RotateImage(int angle, int destinationX, int destinationY, ImageSource bitmap, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)

```csharp
public void RotateImage(int angle, int destinationX, int destinationY, ImageSource bitmap, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)
```

_No description available._

### StretchImage(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)

```csharp
public void StretchImage(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)
```

_No description available._

### TileImage(int xDst, int yDst, ImageSource bitmap, int width, int height, ushort opacity)

```csharp
public void TileImage(int xDst, int yDst, ImageSource bitmap, int width, int height, ushort opacity)
```

_No description available._

### Scale9Image(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)

```csharp
public void Scale9Image(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)
```

_No description available._

### DrawText(string text, System.Drawing.Font font, Color color, int x, int y)

```csharp
public void DrawText(string text, System.Drawing.Font font, Color color, int x, int y)
```

_No description available._

### DrawText(ref string text, System.Drawing.Font font, Color color, int x, int y, int width, int height, TextAlignment alignment, TextTrimming trimming)

```csharp
public bool DrawText(ref string text, System.Drawing.Font font, Color color, int x, int y, int width, int height, TextAlignment alignment, TextTrimming trimming)
```

_No description available._

**Returns** `bool`

### GetClippingRectangle(out int x, out int y, out int width, out int height)

```csharp
public void GetClippingRectangle(out int x, out int y, out int width, out int height)
```

_No description available._

### PushClippingRectangle(int x, int y, int width, int height)

```csharp
public void PushClippingRectangle(int x, int y, int width, int height)
```

_No description available._

### PopClippingRectangle()

```csharp
public void PopClippingRectangle()
```

_No description available._

### DrawRectangle(Brush brush, Pen pen, int x, int y, int width, int height)

```csharp
public void DrawRectangle(Brush brush, Pen pen, int x, int y, int width, int height)
```

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._
