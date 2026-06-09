---
title: "I2cConnectionSettings Class"
sidebar_label: "I2cConnectionSettings"
---

# I2cConnectionSettings Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c` · **Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`

Per-device I²C connection settings: address, bus speed, and master/slave role.

```csharp
public sealed class I2cConnectionSettings
```

## Constructors

### I2cConnectionSettings(int slaveAddress)

```csharp
public I2cConnectionSettings(int slaveAddress) : this(slaveAddress, I2cAddressFormat.SevenBit)
```

Builds a 7-bit master-mode settings object at standard speed.

| Parameter | Type | Description |
|---|---|---|
| `slaveAddress` | `int` |  |

### I2cConnectionSettings(int slaveAddress, uint busSpeed)

```csharp
public I2cConnectionSettings(int slaveAddress, uint busSpeed) : this(slaveAddress, I2cAddressFormat.SevenBit, busSpeed)
```

Builds a 7-bit master-mode settings object at the given bus speed.

| Parameter | Type | Description |
|---|---|---|
| `slaveAddress` | `int` |  |
| `busSpeed` | `uint` |  |

### I2cConnectionSettings(int slaveAddress, I2cAddressFormat addressFormat, uint busSpeed)

```csharp
public I2cConnectionSettings(int slaveAddress, I2cAddressFormat addressFormat, uint busSpeed = 100000) : this(slaveAddress, I2cMode.Master, addressFormat, busSpeed)
```

Builds a master-mode settings object with explicit address format.

| Parameter | Type | Description |
|---|---|---|
| `slaveAddress` | `int` |  |
| `addressFormat` | `I2cAddressFormat` |  |
| `busSpeed` | `uint` |  |

### I2cConnectionSettings(int slaveAddress, I2cMode mode)

```csharp
public I2cConnectionSettings(int slaveAddress, I2cMode mode) : this(slaveAddress, mode, I2cAddressFormat.SevenBit)
```

Builds a 7-bit settings object with the given role (master/slave).

| Parameter | Type | Description |
|---|---|---|
| `slaveAddress` | `int` |  |
| `mode` | `I2cMode` |  |

### I2cConnectionSettings(int slaveAddress, I2cMode mode, I2cAddressFormat addressFormat, uint busSpeed)

```csharp
public I2cConnectionSettings(int slaveAddress, I2cMode mode, I2cAddressFormat addressFormat, uint busSpeed = 100000) : this(slaveAddress, mode, addressFormat, busSpeed, false)
```

Builds a settings object with explicit role and address format.

| Parameter | Type | Description |
|---|---|---|
| `slaveAddress` | `int` |  |
| `mode` | `I2cMode` |  |
| `addressFormat` | `I2cAddressFormat` |  |
| `busSpeed` | `uint` |  |

### I2cConnectionSettings(int slaveAddress, I2cMode mode, I2cAddressFormat addressFormat, uint busSpeed, bool enableClockStretching)

```csharp
public I2cConnectionSettings(int slaveAddress, I2cMode mode, I2cAddressFormat addressFormat, uint busSpeed, bool enableClockStretching = false)
```

Builds a settings object with full control over every field.

| Parameter | Type | Description |
|---|---|---|
| `slaveAddress` | `int` |  |
| `mode` | `I2cMode` |  |
| `addressFormat` | `I2cAddressFormat` |  |
| `busSpeed` | `uint` |  |
| `enableClockStretching` | `bool` |  |

## Properties

### SlaveAddress

```csharp
public int SlaveAddress { get; set; }
```

The peer's slave address.

### AddressFormat

```csharp
public I2cAddressFormat AddressFormat { get; set; }
```

7-bit or 10-bit address format.

### BusSpeed

```csharp
public uint BusSpeed { get; set; }
```

Bus speed in Hz (e.g. 100_000 for standard, 400_000 for fast mode).

### Mode

```csharp
public I2cMode Mode { get; set; }
```

Whether this device acts as master or slave.

### EnableClockStretching

```csharp
public bool EnableClockStretching { get; set; }
```

Slave-mode only: allow the controller to stretch the clock while it's not ready.
