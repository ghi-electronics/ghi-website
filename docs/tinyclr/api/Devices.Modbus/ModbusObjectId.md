---
title: "ModbusObjectId Enum"
sidebar_label: "ModbusObjectId"
---

# ModbusObjectId Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.Modbus`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Modbus`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Modbus`

Identifiers for the Device Identification elements.

```csharp
public enum ModbusObjectId : byte
```

## Fields

| Name | Value | Description |
|---|---|---|
| `VendorName` | `0x00` | VendorName (mandatory) |
| `ProductCode` | `0x01` | ProductCode (mandatory) |
| `MajorMinorRevision` | `0x02` | MajorMinorRevision (mandatory) |
| `VendorUrl` | `0x03` | VendorUrl (optional) |
| `ProductName` | `0x04` | ProductName (optional) |
| `ModelName` | `0x05` | ModelName (optional) |
| `UserApplicationName` | `0x06` | UserApplicationName (optional) |
| `ReservedFirst` | `0x07` | Fisrt reserved id (0x07 .. 0x7f are reserved) |
| `ReservedLast` | `0x7f` | Last reserved id (0x07 .. 0x7f are reserved) |
| `PrivareFirst` | `0x80` | First private (extended) id (0x80 .. 0xff are private) |
| `PrivateLast` | `0xff` | Last private (extended) id (0x80 .. 0xff are private) |
