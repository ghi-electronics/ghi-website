---
title: "GenericEventArgs Class"
sidebar_label: "GenericEventArgs"
---

# GenericEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Contains information about a generic input event.

```csharp
public class GenericEventArgs : InputEventArgs
```

## Constructors

### GenericEventArgs(InputDevice inputDevice, GenericEvent genericEvent)

```csharp
public GenericEventArgs(InputDevice inputDevice, GenericEvent genericEvent) : base(inputDevice, genericEvent.Time)
```

Constructs an instance of the GenericEventArgs class.

## Fields

### InternalEvent

```csharp
public readonly GenericEvent InternalEvent
```

Read-only access to the underlying generic event.
