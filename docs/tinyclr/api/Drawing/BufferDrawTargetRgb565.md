---
title: "BufferDrawTargetRgb565 Class"
sidebar_label: "BufferDrawTargetRgb565"
---

# BufferDrawTargetRgb565 Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `GHIElectronics.TinyCLR.Drawing`

_No description available._

```csharp
public class BufferDrawTargetRgb565 : BufferDrawTarget
```

## Constructors

### BufferDrawTargetRgb565(int width, int height)

```csharp
public BufferDrawTargetRgb565(int width, int height) : base(width, height, 16)
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
