---
title: "ContentControl Class"
sidebar_label: "ContentControl"
---

# ContentControl Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public abstract class ContentControl : Control
```

## Properties

### Child

```csharp
public UIElement Child { get; set; }
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
