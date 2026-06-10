---
title: "GHIElectronics.TinyCLR.Drawing"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Drawing</h1>

**NuGet:** `GHIElectronics.TinyCLR.Drawing`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Bitmap](./Bitmap.md) | `System.Drawing` | A raster bitmap loaded from a resource or stream (BMP/JPEG/GIF; PNG and TIFF are not supported). |
| [Brush](./Brush.md) | `System.Drawing` | Abstract base for objects that fill graphics shapes (rectangles, ellipses, paths). |
| [Graphics](./Graphics.md) | `System.Drawing` | 2-D drawing surface backed by a `Bitmap`. Issue line, rectangle, ellipse, text, and image draws against this surface, then push the result to the display via `Flush(IntPtr)`. |
| [Image](./Image.md) | `System.Drawing` | Abstract base for raster images. Concrete subclass: `Bitmap`. |
| [ImageFormat](./ImageFormat.md) | `System.Drawing.Imaging` | Identifies the file format of an image by a unique GUID. |
| [Pen](./Pen.md) | `System.Drawing` | Defines an object used to draw lines and outlines — color, width, and brush. |
| [SolidBrush](./SolidBrush.md) | `System.Drawing` | A brush that fills with a single solid `Color`. |
| [StringFormat](./StringFormat.md) | `System.Drawing` | Encapsulates text layout information such as alignment, trimming, and format flags. |

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
| [BitFormat](./BitFormat.md) | `System.Drawing` | Specifies the bit ordering used when converting to 1 bit per pixel. |
| [BitmapImageType](./BitmapImageType.md) | `System.Drawing` | Identifies the encoded format of bitmap data. |
| [ColorFormat](./ColorFormat.md) | `System.Drawing` | Specifies the bits-per-pixel layout of color data. |
| [DrawTextAlignment](./DrawTextAlignment.md) | `System.Drawing` | Bit flags that control how text is aligned, wrapped, and trimmed within a rectangle. |
| [PenType](./PenType.md) | `System.Drawing.Drawing2D` | Specifies the type of fill a pen uses. |
| [RgbFormat](./RgbFormat.md) | `System.Drawing` | Specifies the channel ordering of color data. |
| [StringAlignment](./StringAlignment.md) | `System.Drawing` | Specifies how text is aligned within its layout rectangle. |
| [StringFormatFlags](./StringFormatFlags.md) | `System.Drawing` | Bit flags that control text layout and rendering behavior. |
| [StringTrimming](./StringTrimming.md) | `System.Drawing` | Specifies how text is trimmed when it does not fit in the layout rectangle. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [OnFlushHandler](./OnFlushHandler.md) | `System.Drawing` | Represents the method that handles the flush event for a drawing surface. |
