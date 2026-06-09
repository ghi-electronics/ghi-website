---
title: "Line Class"
sidebar_label: "Line"
---

# Line Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Shapes`

_No description available._

```csharp
public class Line : Shape
```

## Constructors

### Line()

```csharp
public Line() : this(0, 0)
```

_No description available._

### Line(int dx, int dy)

```csharp
public Line(int dx, int dy)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `dx` | `int` |  |
| `dy` | `int` |  |

## Properties

### Direction

```csharp
public Direction Direction { get; set; }
```

The new direction of the hat switch. _(inherited)_

## Methods

### OnRender(Media.DrawingContext dc)

```csharp
public override void OnRender(Media.DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `Media.DrawingContext` |  |
