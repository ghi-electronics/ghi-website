---
title: "TouchGesture Enum"
sidebar_label: "TouchGesture"
---

# TouchGesture Enum

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Identifies a touch gesture.

```csharp
public enum TouchGesture : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `NoGesture` | `0` | No gesture, or an unknown gesture. |
| `Begin` | `1` | The beginning of a gesture sequence. |
| `End` | `2` | The end of a gesture sequence. |
| `Right` | `3` | A swipe to the right. |
| `UpRight` | `4` | A swipe up and to the right. |
| `Up` | `5` | A swipe upward. |
| `UpLeft` | `6` | A swipe up and to the left. |
| `Left` | `7` | A swipe to the left. |
| `DownLeft` | `8` | A swipe down and to the left. |
| `Down` | `9` | A swipe downward. |
| `DownRight` | `10` | A swipe down and to the right. |
| `Tap` | `11` | A tap. |
| `DoubleTap` | `12` | A double tap. |
| `Zoom` | `114` | A pinch (zoom) gesture. |
| `Pan` | `115` | A pan (scroll) gesture. |
| `Rotate` | `116` | A rotate gesture. |
| `TwoFingerTap` | `117` | A two-finger tap. |
| `Rollover` | `118` | A press-and-tap (rollover) gesture. |
| `UserDefined` | `200` | A user-defined gesture. |
