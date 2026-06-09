---
title: "WindowManager Class"
sidebar_label: "WindowManager"
---

# WindowManager Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

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

_No description available._

### OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)

```csharp
protected internal override void OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)
```

_No description available._

### RenderRecursive(DrawingContext dc)

```csharp
protected internal override void RenderRecursive(DrawingContext dc)
```

_No description available._

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
