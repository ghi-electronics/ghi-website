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

_No description available._

## Methods

### Create(SpiConnectionSettings settings)

```csharp
public static SpiDevice Create(SpiConnectionSettings settings)
```

_No description available._

**Returns** `SpiDevice`

### Read(byte[] buffer)

```csharp
public abstract void Read(byte[] buffer)
```

_No description available._

### Write(byte[] buffer)

```csharp
public abstract void Write(byte[] buffer)
```

_No description available._

### TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)

```csharp
public abstract void TransferFullDuplex(byte[] writeBuffer, byte[] readBuffer)
```

_No description available._

### Dispose()

```csharp
public abstract void Dispose()
```

_No description available._
