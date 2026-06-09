---
title: "WatchdogController Class"
sidebar_label: "WatchdogController"
---

# WatchdogController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Watchdog` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Watchdog`

Independent watchdog timer. `Enable(uint)` with a timeout and call `Reset` periodically — if the timer ever expires without being reset, the chip reboots. Useful as a failsafe against firmware lockups.

```csharp
public class WatchdogController : IDisposable
```

## Properties

### Provider

```csharp
public IWatchdogControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### GetMaxTimeout

```csharp
public uint GetMaxTimeout { get; }
```

Largest legal value (in milliseconds) for the `Enable(uint)` timeout argument.

### IsEnabled

```csharp
public bool IsEnabled { get; }
```

True once `Enable(uint)` has been called.

## Methods

### GetDefault()

```csharp
public static WatchdogController GetDefault()
```

Returns the default watchdog for this device.

**Returns** `WatchdogController`

### FromName(string name)

```csharp
public static WatchdogController FromName(string name)
```

Returns a watchdog identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `WatchdogController`

### FromProvider(IWatchdogControllerProvider provider)

```csharp
public static WatchdogController FromProvider(IWatchdogControllerProvider provider)
```

Creates a controller from a custom `IWatchdogControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IWatchdogControllerProvider` |  |

**Returns** `WatchdogController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### Enable(uint timeout)

```csharp
public void Enable(uint timeout)
```

Starts the watchdog. From this point on, `Reset` must be called more often than `timeout` or the device will reboot. On many chips the watchdog cannot be disabled once enabled.

| Parameter | Type | Description |
|---|---|---|
| `timeout` | `uint` | Timeout in milliseconds (must be > 0 and ≤ `GetMaxTimeout`). |

### Disable()

```csharp
public void Disable()
```

Disables the watchdog (only supported on hardware that allows it).

### Reset()

```csharp
public void Reset()
```

Re-arms the watchdog. Must be called before the timeout elapses.
