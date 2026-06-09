---
title: "WatchdogControllerApiWrapper Class"
sidebar_label: "WatchdogControllerApiWrapper"
---

# WatchdogControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Watchdog`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Watchdog`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Watchdog.Provider`

Concrete `IWatchdogControllerProvider` backed by the native TinyCLR HAL.

```csharp
public sealed class WatchdogControllerApiWrapper : IWatchdogControllerProvider
```

## Constructors

### WatchdogControllerApiWrapper(NativeApi api)

```csharp
public WatchdogControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` |  |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### GetMaxTimeout

```csharp
public extern uint GetMaxTimeout { get; }
```

Largest legal timeout in milliseconds. _(inherited)_

### IsEnabled

```csharp
public extern bool IsEnabled { get; }
```

Fetches the value of the IsEnabled property _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### Enable(uint timeout)

```csharp
public extern void Enable(uint timeout)
```

Starts the watchdog with the given timeout in milliseconds. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `timeout` | `uint` |  |

### Disable()

```csharp
public extern void Disable()
```

Disables interrupts on the current core. Always pair with `Enable`. _(inherited)_

### Reset()

```csharp
public extern void Reset()
```

Sets the enumerator to its initial position, which is before the first element in the collection. _(inherited)_
