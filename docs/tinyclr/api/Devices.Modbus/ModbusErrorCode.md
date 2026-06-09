---
title: "ModbusErrorCode Enum"
sidebar_label: "ModbusErrorCode"
---

# ModbusErrorCode Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

Modbus error codes

```csharp
public enum ModbusErrorCode : ushort
```

## Fields

| Name | Value | Description |
|---|---|---|
| `NoError` | `0x0000` | No error |
| `IllegalFunction` | `0x0001` | The function code received in the query is not an allowable action for the server. |
| `IllegalDataAddress` | `0x0002` | The data address received in the query is not an allowable address for the server. |
| `IllegalDataValue` | `0x0003` | A value contained in the query data field is not an allowable value for server. |
| `ServerDeviceFailure` | `0x0004` | An unrecoverable error occurred while the server was attempting to perform the requested action. |
| `Acknowledge` | `0x0005` | Specialized use in conjunction with programming commands. |
| `ServerDeviceBusy` | `0x0006` | Specialized use in conjunction with programming commands. |
| `NegativeAcknowledgement` | `0x0007` | Specialized use in conjunction with programming commands. |
| `MemoryParityError` | `0x0008` | Specialized use in conjunction with function codes 20 and 21 and reference type 6, to indicate that the extended file area failed to pass a consistency check. |
| `GatewayPathUnavailable` | `0x000a` | Specialized use in conjunction with gateways. |
| `GatewayTargetDeviceFailedToRespond` | `0x000b` | Specialized use in conjunction with gateways. |
| `Unspecified` | `0x0100` | Unspecifed internal error |
| `Timeout` | `0x0101` | Device response timeout |
| `CrcError` | `0x0102` | Check summ error |
| `ResponseTooShort` | `0x0103` | Response data to short. |
