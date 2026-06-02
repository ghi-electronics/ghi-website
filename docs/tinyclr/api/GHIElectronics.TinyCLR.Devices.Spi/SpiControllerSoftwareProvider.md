---
title: "SpiControllerSoftwareProvider Class"
sidebar_label: "SpiControllerSoftwareProvider"
---

# SpiControllerSoftwareProvider Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`

Software (bit-bang) SPI provider. Useful when no hardware SPI peripheral is available on the desired pins, or to escape pin-mux conflicts. Significantly slower than the native hardware provider.

```csharp
public sealed class SpiControllerSoftwareProvider : ISpiControllerProvider
```

## Constructors

### SpiControllerSoftwareProvider(int mosiPinNumber, int misoPinNumber, int sckPinNumber)

```csharp
public SpiControllerSoftwareProvider(int mosiPinNumber, int misoPinNumber, int sckPinNumber) : this(GpioController.GetDefault(), mosiPinNumber, misoPinNumber, sckPinNumber)
```

Builds a software SPI provider on the default `GpioController`.

| Parameter | Type | Description |
|---|---|---|
| `mosiPinNumber` | `int` | Pin used as MOSI (controller output). |
| `misoPinNumber` | `int` | Pin used as MISO (controller input). |
| `sckPinNumber` | `int` | Pin used as SCK (clock). |

### SpiControllerSoftwareProvider(GpioController gpioController, int mosiPinNumber, int misoPinNumber, int sckPinNumber)

```csharp
public SpiControllerSoftwareProvider(GpioController gpioController, int mosiPinNumber, int misoPinNumber, int sckPinNumber)
```

Builds a software SPI provider on the supplied `GpioController`.

| Parameter | Type | Description |
|---|---|---|
| `gpioController` | `GpioController` | The GPIO controller that owns the bus pins. |
| `mosiPinNumber` | `int` | Pin used as MOSI. |
| `misoPinNumber` | `int` | Pin used as MISO. |
| `sckPinNumber` | `int` | Pin used as SCK. |

## Properties

### ChipSelectLineCount

```csharp
public int ChipSelectLineCount { get; }
```

Number of hardware chip-select lines exposed by this controller. _(inherited)_

### MinClockFrequency

```csharp
public int MinClockFrequency { get; }
```

Minimum SCK frequency in Hz. _(inherited)_

### MaxClockFrequency

```csharp
public int MaxClockFrequency { get; }
```

Maximum SCK frequency in Hz. _(inherited)_

### SupportedDataBitLengths

```csharp
public int[] SupportedDataBitLengths { get; }
```

Supported frame widths in bits. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the GPIO pins held for MOSI/MISO/SCK/CS.

### SetActiveSettings(SpiConnectionSettings connectionSettings)

```csharp
public void SetActiveSettings(SpiConnectionSettings connectionSettings)
```

Applies a complete set of serial settings (baud, framing, handshake, polarity). _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `connectionSettings` | `SpiConnectionSettings` |  |

### WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, bool deselectAfter)

```csharp
public void WriteRead(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength, bool deselectAfter)
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
public void Write(byte[] writeBuffer, int xOffset, int yOffset, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)
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
