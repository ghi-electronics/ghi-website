---
title: "Configuration Class"
sidebar_label: "Configuration"
---

# Configuration Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Configuration descriptor.

```csharp
public class Configuration : BaseDescriptor
```

## Constructors

### Configuration(byte[] buffer)

```csharp
public Configuration(byte[] buffer) : this(buffer, 0)
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |

### Configuration(byte[] buffer, int offset)

```csharp
public Configuration(byte[] buffer, int offset) : this()
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |
| `offset` | `int` | The offset into the buffer at which to start. |

### Configuration()

```csharp
protected Configuration() : base(DescriptorType.Configuration, Configuration.LENGTH)
```

Constructs a new descriptor.

## Properties

### TotalLength

```csharp
public ushort TotalLength { get; set; }
```

Total length of the the data returned in bytes.

### NumberOfInterfaces

```csharp
public byte NumberOfInterfaces { get; set; }
```

The number of interfaces.

### Value

```csharp
public byte Value { get; set; }
```

The value to be used as an argument to select this configuration.

### Index

```csharp
public byte Index { get; set; }
```

The configuration string descriptor index.

### Attributes

```csharp
public byte Attributes { get; set; }
```

A bitmap representing the attributes of the device.

### MaxPower

```csharp
public byte MaxPower { get; set; }
```

The maximum power consumption in 2mA units.

### AuxiliaryDescriptors

```csharp
public Auxiliary[] AuxiliaryDescriptors { get; set; }
```

Child auxiliary descriptors.

### Interfaces

```csharp
public Interface[] Interfaces { get; set; }
```

Child interface descriptors.

## Methods

### FillChildren(byte[] bytes, int offset)

```csharp
public void FillChildren(byte[] bytes, int offset)
```

Walks a config-descriptor blob from `offset` to the end and fills `Interfaces`, the nested endpoints, and `AuxiliaryDescriptors`.

| Parameter | Type | Description |
|---|---|---|
| `bytes` | `byte[]` | The full configuration-descriptor blob (length = `TotalLength`). |
| `offset` | `int` | Byte offset to start parsing children — typically `LENGTH` when the blob starts with the configuration header. |

## Fields

### LENGTH

```csharp
public const byte LENGTH
```

The length of the descriptor in bytes.
