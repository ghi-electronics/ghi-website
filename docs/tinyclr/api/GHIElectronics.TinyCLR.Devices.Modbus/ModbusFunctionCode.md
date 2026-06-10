---
title: "ModbusFunctionCode Enum"
sidebar_label: "ModbusFunctionCode"
---

# ModbusFunctionCode Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.Modbus`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus`

Modbus function codes

```csharp
public enum ModbusFunctionCode : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `ReadCoils` | `0x01` | Read colis (input/output bits) |
| `ReadDiscreteInputs` | `0x02` | Read discrete inputs (input bits) |
| `ReadHoldingRegisters` | `0x03` | Read holding registers (input/output registers) |
| `ReadInputRegisters` | `0x04` | Read input registers |
| `WriteSingleCoil` | `0x05` | Write single coil (input/output bit) |
| `WriteSingleRegister` | `0x06` | Write single registers (input/output register) |
| `ReadExceptionStatus` | `0x07` | Read exception status |
| `Diagnostics` | `0x08` | Diagnostics |
| `GetCommEventCounter` | `0x0b` | Get comm event counter |
| `GetCommEventLog` | `0x0c` | Get comm event log |
| `WriteMultipleCoils` | `0x0f` | Write multiple coils (input/output bits) |
| `WriteMultipleRegisters` | `0x10` | Write multiple registers (input/output registers) |
| `ReadWriteMultipleRegisters` | `0x17` | Read write multiple registers (input/output regsiters) The Write operation is performed first. |
| `ReadDeviceIdentification` | `0x2b` | Read device identification |
| `ReadDeviceIdentification2` | `0x0e` | Read device identification (again !?) |
