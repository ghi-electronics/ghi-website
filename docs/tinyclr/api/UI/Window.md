---
title: "Window Class"
sidebar_label: "Window"
---

# Window Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class Window : ContentControl
```

## Properties

### Top

```csharp
public int Top { get; set; }
```

Position for Top of the host window

### Left

```csharp
public int Left { get; set; }
```

_No description available._

### Topmost

```csharp
public bool Topmost { get; set; }
```

Determines if this window is always on the top.

## Methods

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

ArrangeOverride allows for the customization of the positioning of children.
