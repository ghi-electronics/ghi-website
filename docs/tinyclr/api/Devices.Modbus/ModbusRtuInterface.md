---
title: "ModbusRtuInterface Class"
sidebar_label: "ModbusRtuInterface"
---

# ModbusRtuInterface Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus.Interface` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

ModbusRtuInterface is a Modbus RTU implemention of the `IModbusInterface` interface to be used with `ModbusMaster` or `ModbusDevice`.

```csharp
public class ModbusRtuInterface : IModbusInterface
```

## Constructors

### ModbusRtuInterface(UartController serial, int baudRate, int dataBits, UartStopBitCount stopBits, UartParity parity, short maxDataLength)

```csharp
public ModbusRtuInterface(UartController serial, int baudRate, int dataBits, UartStopBitCount stopBits, UartParity parity, short maxDataLength = 252)
```

Creates a new Modbus RTU interface using an existing and fully initialized `UartController`. This interface can be used with `ModbusMaster` or `ModbusDevice`.

| Parameter | Type | Description |
|---|---|---|
| `serial` | `UartController` | Fully initialized `UartController`. |
| `baudRate` | `int` |  |
| `dataBits` | `int` |  |
| `stopBits` | `UartStopBitCount` |  |
| `parity` | `UartParity` |  |
| `maxDataLength` | `short` | Maximum number of data bytes |

## Properties

### UartController

```csharp
public UartController UartController { get; }
```

Gets the serial port which is used.

### MaxDataLength

```csharp
public short MaxDataLength { get; set; }
```

Gets the maximum data length (not including address, function code, ...) of e telegram.

### MaxTelegramLength

```csharp
public short MaxTelegramLength { get; set; }
```

Gets the maximum length of a Modbus telegram.

### IsDataAvailable

```csharp
public bool IsDataAvailable { get; }
```

Gets if there is currently dataavailable on the interface.

### IsConnectionOk

```csharp
public bool IsConnectionOk { get; }
```

Gets if the connection is ok

## Methods

### CreateTelegram(byte addr, byte fkt, short dataLength, byte[] buffer, out short telegramLength, out short dataPos, bool isResponse, ref object telegramContext)

```csharp
public void CreateTelegram(byte addr, byte fkt, short dataLength, byte[] buffer, out short telegramLength, out short dataPos, bool isResponse, ref object telegramContext)
```

Creates a new telegram for a modbus request or response. All data except the function code specific user data is written into the given buffer.

| Parameter | Type | Description |
|---|---|---|
| `addr` | `byte` | Device address. 0 = Breadcast, 1..247 are valid device addresses. |
| `fkt` | `byte` | Function code. `ModbusFunctionCode` |
| `dataLength` | `short` | Number of bytes for function code sspecific user data. |
| `buffer` | `byte[]` | Buffer to write data into. The buffer must be at least MaxTelegramLength - MaxDataLength + dataLength bytes long. |
| `telegramLength` | `out short` | Returns the total length of the telegram in bytes. |
| `dataPos` | `out short` | Returns the offset of the function code specific user data in buffer. |
| `isResponse` | `bool` | true if this is a response telegram; false if this is a request telegram. |
| `telegramContext` | `ref object` | If isResponse == false, this parameter returns the interface implementation specific data which must be passed to the ParseTelegram method of the received response. If isResponse == true, this parameter must be called with the telegramContext parameter returned by ParseTelegram of the request telegram. |

### PrepareWrite()

```csharp
public void PrepareWrite()
```

_No description available._

### PrepareRead()

```csharp
public void PrepareRead()
```

_No description available._

### SendTelegram(byte[] buffer, short telegramLength)

```csharp
public void SendTelegram(byte[] buffer, short telegramLength)
```

Sends the given telegram. If necessary additional information like a checksum can be inserted here.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Buffer containing the data. |
| `telegramLength` | `short` | Length of the telegram in bytes. |

### ReceiveTelegram(byte[] buffer, short desiredDataLength, int timeout, out short telegramLength)

```csharp
public bool ReceiveTelegram(byte[] buffer, short desiredDataLength, int timeout, out short telegramLength)
```

Waits and receives a telegram.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Buffer to write data into. |
| `desiredDataLength` | `short` | Desired length of the function code specific data in bytes. -1 if length is unknown. |
| `timeout` | `int` | Timeout in milliseconds to wait for the telegram. |
| `telegramLength` | `out short` | Returns the total length of the telegram in bytes. |

**Returns** `bool` — Returns true if the telegram was received successfully; false on timeout.

### ParseTelegram(byte[] buffer, short telegramLength, bool isResponse, ref object telegramContext, out byte address, out byte fkt, out short dataPos, out short dataLength)

```csharp
public bool ParseTelegram(byte[] buffer, short telegramLength, bool isResponse, ref object telegramContext, out byte address, out byte fkt, out short dataPos, out short dataLength)
```

Parses a telegram received by ReceiveTelegram.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Buffer containing the data. |
| `telegramLength` | `short` | Total length of the telegram in bytes. |
| `isResponse` | `bool` | true if the telegram is a response telegram; false if the telegram is a request telegram. |
| `telegramContext` | `ref object` | If isResponse == true: pass the telegramContext returned by CreateTelegram from the request. If isResponse == false: returns the telegramContext from the received request. It must pe passed to the CreateTelegram method for the response. |
| `address` | `out byte` | Returns the device address. |
| `fkt` | `out byte` | Returns the function code. |
| `dataPos` | `out short` | Returns the offset in buffer of the function code specific data. |
| `dataLength` | `out short` | Returns the length of the function code specific data. |

**Returns** `bool` — Returns true if this is the matching response according to the telegramContext; else false. If isResponse == false this method should return always true.

### ClearInputBuffer()

```csharp
public void ClearInputBuffer()
```

Removes all data from the input interface.

## Fields

### isOpen

```csharp
public bool isOpen
```

_No description available._
