---
title: "Line Class"
sidebar_label: "Line"
---

# Line Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Shapes`

Draws a straight line.

```csharp
public class Line : Shape
```

## Constructors

### Line()

```csharp
public Line() : this(0, 0)
```

Creates a line with no length.

### Line(int dx, int dy)

```csharp
public Line(int dx, int dy)
```

Creates a line spanning the given horizontal and vertical extents.

## Properties

### Direction

```csharp
public Direction Direction { get; set; }
```

The direction in which the line is drawn.

## Methods

### OnRender(Media.DrawingContext dc)

```csharp
public override void OnRender(Media.DrawingContext dc)
```

Renders the line to the drawing context.
