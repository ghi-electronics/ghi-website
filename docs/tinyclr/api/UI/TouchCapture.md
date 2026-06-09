---
title: "TouchCapture Class"
sidebar_label: "TouchCapture"
---

# TouchCapture Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

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

**Returns** `bool`

### Capture(UIElement element, CaptureMode mode)

```csharp
public static bool Capture(UIElement element, CaptureMode mode)
```

Captures one frame into the supplied buffer. _(inherited)_

**Returns** `bool` — Number of bytes actually captured.
