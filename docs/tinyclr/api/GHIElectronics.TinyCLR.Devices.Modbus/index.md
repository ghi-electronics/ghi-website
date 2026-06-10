---
title: "GHIElectronics.TinyCLR.Devices.Modbus"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.Modbus</h1>

**NuGet:** `GHIElectronics.TinyCLR.Devices.Modbus`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [DeviceIdentification](./DeviceIdentification.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Defines a device identification by id and value |
| [ModbusConst](./ModbusConst.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Some general constants for Modbus |
| [ModbusDevice](./ModbusDevice.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | ModbusDevice is a base class for any modbus device. |
| [ModbusException](./ModbusException.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Modbus communication related exception |
| [ModbusGateway](./ModbusGateway.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Modbus TCP/RTU Gateway |
| [ModbusMaster](./ModbusMaster.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | ModbusMaster provides the function code implementaions for a modbus master. |
| [ModbusRtuInterface](./ModbusRtuInterface.md) | `GHIElectronics.TinyCLR.Devices.Modbus.Interface` | ModbusRtuInterface is a Modbus RTU implemention of the `IModbusInterface` interface to be used with `ModbusMaster` or `ModbusDevice`. |
| [ModbusTcpInterface](./ModbusTcpInterface.md) | `GHIElectronics.TinyCLR.Devices.Modbus.Interface` | ModbusTcpInterface is a Modbus TCP implemention of the `IModbusInterface` interface to be used with `ModbusMaster` or `ModbusDevice`. |
| [ModbusTcpListener](./ModbusTcpListener.md) | `GHIElectronics.TinyCLR.Devices.Modbus.Interface` | Listener for Mdbus TCP devices |
| [ModbusUtils](./ModbusUtils.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Class with modbus utility functions |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IModbusInterface](./IModbusInterface.md) | `GHIElectronics.TinyCLR.Devices.Modbus.Interface` | Interface for physical modbus implementations |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [ModbusConformityLevel](./ModbusConformityLevel.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Identification conformity level of the device and type of supported access. |
| [ModbusErrorCode](./ModbusErrorCode.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Modbus error codes |
| [ModbusFunctionCode](./ModbusFunctionCode.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Modbus function codes |
| [ModbusObjectId](./ModbusObjectId.md) | `GHIElectronics.TinyCLR.Devices.Modbus` | Identifiers for the Device Identification elements. |
