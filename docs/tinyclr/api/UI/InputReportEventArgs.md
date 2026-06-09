---
title: "InputReportEventArgs Class"
sidebar_label: "InputReportEventArgs"
---

# InputReportEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

The InputReportEventArgs class contains information about an input report that is being processed.

```csharp
public class InputReportEventArgs : InputEventArgs
```

## Constructors

### InputReportEventArgs(InputDevice inputDevice, InputReport report)

```csharp
public InputReportEventArgs(InputDevice inputDevice, InputReport report) : base(inputDevice, ((report != null) ? report.Timestamp : DateTime.MinValue))
```

Initializes a new instance of the InputReportEventArgs class.

| Parameter | Type | Description |
|---|---|---|
| `inputDevice` | `InputDevice` | The input device to associate this input with. |
| `report` | `InputReport` | The input report being processed. |

## Fields

### Report

```csharp
public readonly InputReport Report
```

Read-only access to the input report being processed.
