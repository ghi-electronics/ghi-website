---
title: "GenericEventArgs Class"
sidebar_label: "GenericEventArgs"
---

# GenericEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class GenericEventArgs : InputEventArgs
```

## Constructors

### GenericEventArgs(InputDevice inputDevice, GenericEvent genericEvent)

```csharp
public GenericEventArgs(InputDevice inputDevice, GenericEvent genericEvent) : base(inputDevice, genericEvent.Time)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `inputDevice` | `InputDevice` |  |
| `genericEvent` | `GenericEvent` |  |

## Fields

### InternalEvent

```csharp
public readonly GenericEvent InternalEvent
```

_No description available._
