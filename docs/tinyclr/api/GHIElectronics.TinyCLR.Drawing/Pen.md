---
title: "Pen Class"
sidebar_label: "Pen"
---

# Pen Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

Defines an object used to draw lines and outlines — color, width, and brush.

```csharp
public sealed class Pen : MarshalByRefObject, ICloneable, IDisposable
```

## Constructors

### Pen(Color color)

```csharp
public Pen(Color color) : this(color, 1.0f)
```

Initializes a new pen of width 1 with the specified color.

### Pen(Brush brush)

```csharp
public Pen(Brush brush) : this(brush, 1.0f)
```

Initializes a new pen of width 1 with the specified brush.

### Pen(Color color, float width)

```csharp
public Pen(Color color, float width)
```

Initializes a new pen with the specified color and width.

### Pen(Brush brush, float width)

```csharp
public Pen(Brush brush, float width)
```

Initializes a new pen with the specified brush and width.

## Properties

### Width

```csharp
public float Width { get; set; }
```

Gets or sets the width of this pen in pixels.

### Color

```csharp
public Color Color { get; set; }
```

Gets or sets the color of this pen.

### PenType

```csharp
public PenType PenType { get; }
```

Gets the style of this pen.

### Brush

```csharp
public Brush Brush { get; set; }
```

Gets or sets the brush used by this pen; only a solid brush is supported.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by this pen.

### Clone()

```csharp
public object Clone()
```

Creates an exact copy of this pen.

**Returns** `object`
