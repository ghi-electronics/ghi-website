---
title: "StringDescriptor Class"
sidebar_label: "StringDescriptor"
---

# StringDescriptor Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

A USB string descriptor.

```csharp
public class StringDescriptor : Descriptor
```

## Constructors

### StringDescriptor(byte index, string theString)

```csharp
public StringDescriptor(byte index, string theString) : base(index)
```

Creates a new string descriptor.

## Properties

### bIndex

```csharp
public byte bIndex { get; }
```

The index of the string descriptor.

## Fields

### sString

```csharp
public string sString
```

The string value.
