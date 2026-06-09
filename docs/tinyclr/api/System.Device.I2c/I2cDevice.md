---
title: "I2cDevice Class"
sidebar_label: "I2cDevice"
---

# I2cDevice Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.I2c`<br/>**Assembly:** `System.Device.I2c`<br/>**Namespace:** `System.Device.I2c`

.NET-style I²C device. Standard surface (`Read` / `Write` / `WriteRead`); internally TinyCLR routes calls through `GHIElectronics.TinyCLR.Devices.I2c.I2cController`.

```csharp
public abstract class I2cDevice : IDisposable
```

## Properties

### ConnectionSettings

```csharp
public abstract I2cConnectionSettings ConnectionSettings { get; }
```

The per-device bus settings (clock, mode, chip select, etc.). _(inherited)_

## Methods

### Create(I2cConnectionSettings settings)

```csharp
public static I2cDevice Create(I2cConnectionSettings settings)
```

Creates a WebRequest . _(inherited)_

**Returns** `I2cDevice`

### Read(byte[] buffer)

```csharp
public abstract void Read(byte[] buffer)
```

Read the data from internal buffer _(inherited)_

### Write(byte[] buffer)

```csharp
public abstract void Write(byte[] buffer)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

### WriteRead(byte[] writeBuffer, byte[] readBuffer)

```csharp
public abstract void WriteRead(byte[] writeBuffer, byte[] readBuffer)
```

Performs a register-style write-then-read transaction. _(inherited)_

### Dispose()

```csharp
public abstract void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_
