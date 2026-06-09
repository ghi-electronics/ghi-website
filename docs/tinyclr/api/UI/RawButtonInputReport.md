---
title: "RawButtonInputReport Class"
sidebar_label: "RawButtonInputReport"
---

# RawButtonInputReport Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The RawButtonInputReport class encapsulates the raw input provided from a keyboard.

```csharp
public class RawButtonInputReport : InputReport
```

## Constructors

### RawButtonInputReport(PresentationSource inputSource, DateTime timestamp, HardwareButton button, RawButtonActions actions)

```csharp
public RawButtonInputReport(PresentationSource inputSource, DateTime timestamp, HardwareButton button, RawButtonActions actions) : base(inputSource, timestamp)
```

Constructs an instance of the RawKeyboardInputReport class.

| Parameter | Type | Description |
|---|---|---|
| `inputSource` | `PresentationSource` | source of the input |
| `timestamp` | `DateTime` | The time when the input occured. |
| `button` | `HardwareButton` |  |
| `actions` | `RawButtonActions` |  |

## Fields

### Button

```csharp
public readonly HardwareButton Button
```

Read-only access to the button reported.

### Actions

```csharp
public readonly RawButtonActions Actions
```

Read-only access to the action reported.
