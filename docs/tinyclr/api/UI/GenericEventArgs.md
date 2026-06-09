---
title: "GenericEventArgs Class"
sidebar_label: "GenericEventArgs"
---

# GenericEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

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

## Fields

### InternalEvent

```csharp
public readonly GenericEvent InternalEvent
```

_No description available._
