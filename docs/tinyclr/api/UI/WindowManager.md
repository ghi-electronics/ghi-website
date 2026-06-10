---
title: "WindowManager Class"
sidebar_label: "WindowManager"
---

# WindowManager Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

The root container that hosts all windows and drives rendering for a display.

```csharp
public class WindowManager : Controls.Canvas
```

## Properties

### DisplayController

```csharp
public DisplayController DisplayController { get; }
```

Gets the display controller this window manager renders to.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the window manager to the size of the active display configuration.

### OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)

```csharp
protected internal override void OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)
```

Updates focus and touch capture when a window is added to or removed from the manager.

### RenderRecursive(DrawingContext dc)

```csharp
protected internal override void RenderRecursive(DrawingContext dc)
```

Renders the window tree and then raises the `PostRender` event.

## Events

### PostRender

```csharp
public event PostRenderEventHandler PostRender
```

Occurs after the window tree has been rendered, allowing custom overlay drawing.

## Fields

### Instance

```csharp
public static WindowManager Instance
```

The singleton window manager instance for the application.
