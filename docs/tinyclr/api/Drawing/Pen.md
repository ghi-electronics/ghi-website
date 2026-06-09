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

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `color` | `Color` |  |

### Pen(Brush brush)

```csharp
public Pen(Brush brush) : this(brush, 1.0f)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |

### Pen(Color color, float width)

```csharp
public Pen(Color color, float width)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `color` | `Color` |  |
| `width` | `float` |  |

### Pen(Brush brush, float width)

```csharp
public Pen(Brush brush, float width)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `brush` | `Brush` |  |
| `width` | `float` |  |

## Properties

### Width

```csharp
public float Width { get; set; }
```

Column width in pixels. _(inherited)_

### Color

```csharp
public Color Color { get; set; }
```

_No description available._

### PenType

```csharp
public PenType PenType { get; }
```

_No description available._

### Brush

```csharp
public Brush Brush { get; set; }
```

_No description available._

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Clone()

```csharp
public object Clone()
```

Creates a new object that is a copy of the current instance. _(inherited)_

**Returns** `object`
