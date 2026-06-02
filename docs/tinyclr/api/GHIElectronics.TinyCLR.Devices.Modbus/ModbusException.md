---
title: "ModbusException Class"
sidebar_label: "ModbusException"
---

# ModbusException Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

Modbus communication related exception

```csharp
public class ModbusException : Exception
```

## Constructors

### ModbusException(string message)

```csharp
public ModbusException(string message) : base(message)
```

Creates a new ModbusException from an message

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` | Message of the exception |

### ModbusException(ModbusErrorCode errorCode)

```csharp
public ModbusException(ModbusErrorCode errorCode)
```

Creates a new ModbusException from an error code

| Parameter | Type | Description |
|---|---|---|
| `errorCode` | `ModbusErrorCode` | Error code |

## Properties

### ErrorCode

```csharp
public ModbusErrorCode ErrorCode { get; set; }
```

Gets the modbus error code
