---
title: "Pen Class"
sidebar_label: "Pen"
---

# Pen Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Media`

Describes the color and thickness used to draw outlines.

```csharp
public class Pen
```

## Constructors

### Pen(Color color)

```csharp
public Pen(Color color) : this(color, 1)
```

Creates a pen of the given color with a thickness of one.

### Pen(Color color, ushort thickness)

```csharp
public Pen(Color color, ushort thickness)
```

Creates a pen of the given color and thickness.

## Fields

### Color

```csharp
public Color Color
```

The color of the pen.

### Thickness

```csharp
public ushort Thickness
```

The thickness of the pen in pixels.
