---
title: "ISpiControllerProvider Interface"
sidebar_label: "ISpiControllerProvider"
---

# ISpiControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi.Provider`

Provider contract for an SPI controller.

```csharp
public interface ISpiControllerProvider : IDisposable
```

## Properties

### ChipSelectLineCount

```csharp
int ChipSelectLineCount { get; }
```

Number of hardware chip-select lines exposed by this controller.

### MinClockFrequency

```csharp
int MinClockFrequency { get; }
```

Minimum SCK frequency in Hz.

### MaxClockFrequency

```csharp
int MaxClockFrequency { get; }
```

Maximum SCK frequency in Hz.

### SupportedDataBitLengths

```csharp
int[] SupportedDataBitLengths { get; }
```

Supported frame widths in bits.

## Methods

### SetActiveSettings(SpiConnectionSettings connectionSettings)

```csharp
void SetActiveSettings(SpiConnectionSettings connectionSettings)
```

Applies the given settings before the next transfer.

| Parameter | Type | Description |
|---|---|---|
| `connectionSettings` | `SpiConnectionSettings` | Per-device configuration. |

### Write(byte[] writeBuffer, int xOffset, int yOffset, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)

```csharp
void Write(byte[] writeBuffer, int xOffset, int yOffset, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)
```

Writes a rectangular framebuffer region with optional pixel replication.

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

### WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, bool deselectAfter)

```csharp
void WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, bool deselectAfter)
```

Performs a full-duplex transfer.

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` | Bytes to transmit, or null for read-only. |
| `writeOffset` | `int` | Starting offset within `writeBuffer`. |
| `writeLength` | `int` | Number of bytes to transmit. |
| `readBuffer` | `byte[]` | Destination buffer for received bytes, or null to discard. |
| `readOffset` | `int` | Starting offset within `readBuffer`. |
| `readLength` | `int` | Number of bytes to receive. |
| `deselectAfter` | `bool` | If false, leaves chip-select asserted after the transfer (for sequential read-after-write). |
