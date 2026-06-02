---
title: "ModbusTcpInterface Class"
sidebar_label: "ModbusTcpInterface"
---

# ModbusTcpInterface Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus.Interface` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

ModbusTcpInterface is a Modbus TCP implemention of the `IModbusInterface` interface to be used with `ModbusMaster` or `ModbusDevice`.

```csharp
public class ModbusTcpInterface : IModbusInterface, IDisposable
```

## Constructors

### ModbusTcpInterface(Socket socket, short maxDataLength, bool ownsSocket)

```csharp
public ModbusTcpInterface(Socket socket, short maxDataLength = 252, bool ownsSocket = false)
```

Creates a new Modbus TCP interface using an existing and fully initialized `System.Net.Sockets.Socket`. This interface can be used with `ModbusMaster` or `ModbusDevice`.

| Parameter | Type | Description |
|---|---|---|
| `socket` | `Socket` | Fully initialized `Socket`. |
| `maxDataLength` | `short` | Maximum allowed length of function code specific data. |
| `ownsSocket` | `bool` | true if the interface owns the `Socket` and should close it when disposed; else false. |

### ModbusTcpInterface(string host, int port, short maxDataLength)

```csharp
public ModbusTcpInterface(string host, int port = 502, short maxDataLength = 252)
```

Creates a new Modbus TCP interface. This will connect to a TCP server listening to the given port. This interface can be used with `ModbusMaster`.

| Parameter | Type | Description |
|---|---|---|
| `host` | `string` | Host name or ip address of the Modbus TCP device. |
| `port` | `int` | Port to which the devuice is listening. The Modbus TCP default port is 502. |
| `maxDataLength` | `short` | Maximum allowed length of function code specific data. |

## Properties

### MaxDataLength

```csharp
public short MaxDataLength { get; set; }
```

Gets the maximum function code specific data length (not including address, function code, ...) of e telegram.

### MaxTelegramLength

```csharp
public short MaxTelegramLength { get; set; }
```

Gets the maximum length of a Modbus telegram.

### IsDataAvailable

```csharp
public bool IsDataAvailable { get; }
```

Gets if there is currently data available on the interface.

### IsSocketConnected

```csharp
public bool IsSocketConnected { get; set; }
```

_No description available._

### IsConnectionOk

```csharp
public bool IsConnectionOk { get; }
```

Gets if the connection is ok _(inherited)_

## Methods

### StartDeviceListener(ModbusDevice device, int port, int maxConnections, short maxDataLength)

```csharp
public static ModbusTcpListener StartDeviceListener(ModbusDevice device, int port = 502, int maxConnections = 5, short maxDataLength = 252)
```

Creates a new Modbus TCP listener. This will start a TCP server listening to the given port.

| Parameter | Type | Description |
|---|---|---|
| `device` | `ModbusDevice` | Device to add the listeners to. |
| `port` | `int` | Port to listen. The Modbus TCP default port is 502. |
| `maxConnections` | `int` | Maximum number of allowed connections. The default is 5. |
| `maxDataLength` | `short` | Maximum allowed length of function code specific data. |

**Returns** `ModbusTcpListener` — Returns a new `ModbusTcpListener`.

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

### Dispose()

```csharp
public void Dispose()
```

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
