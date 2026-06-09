---
title: "Interface Class"
sidebar_label: "Interface"
---

# Interface Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors`

Interface descriptor.

```csharp
public class Interface : BaseDescriptor
```

## Constructors

### Interface(byte[] buffer)

```csharp
public Interface(byte[] buffer) : this(buffer, 0)
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |

### Interface(byte[] buffer, int offset)

```csharp
public Interface(byte[] buffer, int offset) : this()
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |
| `offset` | `int` | The offset into the buffer at which to start. |

### Interface()

```csharp
protected Interface() : base(DescriptorType.Interface, Interface.LENGTH)
```

Constructs a new descriptor.

## Properties

### Number

```csharp
public byte Number { get; set; }
```

The number of the interface.

### AlternateSetting

```csharp
public byte AlternateSetting { get; set; }
```

The value used to select alternate settings.

### NumberEndpoints

```csharp
public byte NumberEndpoints { get; set; }
```

The number of endpoints for this interface.

### ClassCode

```csharp
public byte ClassCode { get; set; }
```

The class code.

### SubclassCode

```csharp
public byte SubclassCode { get; set; }
```

The subclass code.

### ProtocolCode

```csharp
public byte ProtocolCode { get; set; }
```

The protocal code.

### Index

```csharp
public byte Index { get; set; }
```

The interface string descriptor index.

### AuxiliaryDescriptors

```csharp
public Auxiliary[] AuxiliaryDescriptors { get; set; }
```

Child auxiliary descriptors.

### Endpoints

```csharp
public Endpoint[] Endpoints { get; set; }
```

Child endpoint descriptors.

## Fields

### LENGTH

```csharp
public const byte LENGTH
```

The length of the descriptor in bytes.
