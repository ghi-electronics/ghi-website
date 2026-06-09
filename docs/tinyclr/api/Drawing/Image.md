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

Column width in pixels. _(inherited)_

### Height

```csharp
public int Height { get; }
```

Frame height in pixels. _(inherited)_

## Methods

### Clone()

```csharp
public object Clone()
```

Creates a new object that is a copy of the current instance. _(inherited)_

**Returns** `object`

### FromStream(Stream stream)

```csharp
public static Image FromStream(Stream stream)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `stream` | `Stream` |  |

**Returns** `Image`

### Save(Stream stream, ImageFormat format)

```csharp
public void Save(Stream stream, ImageFormat format)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `stream` | `Stream` |  |
| `format` | `ImageFormat` |  |

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### SetPixel(int x, int y, Color color)

```csharp
public virtual void SetPixel(int x, int y, Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `color` | `Color` |  |

### GetPixel(int x, int y)

```csharp
public virtual Color GetPixel(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

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

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

**Returns** `byte[]`

### MakeTransparent(Color color)

```csharp
public void MakeTransparent(Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `color` | `Color` |  |
