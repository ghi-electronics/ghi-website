---
title: "Rectangle Struct"
sidebar_label: "Rectangle"
---

# Rectangle Struct

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

An integer rectangle defined by upper-left corner (X,Y) and size (Width,Height).

```csharp
public struct Rectangle
```

## Constructors

### Rectangle(int x, int y, int width, int height)

```csharp
public Rectangle(int x, int y, int width, int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |

## Properties

### X

```csharp
public int X { get; set; }
```

Sets the x axis position. It must be between –32,768 to +32,767. _(inherited)_

### Y

```csharp
public int Y { get; set; }
```

Sets the y axis position. It must be between –32,768 to +32,767. _(inherited)_

### Width

```csharp
public int Width { get; set; }
```

Column width in pixels. _(inherited)_

### Height

```csharp
public int Height { get; set; }
```

Frame height in pixels. _(inherited)_
