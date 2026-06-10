---
title: "ConfigurationDescriptor Class"
sidebar_label: "ConfigurationDescriptor"
---

# ConfigurationDescriptor Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

A USB configuration descriptor.

```csharp
public class ConfigurationDescriptor : Descriptor
```

## Constructors

### ConfigurationDescriptor(ushort MaxPower_mA, UsbInterface[] Interfaces)

```csharp
public ConfigurationDescriptor(ushort MaxPower_mA, UsbInterface[] Interfaces) : base(0)
```

Creates a new configuration descriptor.

## Fields

### ATTRIB_Base

```csharp
public const byte ATTRIB_Base
```

The base configuration attribute.

### ATTRIB_SelfPowered

```csharp
public const byte ATTRIB_SelfPowered
```

Attribute marking the device as self powered.

### ATTRIB_RemoteWakeup

```csharp
public const byte ATTRIB_RemoteWakeup
```

Attribute marking the device as supporting remote wakeup.

### interfaces

```csharp
public UsbInterface[] interfaces
```

The interfaces belonging to this configuration.

### iConfiguration

```csharp
public byte iConfiguration
```

The string index of the configuration.

### bmAttributes

```csharp
public byte bmAttributes
```

The configuration attributes.

### bMaxPower

```csharp
public byte bMaxPower
```

The maximum power the configuration uses, in 2 mA units.
