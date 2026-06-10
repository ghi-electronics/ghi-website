---
title: "ContentControl Class"
sidebar_label: "ContentControl"
---

# ContentControl Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Base class for controls that host a single child element.

```csharp
public abstract class ContentControl : Control
```

## Properties

### Child

```csharp
public UIElement Child { get; set; }
```

The single child element hosted by this control.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the child element.
