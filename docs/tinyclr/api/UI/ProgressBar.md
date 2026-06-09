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

The new direction of the hat switch. _(inherited)_

### MaxValue

```csharp
public int MaxValue { get; set; }
```

Largest raw value accepted by `Write(int, int)`. _(inherited)_

### Value

```csharp
public int Value { get; set; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_

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

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |
