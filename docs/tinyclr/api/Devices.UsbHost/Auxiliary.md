---
title: "Auxiliary Class"
sidebar_label: "Auxiliary"
---

# Auxiliary Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors`

Represents additional auxiliary descriptors.

```csharp
public class Auxiliary : BaseDescriptor
```

## Constructors

### Auxiliary(byte[] buffer)

```csharp
public Auxiliary(byte[] buffer) : this(buffer, 0)
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |

### Auxiliary(byte[] buffer, int offset)

```csharp
public Auxiliary(byte[] buffer, int offset) : base((Descriptors.DescriptorType)buffer[offset + 1], buffer[offset])
```

Constructs a new descriptor.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer with which to populate the descriptor. |
| `offset` | `int` | The offset into the buffer at which to start. |

## Properties

### Payload

```csharp
public byte[] Payload { get; set; }
```

The payload of the descriptor excluding length and type.
