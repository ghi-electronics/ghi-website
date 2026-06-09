---
title: "ModbusTcpListener Class"
sidebar_label: "ModbusTcpListener"
---

# ModbusTcpListener Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus.Interface` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`

Listener for Mdbus TCP devices

```csharp
public class ModbusTcpListener : IDisposable
```

## Constructors

### ModbusTcpListener(ModbusDevice device, int port, int maxConnections, short maxDataLength)

```csharp
public ModbusTcpListener(ModbusDevice device, int port, int maxConnections, short maxDataLength)
```

Creates a new Modbus TCP listener. This will start a TCP server listening to the given port.

| Parameter | Type | Description |
|---|---|---|
| `device` | `ModbusDevice` | Device to add the listeners to. |
| `port` | `int` | Port to listen. The Modbus TCP default port is 502. |
| `maxConnections` | `int` | Maximum number of allowed connections. The default is 5. |
| `maxDataLength` | `short` | Maximum allowed length of function code specific data. |

## Methods

### Dispose()

```csharp
public void Dispose()
```

Disposes the listener and releases all resources
