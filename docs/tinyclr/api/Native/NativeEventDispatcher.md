---
title: "NativeEventDispatcher Class"
sidebar_label: "NativeEventDispatcher"
---

# NativeEventDispatcher Class

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

Marshals native ISR events to managed handlers. One dispatcher exists per well-known event name (e.g. `GHIElectronics.TinyCLR.NativeEventNames.Gpio.PinChanged`); retrieve the singleton with `GetDispatcher(string)` and subscribe to `OnInterrupt`. The first subscription enables the native interrupt; removing the last one disables it.

```csharp
public sealed class NativeEventDispatcher : IDisposable
```

## Methods

### EnableInterrupt()

```csharp
extern public void EnableInterrupt()
```

Manually arms the native interrupt source. Usually unnecessary — `OnInterrupt` handles it.

### DisableInterrupt()

```csharp
extern public void DisableInterrupt()
```

Manually disarms the native interrupt source.

### Dispose()

```csharp
public void Dispose()
```

Releases the native dispatcher and removes it from the per-name registry.

### GetDispatcher(string name)

```csharp
public static NativeEventDispatcher GetDispatcher(string name)
```

Returns the singleton dispatcher for a given event name, creating it on first request. All managed subscribers to the same name share one dispatcher.

**Returns** `NativeEventDispatcher`

## Events

### OnInterrupt

```csharp
public event NativeEventHandler OnInterrupt
```

Raised by the firmware when the underlying native event fires. The first subscription enables the native interrupt; removing the last unsubscribes and disables it. Multi-cast subscribers are dispatched on the same thread.
