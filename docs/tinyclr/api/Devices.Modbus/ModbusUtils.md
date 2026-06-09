---
title: "ModbusUtils Class"
sidebar_label: "ModbusUtils"
---

# ModbusUtils Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

Class with modbus utility functions

```csharp
public static class ModbusUtils
```

## Methods

### InsertUShort(byte[] buffer, int pos, ushort value)

```csharp
public static void InsertUShort(byte[] buffer, int pos, ushort value)
```

Inserts a unsigned short value into a byte array in big-endian format.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Byte array to write to |
| `pos` | `int` | Index to write to. |
| `value` | `ushort` | Value to write. |

### ExtractUShort(byte[] buffer, int pos)

```csharp
public static ushort ExtractUShort(byte[] buffer, int pos)
```

Extracts a unsigned short value from an byte array in big-endian format.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Byte array to read from |
| `pos` | `int` | Index to read from |

**Returns** `ushort` — Returns the unsigned short value.

### CalcCrc(byte[] buffer, int count)

```csharp
public static ushort CalcCrc(byte[] buffer, int count)
```

Calculates the Modbus RTU CRC16 checksumm

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Buffer containing the telegram. |
| `count` | `int` | Count of bytes to use for CRC (not including the 2 bytes for CRC). |

**Returns** `ushort` — Returns the 16 bit CRC
