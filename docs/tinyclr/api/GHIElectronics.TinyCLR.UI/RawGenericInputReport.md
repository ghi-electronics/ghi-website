---
title: "RawGenericInputReport Class"
sidebar_label: "RawGenericInputReport"
---

# RawGenericInputReport Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

The RawGenericInputReport class encapsulates the raw input provided from a keyboard.

```csharp
public class RawGenericInputReport : InputReport
```

## Constructors

### RawGenericInputReport(PresentationSource inputSource, GenericEvent genericEvent)

```csharp
public RawGenericInputReport(PresentationSource inputSource, GenericEvent genericEvent) : base(inputSource, genericEvent.Time)
```

Constructs an instance of the RawKeyboardInputReport class.

| Parameter | Type | Description |
|---|---|---|
| `inputSource` | `PresentationSource` | source of the input |
| `genericEvent` | `GenericEvent` |  |

### RawGenericInputReport(PresentationSource inputSource, GenericEvent genericEvent, UIElement destTarget)

```csharp
public RawGenericInputReport(PresentationSource inputSource, GenericEvent genericEvent, UIElement destTarget) : base(inputSource, genericEvent.Time)
```

Constructs an instance of the RawGenericInputReport class targeting a specific element.

## Fields

### Target

```csharp
public readonly UIElement Target
```

Read-only access to the element this report is directed at, or null.

### InternalEvent

```csharp
public readonly GenericEvent InternalEvent
```

Read-only access to the underlying generic event.
