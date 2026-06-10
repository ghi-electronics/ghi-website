---
title: "Shape Class"
sidebar_label: "Shape"
---

# Shape Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Shapes`

Base class for elements that draw a shape.

```csharp
public abstract class Shape : UIElement
```

## Properties

### Fill

```csharp
public Media.Brush Fill { get; set; }
```

The brush used to fill the shape.

### Stroke

```csharp
public Media.Pen Stroke { get; set; }
```

The pen used to draw the outline of the shape.
