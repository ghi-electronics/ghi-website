---
title: "SpiDevice Class"
sidebar_label: "SpiDevice"
---

# SpiDevice Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `System.Device.Spi`<br/>**Namespace:** `System.Device.Spi`

.NET-style SPI device. Standard surface (`Read` / `Write` / `TransferFullDuplex`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.Spi.SpiController`.

```csharp
public abstract class SpiDevice : IDisposable
```

## Properties

### ConnectionSettings

```csharp
public abstract SpiConnectionSettings ConnectionSettings { get; }
```

The settings this device was created with.

## Methods

### Create(SpiConnectionSettings settings)

```csharp
public static SpiDevice Create(SpiConnectionSettings settings)
```

Opens an SPI device with the given settings.

**Returns** `SpiDevice`

### Read(byte[] buffer)

```csharp
public abstract void Read(byte[] buffer)
```

Reads bytes from the device into the buffer.

### Write(byte[] buffer)

```csharp
public abstract void Write(byte[] buffer)
```

Writes the buffer to the device.

### TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)

```csharp
public abstract void TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)
```

Writes and reads at the same time (full duplex). Both buffers must be the same length.

### Dispose()

```csharp
public abstract void Dispose()
```

Closes the device and releases the bus.
