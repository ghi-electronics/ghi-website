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

True once the watchdog is running. _(inherited)_

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

### Disable()

```csharp
public extern void Disable()
```

Disables the watchdog where the hardware permits it. _(inherited)_

### Reset()

```csharp
public extern void Reset()
```

Re-arms the watchdog. _(inherited)_
