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

The settings this device was created with.

## Methods

### Create(I2cConnectionSettings settings)

```csharp
public static I2cDevice Create(I2cConnectionSettings settings)
```

Opens an I²C device with the given settings.

**Returns** `I2cDevice`

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

### WriteRead(byte[] writeBuffer, byte[] readBuffer)

```csharp
public abstract void WriteRead(byte[] writeBuffer, byte[] readBuffer)
```

Writes, then reads back in a single transaction.

### Dispose()

```csharp
public abstract void Dispose()
```

Closes the device and releases the bus.
