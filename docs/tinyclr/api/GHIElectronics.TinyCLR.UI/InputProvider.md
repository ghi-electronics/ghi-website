---
title: "InputProvider Class"
sidebar_label: "InputProvider"
---

# InputProvider Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Feeds button, touch and focus-navigation input into the input manager.

```csharp
public sealed class InputProvider
```

## Constructors

### InputProvider(Application a)

```csharp
public InputProvider(Application a)
```

Constructs an instance of the InputProvider class for the given application.

## Methods

### RaiseButton(HardwareButton button, bool state, DateTime time)

```csharp
public void RaiseButton(HardwareButton button, bool state, DateTime time)
```

Reports a button press or release to the input manager.

### RaiseTouch(int x, int y, TouchMessages which, DateTime time)

```csharp
public void RaiseTouch(int x, int y, TouchMessages which, DateTime time)
```

Reports a touch event at the given position to the input manager.

### RaiseFocusNavigation(bool forward)

```csharp
public void RaiseFocusNavigation(bool forward)
```

Moves focus between tab stops (map hardware keys or UART keys to this for PC-style navigation).
