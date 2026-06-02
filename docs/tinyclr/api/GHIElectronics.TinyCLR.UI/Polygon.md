---
title: "Polygon Class"
sidebar_label: "Polygon"
---

# Polygon Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Shapes` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class Polygon : Shape
```

## Constructors

### Polygon()

```csharp
public Polygon()
```

_No description available._

### Polygon(int[] pts)

```csharp
public Polygon(int[] pts)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `pts` | `int[]` |  |

## Properties

### Points

```csharp
public int[] Points { get; set; }
```

_No description available._

## Methods

### OnRender(Media.DrawingContext dc)

```csharp
public override void OnRender(Media.DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `Media.DrawingContext` |  |
