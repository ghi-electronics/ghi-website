---
title: "BufferDrawTargetRgb444 Class"
sidebar_label: "BufferDrawTargetRgb444"
---

# BufferDrawTargetRgb444 Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `GHIElectronics.TinyCLR.Drawing`

_No description available._

```csharp
public class BufferDrawTargetRgb444 : BufferDrawTarget
```

## Constructors

### BufferDrawTargetRgb444(int width, int height)

```csharp
public BufferDrawTargetRgb444(int width, int height) : base(width, height, 12)
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
