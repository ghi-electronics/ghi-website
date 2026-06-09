---
title: "SpiControllerApiWrapper Class"
sidebar_label: "SpiControllerApiWrapper"
---

# SpiControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi.Provider`

Concrete `ISpiControllerProvider` backed by the native TinyCLR SPI HAL.

```csharp
public sealed class SpiControllerApiWrapper : ISpiControllerProvider
```

## Constructors

### SpiControllerApiWrapper(NativeApi api)

```csharp
public SpiControllerApiWrapper(NativeApi api)
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

### ChipSelectLineCount

```csharp
public extern int ChipSelectLineCount { get; }
```

Number of hardware chip-select lines exposed by this controller. _(inherited)_

### MinClockFrequency

```csharp
public extern int MinClockFrequency { get; }
```

Minimum SCK frequency in Hz. _(inherited)_

### MaxClockFrequency

```csharp
public extern int MaxClockFrequency { get; }
```

Maximum SCK frequency in Hz. _(inherited)_

### SupportedDataBitLengths

```csharp
public extern int[] SupportedDataBitLengths { get; }
```

Supported frame widths in bits. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### SetActiveSettings(SpiConnectionSettings connectionSettings)

```csharp
public extern void SetActiveSettings(SpiConnectionSettings connectionSettings)
```

Applies a complete set of serial settings (baud, framing, handshake, polarity). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `connectionSettings` | `SpiConnectionSettings` |  |

### WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, bool deselectAfter)

```csharp
public extern void WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, bool deselectAfter)
```

Performs a full-duplex transfer. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` | Bytes to transmit, or null for read-only. |
| `writeOffset` | `int` | Starting offset within `writeBuffer`. |
| `writeLength` | `int` | Number of bytes to transmit. |
| `readBuffer` | `byte[]` | Destination buffer for received bytes, or null to discard. |
| `readOffset` | `int` | Starting offset within `readBuffer`. |
| `readLength` | `int` | Number of bytes to receive. |
| `deselectAfter` | `bool` | If false, leaves chip-select asserted after the transfer (for sequential read-after-write). |

### Write(byte[] writeBuffer, int xOffset, int yOffset, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)

```csharp
public extern void Write(byte[] writeBuffer, int xOffset, int yOffset, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)
```

Writes a rectangular framebuffer region with optional pixel replication. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` |  |
| `xOffset` | `int` |  |
| `yOffset` | `int` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `originalWidth` | `int` |  |
| `columnMultiplier` | `int` |  |
| `rowMultiplier` | `int` |  |
