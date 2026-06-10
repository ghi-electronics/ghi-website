---
title: "Panel Class"
sidebar_label: "Panel"
---

# Panel Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Base class for controls that arrange a collection of child elements.

```csharp
public class Panel : UIElement
```

## Properties

### Children

```csharp
public UIElementCollection Children { get; }
```

The collection of child elements contained in this panel.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the panel as the bounding size of all its children.
