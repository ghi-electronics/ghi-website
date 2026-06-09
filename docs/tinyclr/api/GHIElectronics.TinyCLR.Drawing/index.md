---
title: "GHIElectronics.TinyCLR.Drawing"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Drawing NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Bitmap](./Bitmap.md) | `System.Drawing` | A raster bitmap loaded from a resource or stream (BMP/JPEG/GIF; PNG and TIFF are not supported). |
| [Brush](./Brush.md) | `System.Drawing` | Abstract base for objects that fill graphics shapes (rectangles, ellipses, paths). |
| [BufferDrawTarget](./BufferDrawTarget.md) | `GHIElectronics.TinyCLR.Drawing` |  |
| [BufferDrawTargetRgb444](./BufferDrawTargetRgb444.md) | `GHIElectronics.TinyCLR.Drawing` |  |
| [BufferDrawTargetRgb565](./BufferDrawTargetRgb565.md) | `GHIElectronics.TinyCLR.Drawing` |  |
| [BufferDrawTargetVerticalByteStrip1Bpp](./BufferDrawTargetVerticalByteStrip1Bpp.md) | `GHIElectronics.TinyCLR.Drawing` |  |
| [Graphics](./Graphics.md) | `System.Drawing` | 2-D drawing surface backed by a `Bitmap`. Issue line, rectangle, ellipse, text, and image draws against this surface, then push the result to the display via `Flush(IntPtr)`. |
| [Image](./Image.md) | `System.Drawing` | Abstract base for raster images. Concrete subclass: `Bitmap`. |
| [ImageFormat](./ImageFormat.md) | `System.Drawing.Imaging` |  |
| [Pen](./Pen.md) | `System.Drawing` | Defines an object used to draw lines and outlines — color, width, and brush. |
| [SolidBrush](./SolidBrush.md) | `System.Drawing` | A brush that fills with a single solid `Color`. |
| [StringFormat](./StringFormat.md) | `System.Drawing` |  |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [Color](./Color.md) | `System.Drawing` | 32-bit ARGB color value. Construct via `FromArgb(int, int, int)` / `FromArgb(int, int, int, int)`, or use one of the named static constants. |
| [Rectangle](./Rectangle.md) | `System.Drawing` | An integer rectangle defined by upper-left corner (X,Y) and size (Width,Height). |
| [RectangleF](./RectangleF.md) | `System.Drawing` | A floating-point rectangle defined by upper-left corner (X,Y) and size (Width,Height). |
| [SizeF](./SizeF.md) | `System.Drawing` | A floating-point width × height size. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [BitFormat](./BitFormat.md) | `System.Drawing` |  |
| [BitmapImageType](./BitmapImageType.md) | `System.Drawing` |  |
| [ColorFormat](./ColorFormat.md) | `System.Drawing` |  |
| [DrawTextAlignment](./DrawTextAlignment.md) | `System.Drawing` |  |
| [PenType](./PenType.md) | `System.Drawing.Drawing2D` |  |
| [RgbFormat](./RgbFormat.md) | `System.Drawing` |  |
| [StringAlignment](./StringAlignment.md) | `System.Drawing` |  |
| [StringFormatFlags](./StringFormatFlags.md) | `System.Drawing` |  |
| [StringTrimming](./StringTrimming.md) | `System.Drawing` |  |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [OnFlushHandler](./OnFlushHandler.md) | `System.Drawing` |  |
