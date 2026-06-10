---
title: "AdcController Class"
sidebar_label: "AdcController"
---

# AdcController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Adc`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Adc`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Adc`

Represents an ADC peripheral. Open a channel via `OpenChannel(int)` to take samples; use `MinValue`/`MaxValue` to know the raw-code range for the configured resolution.

```csharp
public class AdcController : IDisposable
```

## Properties

### Provider

```csharp
public IAdcControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### ChannelCount

```csharp
public int ChannelCount { get; }
```

Number of channels exposed by this controller.

### ResolutionInBits

```csharp
public int ResolutionInBits { get; }
```

Sample width in bits. Determines the spread between `MinValue` and `MaxValue`.

### MinValue

```csharp
public int MinValue { get; }
```

Smallest raw value `AdcChannel.ReadValue` can return.

### MaxValue

```csharp
public int MaxValue { get; }
```

Largest raw value `AdcChannel.ReadValue` can return.

### ChannelMode

```csharp
public AdcChannelMode ChannelMode { get; set; }
```

Controller-wide channel mode (single-ended or differential). Not every mode is supported on every controller — check with `IsChannelModeSupported(AdcChannelMode)`.

## Methods

### GetDefault()

```csharp
public static AdcController GetDefault()
```

Returns the default ADC controller for this device.

**Returns** `AdcController`

### FromName(string name)

```csharp
public static AdcController FromName(string name)
```

Returns an ADC controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Native API name. |

**Returns** `AdcController`

### FromProvider(IAdcControllerProvider provider)

```csharp
public static AdcController FromProvider(IAdcControllerProvider provider)
```

Creates a controller from a custom `IAdcControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IAdcControllerProvider` | Provider implementing the channel operations. |

**Returns** `AdcController`

### IsChannelModeSupported(AdcChannelMode mode)

```csharp
public bool IsChannelModeSupported(AdcChannelMode mode)
```

Tests whether the controller supports a given channel mode.

| Parameter | Type | Description |
|---|---|---|
| `mode` | `AdcChannelMode` | The mode to test. |

**Returns** `bool`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### OpenChannel(int channelNumber)

```csharp
public AdcChannel OpenChannel(int channelNumber)
```

Opens a channel for sampling.

| Parameter | Type | Description |
|---|---|---|
| `channelNumber` | `int` | Controller-relative channel index. |

**Returns** `AdcChannel` — An `AdcChannel`; dispose it to release the channel.
