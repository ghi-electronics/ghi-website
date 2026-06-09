---
title: "GenericDescriptor Class"
sidebar_label: "GenericDescriptor"
---

# GenericDescriptor Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`

_No description available._

```csharp
public class GenericDescriptor : Descriptor
```

## Constructors

### GenericDescriptor(byte RequestType, ushort Value, byte[] Payload)

```csharp
public GenericDescriptor(byte RequestType, ushort Value, byte[] Payload) : base(0)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `RequestType` | `byte` |  |
| `Value` | `ushort` |  |
| `Payload` | `byte[]` |  |

## Fields

### REQUEST_OUT

```csharp
public const byte REQUEST_OUT
```

_No description available._

### REQUEST_IN

```csharp
public const byte REQUEST_IN
```

_No description available._

### REQUEST_Standard

```csharp
public const byte REQUEST_Standard
```

_No description available._

### REQUEST_Class

```csharp
public const byte REQUEST_Class
```

_No description available._

### REQUEST_Vendor

```csharp
public const byte REQUEST_Vendor
```

_No description available._

### REQUEST_Device

```csharp
public const byte REQUEST_Device
```

_No description available._

### REQUEST_Interface

```csharp
public const byte REQUEST_Interface
```

_No description available._

### REQUEST_Endpoint

```csharp
public const byte REQUEST_Endpoint
```

_No description available._

### REQUEST_Other

```csharp
public const byte REQUEST_Other
```

_No description available._

### bmRequestType

```csharp
public byte bmRequestType
```

_No description available._

### bRequest

```csharp
public byte bRequest
```

_No description available._

### wValue

```csharp
public ushort wValue
```

_No description available._

### wIndex

```csharp
public ushort wIndex
```

_No description available._

### payload

```csharp
public byte[] payload
```

_No description available._
