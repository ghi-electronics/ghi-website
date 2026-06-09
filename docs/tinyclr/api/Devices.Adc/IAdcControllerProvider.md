---
title: "IAdcControllerProvider Interface"
sidebar_label: "IAdcControllerProvider"
---

# IAdcControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Adc.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Adc`

Provider contract for an ADC controller. Most users call `AdcController` / `AdcChannel` directly; implement this interface only when supplying a custom or virtual ADC.

```csharp
public interface IAdcControllerProvider : IDisposable
```

## Properties

### ChannelCount

```csharp
int ChannelCount { get; }
```

Total number of channels exposed by this controller.

### ResolutionInBits

```csharp
int ResolutionInBits { get; }
```

Sample width in bits.

### MinValue

```csharp
int MinValue { get; }
```

Smallest raw value `Read(int, TimeSpan)` can return.

### MaxValue

```csharp
int MaxValue { get; }
```

Largest raw value `Read(int, TimeSpan)` can return.

## Methods

### IsChannelModeSupported(AdcChannelMode mode)

```csharp
bool IsChannelModeSupported(AdcChannelMode mode)
```

Tests whether the controller supports the given channel mode.

| Parameter | Type | Description |
|---|---|---|
| `mode` | `AdcChannelMode` | The mode to test. |

**Returns** `bool`

### GetChannelMode()

```csharp
AdcChannelMode GetChannelMode()
```

Returns the controller's current channel mode.

**Returns** `AdcChannelMode`

### SetChannelMode(AdcChannelMode value)

```csharp
void SetChannelMode(AdcChannelMode value)
```

Sets the controller's channel mode.

| Parameter | Type | Description |
|---|---|---|
| `value` | `AdcChannelMode` | New channel mode. |

### OpenChannel(int channel)

```csharp
void OpenChannel(int channel)
```

Acquires exclusive access to the specified channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### CloseChannel(int channel)

```csharp
void CloseChannel(int channel)
```

Releases a previously opened channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### Read(int channel, TimeSpan samplingTime)

```csharp
int Read(int channel, TimeSpan samplingTime)
```

Performs a conversion on the channel and returns the raw code.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |
| `samplingTime` | `TimeSpan` | Requested sample-and-hold time. |

**Returns** `int`
