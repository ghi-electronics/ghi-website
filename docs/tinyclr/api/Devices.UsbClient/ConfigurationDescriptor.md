---
title: "ConfigurationDescriptor Class"
sidebar_label: "ConfigurationDescriptor"
---

# ConfigurationDescriptor Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

_No description available._

```csharp
public class ConfigurationDescriptor : Descriptor
```

## Constructors

### ConfigurationDescriptor(ushort MaxPower_mA, UsbInterface[] Interfaces)

```csharp
public ConfigurationDescriptor(ushort MaxPower_mA, UsbInterface[] Interfaces) : base(0)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `MaxPower_mA` | `ushort` |  |
| `Interfaces` | `UsbInterface[]` |  |

## Fields

### ATTRIB_Base

```csharp
public const byte ATTRIB_Base
```

_No description available._

### ATTRIB_SelfPowered

```csharp
public const byte ATTRIB_SelfPowered
```

_No description available._

### ATTRIB_RemoteWakeup

```csharp
public const byte ATTRIB_RemoteWakeup
```

_No description available._

### interfaces

```csharp
public UsbInterface[] interfaces
```

_No description available._

### iConfiguration

```csharp
public byte iConfiguration
```

_No description available._

### bmAttributes

```csharp
public byte bmAttributes
```

_No description available._

### bMaxPower

```csharp
public byte bMaxPower
```

_No description available._
