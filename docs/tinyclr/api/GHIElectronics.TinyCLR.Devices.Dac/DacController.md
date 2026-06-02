---
title: "DacController Class"
sidebar_label: "DacController"
---

# DacController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Dac` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Dac`

Represents a DAC peripheral. Open a channel via `OpenChannel(int)` to drive analog output; use `MinValue`/`MaxValue` to know the raw-code range for the configured resolution.

```csharp
public class DacController : IDisposable
```

## Properties

### Provider

```csharp
public IDacControllerProvider Provider { get; }
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

Sample width in bits.

### MinValue

```csharp
public int MinValue { get; }
```

Smallest raw value accepted by `DacChannel.WriteValue(int)`.

### MaxValue

```csharp
public int MaxValue { get; }
```

Largest raw value accepted by `DacChannel.WriteValue(int)`.

## Methods

### GetDefault()

```csharp
public static DacController GetDefault()
```

Returns the default DAC controller for this device.

**Returns** `DacController`

### FromName(string name)

```csharp
public static DacController FromName(string name)
```

Returns a DAC controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Native API name. |

**Returns** `DacController`

### FromProvider(IDacControllerProvider provider)

```csharp
public static DacController FromProvider(IDacControllerProvider provider)
```

Creates a controller from a custom `IDacControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IDacControllerProvider` | Provider implementing the channel operations. |

**Returns** `DacController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### OpenChannel(int channelNumber)

```csharp
public DacChannel OpenChannel(int channelNumber)
```

Opens a channel for output.

| Parameter | Type | Description |
|---|---|---|
| `channelNumber` | `int` | Controller-relative channel index. |

**Returns** `DacChannel` — A `DacChannel`; dispose it to release the channel.
