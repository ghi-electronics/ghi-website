---
title: "IModbusInterface Interface"
sidebar_label: "IModbusInterface"
---

# IModbusInterface Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Modbus`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus.Interface`

Interface for physical modbus implementations

```csharp
public interface IModbusInterface
```

## Properties

### MaxDataLength

```csharp
short MaxDataLength { get; }
```

Gets the maximum data length (not including address, function code, ...) of e telegram.

### MaxTelegramLength

```csharp
short MaxTelegramLength { get; }
```

Gets the maximum length of a Modbus telegram.

### IsDataAvailable

```csharp
bool IsDataAvailable { get; }
```

Gets if there is currently data available on the interface.

### IsConnectionOk

```csharp
bool IsConnectionOk { get; }
```

Gets if the connection is ok

## Methods

### CreateTelegram(byte addr, byte fkt, short dataLength, byte[] buffer, out short telegramLength, out short dataPos, bool isResponse, ref object telegramContext)

```csharp
void CreateTelegram(byte addr, byte fkt, short dataLength, byte[] buffer, out short telegramLength, out short dataPos, bool isResponse, ref object telegramContext)
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
void PrepareWrite()
```

Prepares the interface for sending a telegram.

### PrepareRead()

```csharp
void PrepareRead()
```

Prepares the interface for receiving a telegram.

### SendTelegram(byte[] buffer, short telegramLength)

```csharp
void SendTelegram(byte[] buffer, short telegramLength)
```

Sends the given telegram. If necessary additional information like a checksum can be inserted here.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Buffer containing the data. |
| `telegramLength` | `short` | Length of the telegram in bytes. |

### ReceiveTelegram(byte[] buffer, short desiredDataLength, int timeout, out short telegramLength)

```csharp
bool ReceiveTelegram(byte[] buffer, short desiredDataLength, int timeout, out short telegramLength)
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
bool ParseTelegram(byte[] buffer, short telegramLength, bool isResponse, ref object telegramContext, out byte address, out byte fkt, out short dataPos, out short dataLength)
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
void ClearInputBuffer()
```

Removes all data from the input interface.
