---
title: "AdcControllerApiWrapper Class"
sidebar_label: "AdcControllerApiWrapper"
---

# AdcControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Adc`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Adc`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Adc.Provider`

Concrete `IAdcControllerProvider` backed by the native TinyCLR ADC HAL. Constructed internally by `AdcController`; you don't normally need to use this type directly.

```csharp
public sealed class AdcControllerApiWrapper : IAdcControllerProvider
```

## Constructors

### AdcControllerApiWrapper(NativeApi api)

```csharp
public AdcControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` | The native ADC API to bind to. |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### ChannelCount

```csharp
public extern int ChannelCount { get; }
```

Total number of channels exposed by this controller. _(inherited)_

### ResolutionInBits

```csharp
public extern int ResolutionInBits { get; }
```

Sample width in bits. _(inherited)_

### MinValue

```csharp
public extern int MinValue { get; }
```

Smallest raw value accepted by `Write(int, int)`. _(inherited)_

### MaxValue

```csharp
public extern int MaxValue { get; }
```

Largest raw value accepted by `Write(int, int)`. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### IsChannelModeSupported(AdcChannelMode mode)

```csharp
public extern bool IsChannelModeSupported(AdcChannelMode mode)
```

Tests whether the controller supports the given channel mode. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `mode` | `AdcChannelMode` | The mode to test. |

**Returns** `bool`

### GetChannelMode()

```csharp
public extern AdcChannelMode GetChannelMode()
```

Returns the controller's current channel mode. _(inherited)_

**Returns** `AdcChannelMode`

### SetChannelMode(AdcChannelMode value)

```csharp
public extern void SetChannelMode(AdcChannelMode value)
```

Sets the controller's channel mode. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `AdcChannelMode` | New channel mode. |

### OpenChannel(int channel)

```csharp
public extern void OpenChannel(int channel)
```

Acquires exclusive access to the specified channel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### CloseChannel(int channel)

```csharp
public extern void CloseChannel(int channel)
```

Releases a previously opened channel. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### Read(int channel, TimeSpan samplingTime)

```csharp
public extern int Read(int channel, TimeSpan samplingTime)
```

Waits for the pin to reach `waitForState`, then captures inter-edge intervals. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` |  |
| `samplingTime` | `TimeSpan` |  |

**Returns** `int` — Number of intervals captured.
