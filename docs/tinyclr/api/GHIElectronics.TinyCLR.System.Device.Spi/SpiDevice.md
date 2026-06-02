---
title: "SpiDevice Class"
sidebar_label: "SpiDevice"
---

# SpiDevice Class

**Namespace:** `System.Device.Spi` · **Assembly:** `GHIElectronics.TinyCLR.System.Device.Spi`

.NET-style SPI device. Standard surface (`Read` / `Write` / `TransferFullDuplex`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.Spi.SpiController`.

```csharp
public abstract class SpiDevice : IDisposable
```

## Properties

### ConnectionSettings

```csharp
public abstract SpiConnectionSettings ConnectionSettings { get; }
```

The per-device bus settings (clock, mode, chip select, etc.). _(inherited)_

## Methods

### Create(SpiConnectionSettings settings)

```csharp
public static SpiDevice Create(SpiConnectionSettings settings)
```

Creates a WebRequest . _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `settings` | `SpiConnectionSettings` |  |

**Returns** `SpiDevice`

### Read(byte[] buffer)

```csharp
public abstract void Read(byte[] buffer)
```

Read the data from internal buffer _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

### Write(byte[] buffer)

```csharp
public abstract void Write(byte[] buffer)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |

### TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)

```csharp
public abstract void TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)
```

Writes and reads simultaneously; both buffers must be the same length. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `writeBuffer` | `byte[]` | Bytes to transmit. |
| `readBuffer` | `byte[]` | Receives the bytes shifted in. |

### Dispose()

```csharp
public abstract void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
