---
title: "Polygon Class"
sidebar_label: "Polygon"
---

# Polygon Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Shapes`

Draws a polygon defined by a set of points.

```csharp
public class Polygon : Shape
```

## Constructors

### Polygon()

```csharp
public Polygon()
```

Creates an empty polygon.

### Polygon(int[] pts)

```csharp
public Polygon(int[] pts)
```

Creates a polygon from the given points.

## Properties

### Points

```csharp
public int[] Points { get; set; }
```

The points that define the polygon as alternating x and y coordinates.

## Methods

### OnRender(Media.DrawingContext dc)

```csharp
public override void OnRender(Media.DrawingContext dc)
```

Renders the polygon to the drawing context.
