---
title: "BufferDrawTargetVerticalByteStrip1Bpp Class"
sidebar_label: "BufferDrawTargetVerticalByteStrip1Bpp"
---

# BufferDrawTargetVerticalByteStrip1Bpp Class

**Namespace:** `GHIElectronics.TinyCLR.Drawing` · **Assembly:** `GHIElectronics.TinyCLR.Drawing`

_No description available._

```csharp
public class BufferDrawTargetVerticalByteStrip1Bpp : BufferDrawTarget
```

## Constructors

### BufferDrawTargetVerticalByteStrip1Bpp(int width, int height)

```csharp
public BufferDrawTargetVerticalByteStrip1Bpp(int width, int height) : base(width, height, 1)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `int` |  |
| `height` | `int` |  |

## Methods

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
