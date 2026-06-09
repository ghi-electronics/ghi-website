---
title: "IWatchdogControllerProvider Interface"
sidebar_label: "IWatchdogControllerProvider"
---

# IWatchdogControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Watchdog`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Watchdog`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Watchdog.Provider`

Provider contract for a watchdog controller.

```csharp
public interface IWatchdogControllerProvider : IDisposable
```

## Properties

### GetMaxTimeout

```csharp
uint GetMaxTimeout { get; }
```

Largest legal timeout in milliseconds.

### IsEnabled

```csharp
bool IsEnabled { get; }
```

True once the watchdog is running.

## Methods

### Enable(uint timeout)

```csharp
void Enable(uint timeout)
```

Starts the watchdog with the given timeout in milliseconds.

| Parameter | Type | Description |
|---|---|---|
| `timeout` | `uint` |  |

### Disable()

```csharp
void Disable()
```

Disables the watchdog where the hardware permits it.

### Reset()

```csharp
void Reset()
```

Re-arms the watchdog.
