---
title: "BufferDrawTarget Class"
sidebar_label: "BufferDrawTarget"
---

# BufferDrawTarget Class

**Namespace:** `GHIElectronics.TinyCLR.Drawing` · **Assembly:** `GHIElectronics.TinyCLR.Drawing`

_No description available._

```csharp
public abstract class BufferDrawTarget : IDrawTarget
```

## Constructors

### BufferDrawTarget(int width, int height, int bpp)

```csharp
protected BufferDrawTarget(int width, int height, int bpp)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `int` |  |
| `height` | `int` |  |
| `bpp` | `int` |  |

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

### GetData()

```csharp
public byte[] GetData()
```

_No description available._

**Returns** `byte[]`

### Clear(Color color)

```csharp
public void Clear(Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `color` | `Color` |  |

### Dispose()

```csharp
public virtual void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Flush()

```csharp
public virtual void Flush()
```

Writes unwritten data to the file. _(inherited)_

### GetPixel(int x, int y)

```csharp
public abstract Color GetPixel(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `Color`

### SetPixel(int x, int y, Color color)

```csharp
public abstract void SetPixel(int x, int y, Color color)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `color` | `Color` |  |

## Fields

### buffer

```csharp
protected readonly byte[] buffer
```

_No description available._
