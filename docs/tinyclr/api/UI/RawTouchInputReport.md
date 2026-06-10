---
title: "RawTouchInputReport Class"
sidebar_label: "RawTouchInputReport"
---

# RawTouchInputReport Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

The RawTouchInputReport class encapsulates the raw input provided from a multitouch source.

```csharp
public class RawTouchInputReport : InputReport
```

## Constructors

### RawTouchInputReport(PresentationSource inputSource, DateTime timestamp, byte eventMessage, TouchInput[] touches)

```csharp
public RawTouchInputReport(PresentationSource inputSource, DateTime timestamp, byte eventMessage, TouchInput[] touches) : base(inputSource, timestamp)
```

Constructs an instance of the RawKeyboardInputReport class.

| Parameter | Type | Description |
|---|---|---|
| `inputSource` | `PresentationSource` | source of the input |
| `timestamp` | `DateTime` | The time when the input occured. |
| `eventMessage` | `byte` |  |
| `touches` | `TouchInput[]` |  |

### RawTouchInputReport(PresentationSource inputSource, DateTime timestamp, byte eventMessage, TouchInput[] touches, UIElement destTarget)

```csharp
public RawTouchInputReport(PresentationSource inputSource, DateTime timestamp, byte eventMessage, TouchInput[] touches, UIElement destTarget) : base(inputSource, timestamp)
```

Constructs an instance of the RawTouchInputReport class targeting a specific element.

## Fields

### Target

```csharp
public readonly UIElement Target
```

Read-only access to the element this report is directed at, or null.

### EventMessage

```csharp
public readonly byte EventMessage
```

Read-only access to the touch message code.

### Touches

```csharp
public readonly TouchInput[] Touches
```

Read-only access to the touch points reported.
