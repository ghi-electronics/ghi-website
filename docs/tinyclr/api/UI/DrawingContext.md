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

Column width in pixels. _(inherited)_

### Height

```csharp
public int Height { get; }
```

Frame height in pixels. _(inherited)_

## Methods

### Translate(int dx, int dy)

```csharp
public void Translate(int dx, int dy)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `dx` | `int` |  |
| `dy` | `int` |  |

### GetTranslation(out int x, out int y)

```csharp
public void GetTranslation(out int x, out int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `out int` |  |
| `y` | `out int` |  |

### Clear()

```csharp
public void Clear()
```

Removes all elements from the UIElementCollection. _(inherited)_

### DrawPolygon(Brush brush, Pen pen, int[] pts)

```csharp
public void DrawPolygon(Brush brush, Pen pen, int[] pts)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |
| `pen` | `Pen` |  |
| `pts` | `int[]` |  |

### SetPixel(Color color, int x, int y)

```csharp
public void SetPixel(Color color, int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `color` | `Color` |  |
| `x` | `int` |  |
| `y` | `int` |  |

### DrawLine(Pen pen, int x0, int y0, int x1, int y1)

```csharp
public void DrawLine(Pen pen, int x0, int y0, int x1, int y1)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pen` | `Pen` |  |
| `x0` | `int` |  |
| `y0` | `int` |  |
| `x1` | `int` |  |
| `y1` | `int` |  |

### DrawEllipse(Brush brush, Pen pen, int x, int y, int xRadius, int yRadius)

```csharp
public void DrawEllipse(Brush brush, Pen pen, int x, int y, int xRadius, int yRadius)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |
| `pen` | `Pen` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `xRadius` | `int` |  |
| `yRadius` | `int` |  |

### DrawImage(ImageSource source, int x, int y)

```csharp
public void DrawImage(ImageSource source, int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `ImageSource` |  |
| `x` | `int` |  |
| `y` | `int` |  |

### DrawImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight)

```csharp
public void DrawImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `ImageSource` |  |
| `destinationX` | `int` |  |
| `destinationY` | `int` |  |
| `sourceX` | `int` |  |
| `sourceY` | `int` |  |
| `sourceWidth` | `int` |  |
| `sourceHeight` | `int` |  |

### BlendImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)

```csharp
public void BlendImage(ImageSource source, int destinationX, int destinationY, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `source` | `ImageSource` |  |
| `destinationX` | `int` |  |
| `destinationY` | `int` |  |
| `sourceX` | `int` |  |
| `sourceY` | `int` |  |
| `sourceWidth` | `int` |  |
| `sourceHeight` | `int` |  |
| `opacity` | `ushort` |  |

### RotateImage(int angle, int destinationX, int destinationY, ImageSource bitmap, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)

```csharp
public void RotateImage(int angle, int destinationX, int destinationY, ImageSource bitmap, int sourceX, int sourceY, int sourceWidth, int sourceHeight, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `angle` | `int` |  |
| `destinationX` | `int` |  |
| `destinationY` | `int` |  |
| `bitmap` | `ImageSource` |  |
| `sourceX` | `int` |  |
| `sourceY` | `int` |  |
| `sourceWidth` | `int` |  |
| `sourceHeight` | `int` |  |
| `opacity` | `ushort` |  |

### StretchImage(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)

```csharp
public void StretchImage(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int xSrc, int ySrc, int widthSrc, int heightSrc, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `widthDst` | `int` |  |
| `heightDst` | `int` |  |
| `bitmap` | `ImageSource` |  |
| `xSrc` | `int` |  |
| `ySrc` | `int` |  |
| `widthSrc` | `int` |  |
| `heightSrc` | `int` |  |
| `opacity` | `ushort` |  |

### TileImage(int xDst, int yDst, ImageSource bitmap, int width, int height, ushort opacity)

```csharp
public void TileImage(int xDst, int yDst, ImageSource bitmap, int width, int height, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `bitmap` | `ImageSource` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `opacity` | `ushort` |  |

### Scale9Image(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)

```csharp
public void Scale9Image(int xDst, int yDst, int widthDst, int heightDst, ImageSource bitmap, int leftBorder, int topBorder, int rightBorder, int bottomBorder, ushort opacity)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `xDst` | `int` |  |
| `yDst` | `int` |  |
| `widthDst` | `int` |  |
| `heightDst` | `int` |  |
| `bitmap` | `ImageSource` |  |
| `leftBorder` | `int` |  |
| `topBorder` | `int` |  |
| `rightBorder` | `int` |  |
| `bottomBorder` | `int` |  |
| `opacity` | `ushort` |  |

### DrawText(string text, System.Drawing.Font font, Color color, int x, int y)

```csharp
public void DrawText(string text, System.Drawing.Font font, Color color, int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `string` |  |
| `font` | `System.Drawing.Font` |  |
| `color` | `Color` |  |
| `x` | `int` |  |
| `y` | `int` |  |

### DrawText(ref string text, System.Drawing.Font font, Color color, int x, int y, int width, int height, TextAlignment alignment, TextTrimming trimming)

```csharp
public bool DrawText(ref string text, System.Drawing.Font font, Color color, int x, int y, int width, int height, TextAlignment alignment, TextTrimming trimming)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `text` | `ref string` |  |
| `font` | `System.Drawing.Font` |  |
| `color` | `Color` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `alignment` | `TextAlignment` |  |
| `trimming` | `TextTrimming` |  |

**Returns** `bool`

### GetClippingRectangle(out int x, out int y, out int width, out int height)

```csharp
public void GetClippingRectangle(out int x, out int y, out int width, out int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `out int` |  |
| `y` | `out int` |  |
| `width` | `out int` |  |
| `height` | `out int` |  |

### PushClippingRectangle(int x, int y, int width, int height)

```csharp
public void PushClippingRectangle(int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

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

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |
| `pen` | `Pen` |  |
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |
