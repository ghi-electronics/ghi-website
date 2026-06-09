---
title: "OneWireController Class"
sidebar_label: "OneWireController"
---

# OneWireController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Onewire`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Onewire`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Onewire`

Software 1-Wire bus master driven from a single GPIO pin. Devices like DS18B20 temperature sensors and DS24xx ROM chips can be enumerated with `FindAllDevices`, addressed by 8-byte serial number, and then transacted with via `TouchReset` / `WriteByte` / `ReadByte`.

```csharp
public class OneWireController : IDisposable
```

## Constructors

### OneWireController(int pinNumber)

```csharp
public OneWireController(int pinNumber) : this(GpioController.GetDefault(), pinNumber)
```

Opens 1-Wire on a pin of the default `GpioController`.

| Parameter | Type | Description |
|---|---|---|
| `pinNumber` | `int` | GPIO pin number connected to the 1-Wire data line. |

### OneWireController(GpioController gpioController, int pinNumber)

```csharp
public OneWireController(GpioController gpioController, int pinNumber)
```

Opens 1-Wire on a pin of the supplied `GpioController`.

| Parameter | Type | Description |
|---|---|---|
| `gpioController` | `GpioController` | GPIO controller owning the data pin. |
| `pinNumber` | `int` | GPIO pin number connected to the 1-Wire data line. |

## Methods

### TouchReset()

```csharp
public extern int TouchReset()
```

Issues a 1-Wire reset pulse and returns the presence-detect result.

**Returns** `int` — Non-zero when at least one slave responded with a presence pulse.

### TouchBit(int sendbit)

```csharp
public extern int TouchBit(int sendbit)
```

Reads/writes a single bit on the bus (write-then-sample within one slot).

| Parameter | Type | Description |
|---|---|---|
| `sendbit` | `int` | Bit to drive (0 or 1). |

**Returns** `int` — The bit actually read back from the bus.

### TouchByte(int sendbyte)

```csharp
public extern int TouchByte(int sendbyte)
```

Reads/writes a single byte on the bus (LSB first).

| Parameter | Type | Description |
|---|---|---|
| `sendbyte` | `int` | Byte to send. |

**Returns** `int` — The byte actually read back during the same slot.

### WriteByte(int sendbyte)

```csharp
public extern int WriteByte(int sendbyte)
```

Writes a single byte; the read value is discarded.

| Parameter | Type | Description |
|---|---|---|
| `sendbyte` | `int` |  |

**Returns** `int`

### ReadByte()

```csharp
public extern int ReadByte()
```

Reads a single byte (drives 0xFF on the bus to sample the slave).

**Returns** `int`

### AcquireEx()

```csharp
public extern int AcquireEx()
```

Acquires exclusive access to the 1-Wire net. Returns a port number ≥ 0 on success.

**Returns** `int`

### Release()

```csharp
public extern int Release()
```

Releases a previously acquired 1-Wire net.

**Returns** `int`

### FindFirstDevice(bool performResetBeforeSearch, bool searchWithAlarmCommand)

```csharp
public extern int FindFirstDevice(bool performResetBeforeSearch, bool searchWithAlarmCommand)
```

Starts a 1-Wire ROM search. Returns non-zero if a device was found.

| Parameter | Type | Description |
|---|---|---|
| `performResetBeforeSearch` | `bool` | When true, issues a reset pulse before searching. |
| `searchWithAlarmCommand` | `bool` | When true, uses the alarm-search command (0xEC) instead of the regular search (0xF0). |

**Returns** `int`

### FindNextDevice(bool performResetBeforeSearch, bool searchWithAlarmCommand)

```csharp
public extern int FindNextDevice(bool performResetBeforeSearch, bool searchWithAlarmCommand)
```

Continues a ROM search started by `FindFirstDevice`.

| Parameter | Type | Description |
|---|---|---|
| `performResetBeforeSearch` | `bool` |  |
| `searchWithAlarmCommand` | `bool` |  |

**Returns** `int`

### SerialNum(byte[] sNum, bool read)

```csharp
public extern int SerialNum(byte[] sNum, bool read)
```

Reads or writes the 8-byte serial number of the last-discovered device.

| Parameter | Type | Description |
|---|---|---|
| `sNum` | `byte[]` | Serial-number buffer (8 bytes). |
| `read` | `bool` | True to read the discovered serial number into `sNum`; false to write `sNum` as the active target. |

**Returns** `int`

### FindAllDevices()

```csharp
public ArrayList FindAllDevices()
```

Enumerates every device on the bus and returns their 8-byte serial numbers. Acquires and releases the 1-Wire net internally. Returns null if the bus cannot be acquired.

**Returns** `ArrayList` — An `ArrayList` of byte[8] serial numbers, or null on failure.

### Dispose()

```csharp
public void Dispose()
```

Closes the GPIO pin.
