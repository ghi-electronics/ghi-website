---
title: "ModbusDevice Class"
sidebar_label: "ModbusDevice"
---

# ModbusDevice Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

ModbusDevice is a base class for any modbus device.

```csharp
public abstract class ModbusDevice
```

## Constructors

### ModbusDevice(byte deviceAddress, object syncObject)

```csharp
protected ModbusDevice(byte deviceAddress, object syncObject = null)
```

Creates a new ModebusDevice without assigned interfaces.

| Parameter | Type | Description |
|---|---|---|
| `deviceAddress` | `byte` | Device address. Must be between 1 and 247 for RTU and should be 248 for TCP. |
| `syncObject` | `object` | Optional object for communication interface synchronization. |

### ModbusDevice(IModbusInterface intf, byte deviceAddress, object syncObject)

```csharp
protected ModbusDevice(IModbusInterface intf, byte deviceAddress, object syncObject = null) : this(deviceAddress, syncObject)
```

Creates a new ModebusDevice with one initial interface.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Initial interface. |
| `deviceAddress` | `byte` | Device address. Must be between 1 and 247 for RTU and should be 248 for TCP. |
| `syncObject` | `object` | Optional object for communication interface synchronization. |

## Properties

### Buffer

```csharp
protected byte[] Buffer { get; }
```

Gets the internal buffer

### IsRunning

```csharp
public bool IsRunning { get; set; }
```

Gets if the interface message polling is running.

### Buffer1

```csharp
public byte[] Buffer1 { get; set; }
```

_No description available._

### Buffer2

```csharp
public byte[] Buffer2 { get; set; }
```

_No description available._

## Methods

### AddInterface(IModbusInterface intf)

```csharp
public void AddInterface(IModbusInterface intf)
```

Adds an additional interface to be polled for incoming messages.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface to add. |

### RemoveInterface(IModbusInterface intf)

```csharp
public void RemoveInterface(IModbusInterface intf)
```

Removes an interface.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface to remove. |

### Start()

```csharp
public void Start()
```

Start the interface message polling.

### Stop()

```csharp
public void Stop()
```

Stop the interface message polling.

### OnMessageReceived(IModbusInterface modbusInterface, byte deviceAddress, ModbusFunctionCode functionCode)

```csharp
protected virtual void OnMessageReceived(IModbusInterface modbusInterface, byte deviceAddress, ModbusFunctionCode functionCode)
```

Is called when ever a modbus message was received, no matter if it was for this device or not.

| Parameter | Type | Description |
|---|---|---|
| `modbusInterface` | `IModbusInterface` | Interface by which the message was received |
| `deviceAddress` | `byte` | Address to which device the message was sent |
| `functionCode` | `ModbusFunctionCode` | Function code |

### OnHandleTelegram(IModbusInterface intf, byte deviceAddress, bool isBroadcast, short telegramLength, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)

```csharp
protected virtual void OnHandleTelegram(IModbusInterface intf, byte deviceAddress, bool isBroadcast, short telegramLength, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)
```

Handles a received message.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface by which the message was received. |
| `deviceAddress` | `byte` | Address of the target device |
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no response is sent. |
| `telegramLength` | `short` | Length of the message in bytes. |
| `telegramContext` | `object` | Interface specific message context. |
| `fc` | `ModbusFunctionCode` | Function code. |
| `dataPos` | `short` | Index of function code specific data. |
| `dataLength` | `short` | Length of the function code specific data in bytes. |

### OnReadCoils(bool isBroadcast, ushort startAddress, ushort coilCount, byte[] coils)

```csharp
protected virtual ModbusErrorCode OnReadCoils(bool isBroadcast, ushort startAddress, ushort coilCount, byte[] coils)
```

Is called when a ReadCoils request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `startAddress` | `ushort` | Start address: 0x0000 .. 0xFFFF |
| `coilCount` | `ushort` | Number of coils to read: 1 .. 2000 |
| `coils` | `byte[]` | Byte array which must receive the coils. The coils are written as single bits into the array starting with coil 1 at the lsb. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnReadDiscreteInputs(bool isBroadcast, ushort startAddress, ushort inputCount, byte[] inputs)

```csharp
protected virtual ModbusErrorCode OnReadDiscreteInputs(bool isBroadcast, ushort startAddress, ushort inputCount, byte[] inputs)
```

Is called when a ReadDiscreteInputs request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `startAddress` | `ushort` | Start address: 0x0000 .. 0xFFFF |
| `inputCount` | `ushort` | Number of inputs to read: 1 .. 2000 |
| `inputs` | `byte[]` | Byte array which must receive the inputs. The inputs are written as single bits into the array starting with input 1 at the lsb. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnReadHoldingRegisters(bool isBroadcast, ushort startAddress, ushort[] registers)

```csharp
protected virtual ModbusErrorCode OnReadHoldingRegisters(bool isBroadcast, ushort startAddress, ushort[] registers)
```

Is called when a ReadHoldingRegisters request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `startAddress` | `ushort` | Start address: 0x0000 .. 0xFFFF |
| `registers` | `ushort[]` | Array in which the read register values must be written. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnReadInputRegisters(bool isBroadcast, ushort startAddress, ushort[] registers)

```csharp
protected virtual ModbusErrorCode OnReadInputRegisters(bool isBroadcast, ushort startAddress, ushort[] registers)
```

Is called when a ReadInputRegisters request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `startAddress` | `ushort` | Start address: 0x0000 .. 0xFFFF |
| `registers` | `ushort[]` | Array in which the read register values must be written. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnWriteSingleCoil(bool isBroadcast, ushort address, bool value)

