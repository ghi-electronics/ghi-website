---
title: "TouchCapture Class"
sidebar_label: "TouchCapture"
---

# TouchCapture Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public static class TouchCapture
```

## Properties

### Captured

```csharp
public static UIElement Captured { get; }
```

_No description available._

## Methods

### Capture(UIElement element)

```csharp
public static bool Capture(UIElement element)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `element` | `UIElement` |  |

**Returns** `bool`

### Capture(UIElement element, CaptureMode mode)

```csharp
public static bool Capture(UIElement element, CaptureMode mode)
```

Captures one frame into the supplied buffer. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `element` | `UIElement` |  |
| `mode` | `CaptureMode` |  |

**Returns** `bool` — Number of bytes actually captured.
