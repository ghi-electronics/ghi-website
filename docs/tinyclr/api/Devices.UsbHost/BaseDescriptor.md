---
title: "BaseDescriptor Class"
sidebar_label: "BaseDescriptor"
---

# BaseDescriptor Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

The base USB descriptor.

```csharp
public class BaseDescriptor
```

## Constructors

### BaseDescriptor(DescriptorType type, byte length)

```csharp
protected BaseDescriptor(DescriptorType type, byte length)
```

Creates a new base descriptor

| Parameter | Type | Description |
|---|---|---|
| `type` | `DescriptorType` | The type of the derived descriptor |
| `length` | `byte` | The length of the descriptor. |

## Properties

### Length

```csharp
public byte Length { get; set; }
```

Length of descriptor in bytes.

### Type

```csharp
public DescriptorType Type { get; set; }
```

The type of the descriptor.
