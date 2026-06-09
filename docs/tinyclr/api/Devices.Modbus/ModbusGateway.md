---
title: "ModbusGateway Class"
sidebar_label: "ModbusGateway"
---

# ModbusGateway Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

Modbus TCP/RTU Gateway

```csharp
public class ModbusGateway : ModbusDevice
```

## Constructors

### ModbusGateway(byte deviceAddress)

```csharp
public ModbusGateway(byte deviceAddress) : base(deviceAddress)
```

Creates a new Modbus Gateway without any master interfaces.

| Parameter | Type | Description |
|---|---|---|
| `deviceAddress` | `byte` | Address of this device |

### ModbusGateway(byte deviceAddress, IModbusInterface masterInterface, int timeout)

```csharp
public ModbusGateway(byte deviceAddress, IModbusInterface masterInterface, int timeout) : this(deviceAddress)
```

Creates a new Modbus Gateway with a single master interface and an 1:1 device id mapping

| Parameter | Type | Description |
|---|---|---|
| `deviceAddress` | `byte` | Address of this device |
| `masterInterface` | `IModbusInterface` | Master interface to add |
| `timeout` | `int` | Timeout for master interface |

## Methods

### AddMaster(IModbusInterface masterInterface, int timeout)

```csharp
public void AddMaster(IModbusInterface masterInterface, int timeout)
```

Adds an additional master interface with a 1:1 device id mapping

| Parameter | Type | Description |
|---|---|---|
| `masterInterface` | `IModbusInterface` | Master interface to add |
| `timeout` | `int` | Timeout for master interface |

### AddMaster(IModbusInterface masterInterface, int timeout, Hashtable addressMap)

```csharp
public void AddMaster(IModbusInterface masterInterface, int timeout, Hashtable addressMap)
```

Adds an additional master interface with an custom device id mapping

| Parameter | Type | Description |
|---|---|---|
| `masterInterface` | `IModbusInterface` | master interface to add |
| `timeout` | `int` | Timeout for master interface |
| `addressMap` | `Hashtable` | A hashtable where the key is the incoming device id that is mapped to it's value as device id on the master interface. Both, key and value of the hashtable must be of type byte. |

### OnGetDeviceIdentification(ModbusObjectId objectId)

```csharp
protected override string OnGetDeviceIdentification(ModbusObjectId objectId)
```

Is called when the value of the object id is needed for a ReadDeviceIdentification request.

| Parameter | Type | Description |
|---|---|---|
| `objectId` | `ModbusObjectId` | Object id. |

**Returns** `string` — Returns the value of the requested object id.

### GetConformityLevel()

```csharp
protected override ModbusConformityLevel GetConformityLevel()
```

Is called when the maximum conformity level is needed for a ReadDeviceIdentification request.

**Returns** `ModbusConformityLevel` — Returns the maximum conformity level which is provided by this device.

### OnHandleTelegram(IModbusInterface intf, byte deviceAddress, bool isBroadcast, short telegramLength, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)

```csharp
protected override void OnHandleTelegram(IModbusInterface intf, byte deviceAddress, bool isBroadcast, short telegramLength, object telegramContext, ModbusFunctionCode fc, short dataPos, short dataLength)
```

Handles a received message.

| Parameter | Type | Description |
|---|---|---|
| `intf` | `IModbusInterface` | Interface by which te message was received. |
| `deviceAddress` | `byte` | Address of the target device |
| `isBroadcast` | `bool` | true if the message is a broadcast. For broadcast messages no reponse is sent. |
| `telegramLength` | `short` | Length of the message in bytes. |
| `telegramContext` | `object` | Interface specific message context. |
| `fc` | `ModbusFunctionCode` | Function code. |
| `dataPos` | `short` | Index of function code specific data. |
| `dataLength` | `short` | Length of the function code specific data in bytes. |
