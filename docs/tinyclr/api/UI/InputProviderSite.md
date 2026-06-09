---
title: "InputProviderSite Class"
sidebar_label: "InputProviderSite"
---

# InputProviderSite Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

The object which input providers use to report input to the input manager.

```csharp
public class InputProviderSite : IDisposable
```

## Properties

### InputManager

```csharp
public InputManager InputManager { get; }
```

Returns the input manager that this site is attached to.

### IsDisposed

```csharp
public bool IsDisposed { get; }
```

Returns true if we are disposed.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Unregisters this input provider.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### ReportInput(InputDevice device, InputReport inputReport)

```csharp
public bool ReportInput(InputDevice device, InputReport inputReport)
```

_No description available._

**Returns** `bool`
