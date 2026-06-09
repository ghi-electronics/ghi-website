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

| Parameter | Type | Description |
|---|---|---|
| `a` | `Application` |  |

## Methods

### RaiseButton(HardwareButton button, bool state, DateTime time)

```csharp
public void RaiseButton(HardwareButton button, bool state, DateTime time)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `button` | `HardwareButton` |  |
| `state` | `bool` |  |
| `time` | `DateTime` |  |

### RaiseTouch(int x, int y, TouchMessages which, DateTime time)

```csharp
public void RaiseTouch(int x, int y, TouchMessages which, DateTime time)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `which` | `TouchMessages` |  |
| `time` | `DateTime` |  |

### RaiseFocusNavigation(bool forward)

```csharp
public void RaiseFocusNavigation(bool forward)
```

Moves focus between tab stops (map hardware keys or UART keys to this for PC-style navigation).

| Parameter | Type | Description |
|---|---|---|
| `forward` | `bool` |  |
