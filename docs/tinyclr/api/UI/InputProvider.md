---
title: "InputProvider Class"
sidebar_label: "InputProvider"
---

# InputProvider Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

_No description available._

```csharp
public sealed class InputProvider
```

## Constructors

### InputProvider(Application a)

```csharp
public InputProvider(Application a)
```

_No description available._

## Methods

### RaiseButton(HardwareButton button, bool state, DateTime time)

```csharp
public void RaiseButton(HardwareButton button, bool state, DateTime time)
```

_No description available._

### RaiseTouch(int x, int y, TouchMessages which, DateTime time)

```csharp
public void RaiseTouch(int x, int y, TouchMessages which, DateTime time)
```

_No description available._

### RaiseFocusNavigation(bool forward)

```csharp
public void RaiseFocusNavigation(bool forward)
```

Moves focus between tab stops (map hardware keys or UART keys to this for PC-style navigation).
