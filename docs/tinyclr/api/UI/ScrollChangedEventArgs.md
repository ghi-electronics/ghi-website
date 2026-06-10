---
title: "ScrollChangedEventArgs Class"
sidebar_label: "ScrollChangedEventArgs"
---

# ScrollChangedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Provides data for the scroll-changed event, describing the new offsets and how far they moved.

```csharp
public class ScrollChangedEventArgs : EventArgs
```

## Constructors

### ScrollChangedEventArgs(int offsetX, int offsetY, int offsetChangeX, int offsetChangeY)

```csharp
public ScrollChangedEventArgs(int offsetX, int offsetY, int offsetChangeX, int offsetChangeY)
```

Initializes a new instance of the `ScrollChangedEventArgs` class.

## Fields

### HorizontalChange

```csharp
public readonly int HorizontalChange
```

The amount the horizontal offset changed since the last event.

### HorizontalOffset

```csharp
public readonly int HorizontalOffset
```

The current horizontal scroll offset.

### VerticalChange

```csharp
public readonly int VerticalChange
```

The amount the vertical offset changed since the last event.

### VerticalOffset

```csharp
public readonly int VerticalOffset
```

The current vertical scroll offset.