```csharp
protected virtual ModbusErrorCode OnWriteSingleCoil(bool isBroadcast, ushort address, bool value)
```

Is called when a WriteSingleCoil request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `address` | `ushort` | Address of the coil: 0x0000 .. 0xFFFF |
| `value` | `bool` | Value to write. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnWriteSingleRegister(bool isBroadcast, ushort address, ushort value)

```csharp
protected virtual ModbusErrorCode OnWriteSingleRegister(bool isBroadcast, ushort address, ushort value)
```

Is called when a WriteSingleRegister request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `address` | `ushort` | Address of the register: 0x0000 .. 0xFFFF |
| `value` | `ushort` | Register value to write |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnWriteMultipleCoils(bool isBroadcast, ushort startAddress, ushort outputCount, byte[] values)

```csharp
protected virtual ModbusErrorCode OnWriteMultipleCoils(bool isBroadcast, ushort startAddress, ushort outputCount, byte[] values)
```

Is called when a WriteMultipleCoils request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `startAddress` | `ushort` | Start address: 0x0000 .. 0xFFFF |
| `outputCount` | `ushort` | Number of couils (bist) to write. |
| `values` | `byte[]` | Values to write. Each bit is a value, starting at the lsb. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnWriteMultipleRegisters(bool isBroadcast, ushort startAddress, ushort[] registers)

```csharp
protected virtual ModbusErrorCode OnWriteMultipleRegisters(bool isBroadcast, ushort startAddress, ushort[] registers)
```

Is called when a WriteMultipleRegisters request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `startAddress` | `ushort` | Start address: 0x0000 .. 0xFFFF |
| `registers` | `ushort[]` | Registers to write |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### OnReadWriteMultipleRegisters(bool isBroadcast, ushort writeStartAddress, ushort[] writeRegisters, ushort readStartAddress, ushort[] readRegisters)

```csharp
protected virtual ModbusErrorCode OnReadWriteMultipleRegisters(bool isBroadcast, ushort writeStartAddress, ushort[] writeRegisters, ushort readStartAddress, ushort[] readRegisters)
```

Is called when a ReadWriteMultipleRegisters request comes in.

| Parameter | Type | Description |
|---|---|---|
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `writeStartAddress` | `ushort` | Start address of writeRegisters: 0x0000 .. 0xFFFF |
| `writeRegisters` | `ushort[]` | Registers to write |
| `readStartAddress` | `ushort` | Start address readRegisters: 0x0000 .. 0xFFFF |
| `readRegisters` | `ushort[]` | Array to write the read registers into. |

**Returns** `ModbusErrorCode` — Returns `ModbusErrorCode.NoError` on success or any other `ModbusErrorCode` on errors.

### ReadDeviceIdentification(IModbusInterface intf, bool isBroadcast, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)

```csharp
protected virtual void ReadDeviceIdentification(IModbusInterface intf, bool isBroadcast, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)
```

Is called when the device identification of this devuice is requested.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface from wich the requst was received |
| `isBroadcast` | `bool` | true if request is a broadcast |
| `telegramContext` | `object` | Conext of the telegram |
| `fc` | `ModbusFunctionCode` | Function code |
| `dataPos` | `short` | Posittion (offset) of the data in the buffer |
| `dataLength` | `short` | Length of the data in the buffer |

### OnGetDeviceIdentification(ModbusObjectId objectId)

```csharp
protected abstract string OnGetDeviceIdentification(ModbusObjectId objectId)
```

Is called when the value of the object id is needed for a ReadDeviceIdentification request.

| Parameter | Type | Description |
|---|---|---|
| `objectId` | `ModbusObjectId` | Object id. |

**Returns** `string` — Returns the value of the requested object id.

### GetConformityLevel()

```csharp
protected abstract ModbusConformityLevel GetConformityLevel()
```

Is called when the maximum conformity level is needed for a ReadDeviceIdentification request.

**Returns** `ModbusConformityLevel` — Returns the maximum conformity level which is provided by this device.

### OnCustomTelegram(IModbusInterface intf, bool isBroadcast, byte[] buffer, short telegramLength, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)

```csharp
protected virtual bool OnCustomTelegram(IModbusInterface intf, bool isBroadcast, byte[] buffer, short telegramLength, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)
```

OnCustomTelegram is called for any function code which is not explicitly handeled by a On"FunctionCode" methos.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface which sent the request. |
| `isBroadcast` | `bool` | true if the request is a broadcast |
| `buffer` | `byte[]` | Buffer containing the message. |
| `telegramLength` | `short` | Total length of message in bytes. |
| `telegramContext` | `object` | Interface specific message context. |
| `fc` | `ModbusFunctionCode` | Function code. |
| `dataPos` | `short` | Index of the function code specific data. |
| `dataLength` | `short` | Length of the function code specific data in bytes. |

**Returns** `bool`

### SendErrorResult(IModbusInterface intf, bool isBroadcast, byte deviceAddress, object telegramContext, ModbusFunctionCode fc, ModbusErrorCode modbusErrorCode)

```csharp
protected virtual void SendErrorResult(IModbusInterface intf, bool isBroadcast, byte deviceAddress, object telegramContext, ModbusFunctionCode fc, ModbusErrorCode modbusErrorCode)
```

Sends a error result message.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface to send message to. |
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `deviceAddress` | `byte` | Device address for response |
| `telegramContext` | `object` | Interface specific telegram context. |
| `fc` | `ModbusFunctionCode` | Function code. The msg is automatically set. |
| `modbusErrorCode` | `ModbusErrorCode` | Modbus error code to send. |
