---
title: "TouchGestureEventArgs Class"
sidebar_label: "TouchGestureEventArgs"
---

# TouchGestureEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Contains information about a touch gesture event.

```csharp
public class TouchGestureEventArgs : EventArgs
```

## Properties

### Angle

```csharp
public double Angle { get; }
```

The gesture angle in degrees, derived from the arguments.

## Fields

### Timestamp

```csharp
public readonly DateTime Timestamp
```

The time when the gesture occurred.

### Gesture

```csharp
public TouchGesture Gesture
```

The gesture that was recognized.

### X

```csharp
public int X
```

The x center of the gesture (or start point for single touch).

### Y

```csharp
public int Y
```

The y coordinate of the gesture location.

### Arguments

```csharp
public ushort Arguments
```

Gesture-specific value (e.g. zoom distance or rotation angle).
