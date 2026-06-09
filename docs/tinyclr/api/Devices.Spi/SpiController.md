---
title: "SpiController Class"
sidebar_label: "SpiController"
---

# SpiController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi`

Represents an SPI bus controller. Obtain one via `GetDefault` or `FromName(string)`, then create a `SpiDevice` for each chip on the bus via `GetDevice(SpiConnectionSettings)`.

```csharp
public class SpiController : IDisposable
```

## Properties

### Provider

```csharp
public ISpiControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### ChipSelectLineCount

```csharp
public int ChipSelectLineCount { get; }
```

Number of hardware chip-select lines exposed by this controller.

### MinClockFrequency

```csharp
public int MinClockFrequency { get; }
```

Minimum SCK frequency in Hz the controller can generate.

### MaxClockFrequency

```csharp
public int MaxClockFrequency { get; }
```

Maximum SCK frequency in Hz the controller can generate.

### SupportedDataBitLengths

```csharp
public int[] SupportedDataBitLengths { get; }
```

Data-frame widths in bits that this controller supports.

## Methods

### GetDefault()

```csharp
public static SpiController GetDefault()
```

Returns the default SPI controller for this device.

**Returns** `SpiController`

### FromName(string name)

```csharp
public static SpiController FromName(string name)
```

Returns an SPI controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Native API name. |

**Returns** `SpiController`

### FromProvider(ISpiControllerProvider provider)

```csharp
public static SpiController FromProvider(ISpiControllerProvider provider)
```

Creates a controller from a custom `ISpiControllerProvider` (including the software bit-bang provider).

| Parameter | Type | Description |
|---|---|---|
| `provider` | `ISpiControllerProvider` | Provider implementing the bus operations. |

**Returns** `SpiController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### GetDevice(SpiConnectionSettings connectionSettings)

```csharp
public SpiDevice GetDevice(SpiConnectionSettings connectionSettings)
```

Creates a `SpiDevice` bound to this controller using the given settings.

| Parameter | Type | Description |
|---|---|---|
| `connectionSettings` | `SpiConnectionSettings` | Per-device clock, mode, and chip-select configuration. |

**Returns** `SpiDevice`
