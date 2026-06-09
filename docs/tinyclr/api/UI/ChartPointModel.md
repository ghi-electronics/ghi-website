---
title: "ChartPointModel Class"
sidebar_label: "ChartPointModel"
---

# ChartPointModel Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class ChartPointModel
```

## Properties

### Point

```csharp
public ChartPoint Point { get; set; }
```

_No description available._

### Value

```csharp
public double Value { get; set; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_
