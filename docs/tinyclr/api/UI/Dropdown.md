---
title: "Dropdown Class"
sidebar_label: "Dropdown"
---

# Dropdown Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class Dropdown : ListBox, IDisposable
```

## Constructors

### Dropdown()

```csharp
public Dropdown() : base()
```

_No description available._

## Properties

### Alpha

```csharp
public ushort Alpha { get; set; }
```

_No description available._

### RadiusBorder

```csharp
public int RadiusBorder { get; set; }
```

Corner radius in pixels for the Scale9Image-rendered bar. _(inherited)_

### MaxOpenHeight

```csharp
public int MaxOpenHeight { get; set; }
```

Optional cap on the expanded list height. When set to a positive value the open dropdown is clamped to this height and overflow scrolls through the inherited ScrollViewer. Default 0 = no clamp (legacy behavior).

### Options

```csharp
public ArrayList Options { get; set; }
```

_No description available._

## Methods

### OnButtonDown(ButtonEventArgs e)

```csharp
protected override void OnButtonDown(ButtonEventArgs e)
```

Hardware button support: `HardwareButton.Select` toggles the dropdown open/closed (parity with touch). `HardwareButton.Back` closes an open dropdown. Up/Down navigation comes free from `ListBox`.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

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
