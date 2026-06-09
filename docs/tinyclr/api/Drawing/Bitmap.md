---
title: "Bitmap Class"
sidebar_label: "Bitmap"
---

# Bitmap Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

A raster bitmap loaded from a resource or stream (BMP/JPEG/GIF; PNG and TIFF are not supported).

```csharp
public class Bitmap : Image
```

## Constructors

### Bitmap(int width, int height)

```csharp
public Bitmap(int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `int` |  |
| `height` | `int` |  |

### Bitmap(byte[] data, int width, int height)

```csharp
public Bitmap(byte[] data, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `data` | `byte[]` |  |
| `width` | `int` |  |
| `height` | `int` |  |

### Bitmap(Stream stream)

```csharp
public Bitmap(Stream stream)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `stream` | `Stream` |  |

### Bitmap(byte[] buffer, BitmapImageType type)

```csharp
public Bitmap(byte[] buffer, BitmapImageType type)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `type` | `BitmapImageType` |  |

### Bitmap(byte[] buffer, int offset, int count, BitmapImageType type)

```csharp
public Bitmap(byte[] buffer, int offset, int count, BitmapImageType type)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `type` | `BitmapImageType` |  |

## Methods

### SetPixel(int x, int y, Color color)

```csharp
public override void SetPixel(int x, int y, Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `color` | `Color` |  |

### GetPixel(int x, int y)

```csharp
public override Color GetPixel(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `Color`
