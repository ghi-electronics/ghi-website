---
title: "Endpoint Class"
sidebar_label: "Endpoint"
---

# Endpoint Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors`

Endpoint descriptor.

```csharp
public class Endpoint : BaseDescriptor
```

## Constructors

### Endpoint(byte[] buffer)

```csharp
public Endpoint(byte[] buffer) : this(buffer, 0)
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |

### Endpoint(byte[] buffer, int offset)

```csharp
public Endpoint(byte[] buffer, int offset) : this()
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |
| `offset` | `int` | The offset into the buffer at which to start. |

### Endpoint()

```csharp
protected Endpoint() : base(DescriptorType.Endpoint, Endpoint.LENGTH)
```

Constructs a new descriptor.

## Properties

### Address

```csharp
public byte Address { get; set; }
```

The endpoint address.

### Attributes

```csharp
public byte Attributes { get; set; }
```

The attributes of the endpoint.

### MaximumPacketSize

```csharp
public ushort MaximumPacketSize { get; set; }
```

The maximum packet size this endpoint can transmit.

### Interval

```csharp
public byte Interval { get; set; }
```

The interval for data transfer pooling in frame counts.

### AuxiliaryDescriptors

```csharp
public Auxiliary[] AuxiliaryDescriptors { get; set; }
```

Child auxiliary descriptors.

## Fields

### LENGTH

```csharp
public const byte LENGTH
```

The length of the descriptor in bytes.
