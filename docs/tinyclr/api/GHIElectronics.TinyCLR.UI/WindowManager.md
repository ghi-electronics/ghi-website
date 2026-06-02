---
title: "WindowManager Class"
sidebar_label: "WindowManager"
---

# WindowManager Class

**Namespace:** `GHIElectronics.TinyCLR.UI` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class WindowManager : Controls.Canvas
```

## Properties

### DisplayController

```csharp
public DisplayController DisplayController { get; }
```

_No description available._

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measurement override. Implement your size-to-content logic here. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `availableWidth` | `int` | Available size that parent can give to the child. May be MaxValue(when parent wants to measure to content). This is soft constraint. Child can return bigger size to indicate that it wants bigger space and hope that parent can throw in scrolling... |
| `availableHeight` | `int` |  |
| `desiredWidth` | `out int` |  |
| `desiredHeight` | `out int` |  |

### OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)

```csharp
protected internal override void OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)
```

OnChildrenChanged is called when the UIElementCollection of the UIElement is edited. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `added` | `UIElement` |  |
| `removed` | `UIElement` |  |
| `indexAffected` | `int` |  |

### RenderRecursive(DrawingContext dc)

```csharp
protected internal override void RenderRecursive(DrawingContext dc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

## Events

### PostRender

```csharp
public event PostRenderEventHandler PostRender
```

_No description available._

## Fields

### Instance

```csharp
public static WindowManager Instance
```

_No description available._
