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

The width of the drawing surface in pixels.

### Height

```csharp
public int Height { get; }
```

The height of the drawing surface in pixels.

## Methods

### Translate(int dx, int dy)

```csharp
public void Translate(int dx, int dy)
```

Offsets the origin of subsequent drawing operations.

### GetTranslation(out int x, out int y)

```csharp
public void GetTranslation(out int x, out int y)
```

Gets the current drawing origin offset.

### Clear()

```csharp
public void Clear()
```

Clears the drawing surface.

### DrawPolygon(Brush brush, Pen pen, int[] pts)

```csharp
public void DrawPolygon(Brush brush, Pen pen, int[] pts)
```

Draws a polygon defined by the given points.

### SetPixel(Color color, int x, int y)

```csharp
public void SetPixel(Color color, int x, int y)
```

Sets a single pixel to the given color.

### DrawLine(Pen pen, int x0, int y0, int x1, int y1)

```csharp
public void DrawLine(Pen pen, int x0, int y0, int x1, int y1)
```

Draws a line between two points.

### DrawEllipse(Brush brush, Pen pen, int x, int y, int xRadius, int yRadius)

```csharp
public void DrawEllipse(Brush brush, Pen pen, int x, int y, int xRadius, int yRadius)
```

Draws an ellipse with the given fill and outline.

### DrawImage(ImageSource source, int x, int y)

```csharp
public void DrawImage(ImageSource source, int x, int y)
```

Draws an image at the given position.

### DrawImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight)

```csharp
public void DrawImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight)
```

Draws a region of an image at the given position.

### BlendImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)

```csharp
public void BlendImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)
```

Draws a region of an image blended with the given opacity.

### RotateImage(int angle, int destinationX, int destinationY, ImageSource bitmap, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)

```csharp
public void RotateImage(int angle, int destinationX, int destinationY, ImageSource bitmap, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)
```

Draws a region of an image rotated by the given angle.

### StretchImage(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)

```csharp
public void StretchImage(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)
```

Draws a region of an image stretched to the given size.

### TileImage(int xDst, int yDst, ImageSource bitmap, int width, int height, ushort opacity)

```csharp
public void TileImage(int xDst, int yDst, ImageSource bitmap, int width, int height, ushort opacity)
```

Draws an image tiled across the given area.

### Scale9Image(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)

```csharp
public void Scale9Image(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)
```

Draws an image using nine-slice scaling with the given borders.

### DrawText(string text, System.Drawing.Font font, Color color, int x, int y)

```csharp
public void DrawText(string text, System.Drawing.Font font, Color color, int x, int y)
```

Draws text at the given position.

### DrawText(ref string text, System.Drawing.Font font, Color color, int x, int y, int width, int height, TextAlignment alignment, TextTrimming trimming)

```csharp
public bool DrawText(ref string text, System.Drawing.Font font, Color color, int x, int y, int width, int height, TextAlignment alignment, TextTrimming trimming)
```

Draws text within a rectangle using the given alignment and trimming.

**Returns** `bool`

### GetClippingRectangle(out int x, out int y, out int width, out int height)

```csharp
public void GetClippingRectangle(out int x, out int y, out int width, out int height)
```

Gets the current clipping rectangle.

### PushClippingRectangle(int x, int y, int width, int height)

```csharp
public void PushClippingRectangle(int x, int y, int width, int height)
```

Pushes a clipping rectangle onto the clip stack.

### PopClippingRectangle()

```csharp
public void PopClippingRectangle()
```

Pops the most recently pushed clipping rectangle.

### DrawRectangle(Brush brush, Pen pen, int x, int y, int width, int height)

```csharp
public void DrawRectangle(Brush brush, Pen pen, int x, int y, int width, int height)
```

Draws a rectangle with the given fill and outline.

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by the drawing context.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the resources used by the drawing context.
