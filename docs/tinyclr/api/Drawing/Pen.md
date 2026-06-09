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

### Pen(Brush brush)

```csharp
public Pen(Brush brush) : this(brush, 1.0f)
```

_No description available._

### Pen(Color color, float width)

```csharp
public Pen(Color color, float width)
```

_No description available._

### Pen(Brush brush, float width)

```csharp
public Pen(Brush brush, float width)
```

_No description available._

## Properties

### Width

```csharp
public float Width { get; set; }
```

_No description available._

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

_No description available._

### Clone()

```csharp
public object Clone()
```

_No description available._

**Returns** `object`
