---
title: "SpiDevice Class"
sidebar_label: "SpiDevice"
---

# SpiDevice Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi`

Represents a single chip on an SPI bus. Each transfer is preceded by a re-apply of `ConnectionSettings`, so multiple devices on the same controller can coexist without manual reconfiguration between calls.

```csharp
public class SpiDevice : IDisposable
```

## Properties

### ConnectionSettings

```csharp
public SpiConnectionSettings ConnectionSettings { get; }
```

The per-device bus settings (clock, mode, chip select, etc.).

### Controller

```csharp
public SpiController Controller { get; }
```

The `SpiController` this device transacts over.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases device-level resources. Does not close the underlying controller.

### Read(byte[] buffer)

```csharp
public void Read(byte[] buffer)
```

Reads `buffer`.Length bytes; transmits zeros while reading.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Destination buffer. |

### Write(byte[] buffer)

```csharp
public void Write(byte[] buffer)
```

Writes `buffer`.Length bytes; discards received data.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Source buffer. |

### Write(byte[] buffer, int xOffset, int yOffset, int width, int height, int originalWidth)

```csharp
public void Write(byte[] buffer, int xOffset, int yOffset, int width, int height, int originalWidth)
```

Writes a rectangular sub-region of a larger framebuffer. Display driver helper.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Source framebuffer (RGB565 pairs of bytes). |
| `xOffset` | `int` | Left edge of the source rectangle within the framebuffer. |
| `yOffset` | `int` | Top edge of the source rectangle within the framebuffer. |
| `width` | `int` | Width of the source rectangle in pixels. |
| `height` | `int` | Height of the source rectangle in pixels. |
| `originalWidth` | `int` | Pixel-width of the full framebuffer. |

### TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)

```csharp
public void TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)
```

Writes and reads simultaneously; both buffers must be the same length.

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` | Bytes to transmit. |
| `readBuffer` | `byte[]` | Receives the bytes shifted in. |

### TransferSequential(byte[] writeBuffer, byte[] readBuffer)

```csharp
public void TransferSequential(byte[] writeBuffer, byte[] readBuffer)
```

Writes all of `writeBuffer`, then reads all of `readBuffer` in a single CS-low transaction.

### Read(byte[] buffer, int offset, int length)

```csharp
public void Read(byte[] buffer, int offset, int length)
```

Reads `length` bytes into `buffer` starting at `offset`.

### Write(byte[] buffer, int offset, int length)

```csharp
public void Write(byte[] buffer, int offset, int length)
```

Writes `length` bytes from `buffer` starting at `offset`.

### TransferFullDuplex(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)

```csharp
public void TransferFullDuplex(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)
```

Full-duplex transfer with explicit slice offsets and lengths.

### TransferSequential(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)

```csharp
public void TransferSequential(byte[] writeBuffer, int writeOffset, int writeLength, byte[] readBuffer, int readOffset, int readLength)
```

Sequential write-then-read with explicit slice offsets and lengths; chip select stays asserted between the two phases.

### Write(byte[] buffer, int x, int y, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)

```csharp
public void Write(byte[] buffer, int x, int y, int width, int height, int originalWidth, int columnMultiplier, int rowMultiplier)
```

Writes a rectangular framebuffer region with optional pixel replication. `columnMultiplier` and `rowMultiplier` let the display driver scale up small framebuffers without a CPU-side resize.
