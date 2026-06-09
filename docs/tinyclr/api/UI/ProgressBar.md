---
title: "ProgressBar Class"
sidebar_label: "ProgressBar"
---

# ProgressBar Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class ProgressBar : Image, IDisposable
```

## Constructors

### ProgressBar()

```csharp
public ProgressBar() : base()
```

_No description available._

## Properties

### Direction

```csharp
public Direction Direction { get; set; }
```

_No description available._

### MaxValue

```csharp
public int MaxValue { get; set; }
```

_No description available._

### Value

```csharp
public int Value { get; set; }
```

_No description available._

### Alpha

```csharp
public ushort Alpha { get; set; }
```

_No description available._

### RadiusBorder

```csharp
public int RadiusBorder { get; set; }
```

Corner radius in pixels for the Scale9Image-rendered bar.

### Border

```csharp
public int Border { get; set; }
```

Legacy alias for `RadiusBorder`. Will be removed.

## Methods

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._
